#include "stdafx.h"
#include "SigCheckHandler.h"
#include "NSFileUtils.h"
#include "Logs.h"
#include <fstream>

namespace SigCheckHandler
{
    ErrorCode AcceptEULA()
    {
        DWORD dwExitCode = -1;
        return NSFileUtils::CreateProcAndWaitForExit(nullptr, AcceptEulaCMD, WaitTimeForEULAAcceptanceInMS, dwExitCode, nullptr, nullptr, nullptr);
    }

    tstring GetSigCheckPath()
    {
        static tstring tsTemp(EmptyString);
        if (tsTemp.empty())
        {
            tstringstream tssAppPath(NSFileUtils::GetCurrentPath(), std::ios_base::app | std::ios_base::out);
            tssAppPath << _T("\\") << SigCheckAppName;

            _TCHAR tszAppDosPath[MAX_PATH] = {};
            ::GetShortPathName(tssAppPath.str().c_str(), tszAppDosPath, MAX_PATH);
            LOGVERBOSE(_T("ShortPath for SigCheck at %s is %s."), tssAppPath.str().c_str(), tszAppDosPath);
            tsTemp = tstring(tszAppDosPath);
        }
        return tsTemp;
    }

    tstring GetOutFilePath(bool bUseTempFile)
    {
        static tstring tsTemp(EmptyString);
        if (tsTemp.empty())
        {
            if (bUseTempFile)
            {
                _TCHAR tszBuffer[MAX_PATH];
                if (::GetTempFileName(_T("."), NAME_OF_TOOL, 0, tszBuffer) != FALSE)
                {
                    tsTemp = tstring(tszBuffer);
                }
                else
                {
                    tsTemp = GetOutFilePath(false);
                }
            }
            else
            {
                tstringstream tssOutFile(NSFileUtils::GetCurrentPath(), std::ios_base::app | std::ios_base::out);
                tssOutFile << _T("\\") << SigCheckOutFile;
                tsTemp = tssOutFile.str();
            }
            LOGVERBOSE(_T("Out file path is %s."), tsTemp.c_str());
        }
        return tsTemp;
    }

    ErrorCode SigCheckForFile(tstring tszFileName, SigCheckResults** sigCheckResults)
    {
        static tstring tsOutFilePath = GetOutFilePath();
        static tstring tsAppDosPath = GetSigCheckPath();

        tstringstream tssSystemCmdLine(_T("cmd.exe /S /C "), std::ios_base::app | std::ios_base::out);
        tssSystemCmdLine << tsAppDosPath.c_str();
        tssSystemCmdLine << _T(" ") << SigCheckArgs << QuoteString << tszFileName << QuoteString;
        tssSystemCmdLine << _T(" > ") << QuoteString << tsOutFilePath.c_str() << QuoteString;

        tstring cmd = tssSystemCmdLine.str();
        auto cmdRetVal = ::_tsystem(cmd.c_str());
        LOGDEBUG(_T("CMD %s returned %d."), cmd.c_str(), cmdRetVal);

        auto ecRetVal = ErrorCode::ProcessReturnedNonZero;
        if (cmdRetVal == 0)
        {
            tfstream tfsSigCheckOp(tsOutFilePath.c_str());
            tstring tsHeaderLine, tsValuesLine, tsHeaderToken, tsValueToken;
            std::getline(tfsSigCheckOp, tsHeaderLine);
            std::getline(tfsSigCheckOp, tsValuesLine);
            tstringstream tssHeader(tsHeaderLine), tssValues(tsValuesLine);

            PropertyMapType sigCheckInfoMap;

            // [BIB]:  http://stackoverflow.com/questions/10681112/extracting-a-string-in-between-symbols
            size_t start = 0, end;
            while (std::getline(tssHeader, tsHeaderToken, _T(',')))
            {
                start++;
                end = tsValuesLine.find(_T('"'), start);
                if (end != tstring::npos)
                {
                    tsValueToken = tsValuesLine.substr(start, end - start);
                    sigCheckInfoMap[tsHeaderToken] = tsValueToken;
                    start = end + 2;
                }
                else
                {
                    return ErrorCode::SigCheckOutputParseFailure;
                }
            }
            (*sigCheckResults) = new SigCheckResults(sigCheckInfoMap);
            ecRetVal = ErrorCode::Success;
        }
        ::DeleteFile(tsOutFilePath.c_str());
        return ecRetVal;
    }

