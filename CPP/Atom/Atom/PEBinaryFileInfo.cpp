#include "stdafx.h"
#include "PEBinaryFileInfo.h"
#include "Logs.h"

ErrorCode PEBinaryFileInfo::GetStatusOfEmbeddedSignature(const _TCHAR* tszFileName)
{
    // [BIB]:  https://msdn.microsoft.com/en-us/library/windows/desktop/aa382384(v=vs.85).aspx
    ErrorCode retVal;
    LONG lStatus;
    DWORD dwLastError;

    // Initialize the WINTRUST_FILE_INFO structure.
    WINTRUST_FILE_INFO FileData;
    memset(&FileData, 0, sizeof(FileData));
    FileData.cbStruct = sizeof(WINTRUST_FILE_INFO);
    FileData.pcwszFilePath = tszFileName;
    FileData.hFile = nullptr;
    FileData.pgKnownSubject = nullptr;

    /*
    WVTPolicyGUID specifies the policy to apply on the file
    WINTRUST_ACTION_GENERIC_VERIFY_V2 policy checks:

    1) The certificate used to sign the file chains up to a root
    certificate located in the trusted root certificate store. This
    implies that the identity of the publisher has been verified by
    a certification authority.

    2) In cases where user interface is displayed (which this example
    does not do), WinVerifyTrust will check for whether the
    end entity certificate is stored in the trusted publisher store,
    implying that the user trusts content from this publisher.

    3) The end entity certificate has sufficient permission to sign
    code, as indicated by the presence of a code signing EKU or no
    EKU.
    */
    GUID WVTPolicyGUID = WINTRUST_ACTION_GENERIC_VERIFY_V2;
    WINTRUST_DATA WinTrustData;

    // Initialize the WinVerifyTrust input data structure.
    // Default all fields to 0.
    memset(&WinTrustData, 0, sizeof(WinTrustData));
    WinTrustData.cbStruct = sizeof(WinTrustData);
    WinTrustData.pPolicyCallbackData = nullptr; // Use default code signing EKU.
    WinTrustData.pSIPClientData = nullptr; // No data to pass to SIP.
    WinTrustData.dwUIChoice = WTD_UI_NONE; // Disable WVT UI.
    WinTrustData.fdwRevocationChecks = WTD_REVOKE_NONE; // No revocation checking.
    WinTrustData.dwUnionChoice = WTD_CHOICE_FILE; // Verify an embedded signature on a file.
    WinTrustData.dwStateAction = WTD_STATEACTION_VERIFY; // Verify action.
    WinTrustData.hWVTStateData = nullptr; // Verification sets this value.
    WinTrustData.pwszURLReference = nullptr; // Not used.
    // This is not applicable if there is no UI because it changes 
    // the UI to accommodate running applications instead of 
    // installing applications.
    WinTrustData.dwUIContext = 0;
    // Set pFile.
    WinTrustData.pFile = &FileData;
    // WinVerifyTrust verifies signatures as specified by the GUID and Wintrust_Data.
    lStatus = ::WinVerifyTrust(nullptr, &WVTPolicyGUID, &WinTrustData);

    switch (lStatus)
    {
    case ERROR_SUCCESS:
        /*
        Signed file:
        - Hash that represents the subject is trusted.
        - Trusted publisher without any verification errors.
        - UI was disabled in dwUIChoice. No publisher or
        time stamp chain errors.
        - UI was enabled in dwUIChoice and the user clicked
        "Yes" when asked to install and run the signed
        subject.
        */
        LOGSUCCESS(_T("The file \"%s\" is signed and the signature was verified.\n"), tszFileName);
        retVal = ErrorCode::Success;
        break;
    case TRUST_E_NOSIGNATURE:
        // The file was not signed or had a signature 
        // that was not valid.
        // Get the reason for no signature.
        // The file was not signed.
        LOGERROR(_T("The file \"%s\" is not signed.\n"), tszFileName);
        dwLastError = ::GetLastError();
        if (TRUST_E_SUBJECT_FORM_UNKNOWN == dwLastError)
        {
            retVal = ErrorCode::Trust_Subject_Form_Unknown;
        }
        else if (TRUST_E_PROVIDER_UNKNOWN == dwLastError)
        {
            retVal = ErrorCode::Trust_Provider_Unknown;
        }
        else
        {
            // The signature was not valid or there was an error 
            // opening the file.
            retVal = ErrorCode::Trust_NoSignature;
            LOGERROR(_T("An unknown error occurred trying to verify the signature of the \"%s\" file.\n"), tszFileName);
        }
        break;
    case TRUST_E_EXPLICIT_DISTRUST:
        // The hash that represents the subject or the publisher 
        // is not allowed by the admin or user.
        retVal = ErrorCode::Trust_Explicit_Distrust;
        LOGERROR(_T("The signature is present, but specifically disallowed.\n"));
        break;
    case TRUST_E_SUBJECT_NOT_TRUSTED:
        // The user clicked "No" when asked to install and run.
        retVal = ErrorCode::Trust_Subject_Not_Trusted;
        LOGERROR(_T("The signature is present, but not trusted.\n"));
        break;
    case CRYPT_E_SECURITY_SETTINGS:
        /*
        The hash that represents the subject or the publisher
        was not explicitly trusted by the admin and the
        admin policy has disabled user trust. No signature,
        publisher or time stamp errors.
        */
        retVal = ErrorCode::Crypt_Security_Settings;
        LOGERROR(_T("CRYPT_E_SECURITY_SETTINGS - The hash representing the subject or the publisher wasn't explicitly trusted by the admin and admin policy has disabled user trust. No signature, publisher or timestamp errors.\n"));
        break;
    default:
        // The UI was disabled in dwUIChoice or the admin policy 
        // has disabled user trust. lStatus contains the 
        // publisher or time stamp chain error.
        retVal = ErrorCode::WinVerifyTrust_UnknownError;
        LOGERROR(_T("Error is: 0x%x.\n"), lStatus);
        break;
    }

    // Any hWVTStateData must be released by a call with close.
    WinTrustData.dwStateAction = WTD_STATEACTION_CLOSE;
    lStatus = ::WinVerifyTrust(nullptr, &WVTPolicyGUID, &WinTrustData);
    LOGVERBOSE(_T("Status of WTD_STATEACTION_CLOSE is [%ld]."), lStatus);
    return retVal;
}

