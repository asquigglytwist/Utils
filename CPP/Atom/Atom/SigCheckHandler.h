#pragma once
#ifndef SIGCHECKHANDLER_H
#define SIGCHECKHANDLER_H

#include "stdafx.h"
#include "Version.h"

namespace SigCheckHandler
{
    constexpr auto MachineType64BitString = _T("64-bit");
    constexpr auto MachineType32BitString = _T("32-bit");
    constexpr auto MachineTypeUnknownString = _T("Unknown");

    enum class MachineType
    {
        BitNone,
        Bit16,
        Bit32,
        Bit64
    };

    struct SigCheckResults
    {
        bool m_bVerified;
        tstring m_tsDate, m_tsPublisher, m_tsCompany, m_tsDescription, m_tsProduct, m_tsOriginalName, m_tsInternalName, m_tsCopyright, m_tsComments;
        MachineType m_MachineTypeInfo;
        double m_dEntropy;
        Version m_vProductVersion, m_vFilveVersion, m_vBinaryVersion;
        SigCheckResults(PropertyMapType);
        PropertyMapType ToMap();
    };

#if _WIN64
    constexpr LPTSTR SigCheckAppName = _T("sigcheck64.exe");
#else
    constexpr LPWSTR SigCheckAppName = _T("sigcheck.exe");
#endif
    constexpr LPTSTR SigCheckArgs = _T("-nobanner -a -c ");
    constexpr LPTSTR SigCheckOutFile = _T("SigCheck.out");
    constexpr LPTSTR AcceptEulaCMD = _T("reg.exe ADD \"HKCU\\Software\\Sysinternals\\Sigcheck\" /v EulaAccepted /t REG_DWORD /d 1 /f");
    constexpr DWORD WaitTimeForEULAAcceptanceInMS = (5 * 60 * 1000); // 5 min
    constexpr DWORD WaitTimeForSigCheckInMS = (5 * 60 * 1000); // 5 min

    ErrorCode AcceptEULA();
    ErrorCode SigCheckForFile(tstring tszFileName, SigCheckResults** sigCheckResults);
    tstring GetSigCheckPath();
    tstring GetOutFilePath(bool bUseTempFile = true);

    //constexpr LPTSTR SCFN_Path = _T("Path");
    constexpr LPTSTR SCFN_Verified = _T("Verified");
    constexpr LPTSTR SCFN_Date = _T("Date");
    constexpr LPTSTR SCFN_Publisher = _T("Publisher");
    constexpr LPTSTR SCFN_Company = _T("Company");
    constexpr LPTSTR SCFN_Description = _T("Description");
    constexpr LPTSTR SCFN_Product = _T("Product");
    constexpr LPTSTR SCFN_ProductVersion = _T("Product Version");
    constexpr LPTSTR SCFN_FileVersion = _T("File Version");
    constexpr LPTSTR SCFN_MachineType = _T("Machine Type");
    constexpr LPTSTR SCFN_BinaryVersion = _T("Binary Version");
    constexpr LPTSTR SCFN_OriginalName = _T("Original Name");
    constexpr LPTSTR SCFN_InternalName = _T("Internal Name");
    constexpr LPTSTR SCFN_Copyright = _T("Copyright");
    constexpr LPTSTR SCFN_Comments = _T("Comments");
    constexpr LPTSTR SCFN_Entropy = _T("Entropy");
}
#endif // !SIGCHECKHANDLER_H