    SigCheckResults::SigCheckResults(PropertyMapType mapOfSigCheckOutPut) :
        m_tsDate(mapOfSigCheckOutPut[SCFN_Date]),
        m_tsPublisher(mapOfSigCheckOutPut[SCFN_Publisher]),
        m_tsCompany(mapOfSigCheckOutPut[SCFN_Company]),
        m_tsDescription(mapOfSigCheckOutPut[SCFN_Description]),
        m_tsProduct(mapOfSigCheckOutPut[SCFN_Product]),
        m_tsOriginalName(mapOfSigCheckOutPut[SCFN_OriginalName]),
        m_tsInternalName(mapOfSigCheckOutPut[SCFN_InternalName]),
        m_tsCopyright(mapOfSigCheckOutPut[SCFN_Copyright]),
        m_tsComments(mapOfSigCheckOutPut[SCFN_Comments]),
        m_vProductVersion(mapOfSigCheckOutPut[SCFN_ProductVersion]),
        m_vFilveVersion(mapOfSigCheckOutPut[SCFN_FileVersion]),
        m_vBinaryVersion(mapOfSigCheckOutPut[SCFN_BinaryVersion])
    {
        if (_tcsicmp(mapOfSigCheckOutPut[SCFN_Verified].c_str(), _T("Signed")) == 0)
        {
            m_bVerified = true;
        }
        else
        {
            m_bVerified = false;
        }
        auto machineTypeStr = mapOfSigCheckOutPut[SCFN_MachineType].c_str();
        if (_tcsicmp(machineTypeStr, MachineType64BitString) == 0)
        {
            m_MachineTypeInfo = MachineType::Bit64;
        }
        else if (_tcsicmp(machineTypeStr, MachineType32BitString) == 0)
        {
            m_MachineTypeInfo = MachineType::Bit32;
        }
        auto temp = mapOfSigCheckOutPut[SCFN_Entropy];
        m_dEntropy = std::stod(NSFileUtils::UnQuoteString(temp));
    }

    PropertyMapType SigCheckResults::ToMap()
    {
        PropertyMapType mapSigCheckResults;
        mapSigCheckResults[SCFN_BinaryVersion] = m_vBinaryVersion.ToString();
        mapSigCheckResults[SCFN_Comments] = m_tsComments;
        mapSigCheckResults[SCFN_Company] = m_tsCompany;
        mapSigCheckResults[SCFN_Copyright] = m_tsCopyright;
        mapSigCheckResults[SCFN_Date] = m_tsDate;
        mapSigCheckResults[SCFN_Description] = m_tsDescription;
        mapSigCheckResults[SCFN_Entropy] = to_tstring(m_dEntropy);
        mapSigCheckResults[SCFN_FileVersion] = m_vFilveVersion.ToString();
        mapSigCheckResults[SCFN_InternalName] = m_tsInternalName;
        auto tsMachineType = MachineTypeUnknownString;
        if (m_MachineTypeInfo == MachineType::Bit32)
        {
            tsMachineType = MachineType32BitString;
        }
        else if (m_MachineTypeInfo == MachineType::Bit64)
        {
            tsMachineType = MachineType64BitString;
        }
        mapSigCheckResults[SCFN_MachineType] = tsMachineType;
        mapSigCheckResults[SCFN_OriginalName] = m_tsOriginalName;
        mapSigCheckResults[SCFN_Product] = m_tsProduct;
        mapSigCheckResults[SCFN_ProductVersion] = m_vProductVersion.ToString();
        mapSigCheckResults[SCFN_Publisher] = m_tsPublisher;
        mapSigCheckResults[SCFN_Verified] = to_tstring(m_bVerified);
        return mapSigCheckResults;
    }
}