ErrorCode PEBinaryFileInfo::CollectMetaData()
{
    auto fileName = this->m_tsFilePath.c_str();
    m_bAuthentiCodeCheckStatus = (PEBinaryFileInfo::GetStatusOfEmbeddedSignature(fileName) == ErrorCode::Success);
    auto sigCheckStatus = SigCheckHandler::SigCheckForFile(m_tsFilePath, &m_sigCheckResults);
    LOGDEBUG(_T("SigCheck for file %s returned %d."), fileName, static_cast<int>(sigCheckStatus));
    return sigCheckStatus;
}

#define FIELD_PEFILE_ISAUTHENTICODEVERIFIED _T("IsAuthentiCodeVerified") FIELD_NAME_DELIM
constexpr auto FLD_PEFILE_ISAUTHENTICODEVERIFIED = _T("IsAuthentiCodeVerified");

PropertyMapType PEBinaryFileInfo::ToMap()
{
    // [BIB]:  http://stackoverflow.com/questions/3639741/merge-two-stl-maps
    PropertyMapType mapFileInfo = IFileInfo::ToMap(), mapPEFileInfo;
    mapPEFileInfo.insert(mapFileInfo.begin(), mapFileInfo.end());
    auto metaDataCollectionStatus = CollectMetaData();
    mapPEFileInfo[FLD_PEFILE_ISAUTHENTICODEVERIFIED] = to_tstring(m_bAuthentiCodeCheckStatus);
    if ((metaDataCollectionStatus == ErrorCode::Success) && (m_sigCheckResults))
    {
        auto mapSigCheckResults = m_sigCheckResults->ToMap();
        mapPEFileInfo.insert(mapSigCheckResults.begin(), mapSigCheckResults.end());
    }
    return mapPEFileInfo;
}
