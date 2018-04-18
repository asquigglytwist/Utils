#include "stdafx.h"
#include "BOMCreator.h"
#include "Logs.h"
#include "PEBinaryFileInfo.h"
#include "SigCheckHandler.h"

BOMCreator::BOMCreator(tstring& tsBOMFilePath, const _TCHAR* tszProductInstallDir) : m_CfgBOM(tszProductInstallDir, const_cast<LPTSTR>(tsBOMFilePath.c_str()))
{
    _tcscpy_s(m_tszProductInstallDir, MAX_PATH, tszProductInstallDir);
}

BOMCreator::~BOMCreator()
{
}

tstring BOMCreator::GenerateUniqueFileName(tstring& tsProdName)
{
    CString csBOMFile(NSFileUtils::GetCurrentPath()), csTimeStampedFileName;
    csTimeStampedFileName.Format(_T("\\%s  %s.%s"), NSFileUtils::CurrentDateAndTime().c_str(), tsProdName.c_str(), BOMFileExtension);
    csBOMFile.Append(csTimeStampedFileName);
    return tstring(csBOMFile);
}

bool BOMCreator::GenerateBOM(ErrorCode& ecBOMGenStatus, bool bIgnoreSigCheck, bool bScanRecursively)
{
    auto tsSigCheckPath = SigCheckHandler::GetSigCheckPath();
    if (::PathFileExists(tsSigCheckPath.c_str()) == FALSE)
    {
        LOGCRITICAL(_T("SysInternals Utility SigCheck does not exist at %s."), tsSigCheckPath.c_str());
        if (!bIgnoreSigCheck)
        {
            ecBOMGenStatus = ErrorCode::SigCheckNotFound;
            return false;
        }
    }
    auto acceptEULAStatus = SigCheckHandler::AcceptEULA();
    if (acceptEULAStatus != ErrorCode::Success)
    {
        LOGCRITICAL(_T("Unable to Accept EULA for SigCheck; Error [%d].  Hence exiting without generating BOM."), static_cast<int>(acceptEULAStatus));
        ecBOMGenStatus = ErrorCode::AcceptEULAFailed;
        return false;
    }
    std::vector<tstring> vecFileNames;
    this->ListFilesInDirectory(m_tszProductInstallDir, vecFileNames, bScanRecursively);
    if (vecFileNames.empty())
    {
        LOGACTIVITY(_T("No files were found in the specified directory."))
        return true;
    }

    if (m_CfgBOM.WriteBOMFormatVersion())
    {
        LOGDEBUG(_T("BOMFormatVersion written successfully."));
        if (m_CfgBOM.WriteProductName())
        {
            LOGDEBUG(_T("ProductName written successfully."));
            if (m_CfgBOM.WriteProductVersion())
            {
                LOGDEBUG(_T("ProductVersion written successfully."));
                if (m_CfgBOM.WriteProductPlatform())
                {
                    LOGDEBUG(_T("ProductPlatform written successfully."));
                    if (m_CfgBOM.WriteBOMGeneratedTimeStamp())
                    {
                        LOGDEBUG(_T("BOMGeneratedTimeStamp written successfully."));
                    }
                    else
                    {
                        LOGERROR(_T("Error [%ld] in writing BOMGeneratedTimeStamp."), ::GetLastError());
                    }
                }
                else
                {
                    LOGERROR(_T("Error [%ld] in writing ProductPlatform."), ::GetLastError());
                }
            }
            else
            {
                LOGERROR(_T("Error [%ld] in writing ProductVersion."), ::GetLastError());
            }
        }
        else
        {
            LOGERROR(_T("Error [%ld] in writing ProductName."), ::GetLastError());
        }
    }
    else
    {
        LOGERROR(_T("Error [%ld] in writing BOMFormatVersion."), ::GetLastError());
    }
    for (auto& fileName : vecFileNames)
    {
        auto tszFileName = fileName.c_str();
        LPTSTR tszFileExtension = ::PathFindExtension(tszFileName);
        if ((_tcsicmp(tszFileExtension, _T(".exe")) == 0) || (_tcsicmp(tszFileExtension, _T(".dll")) == 0))
        {
            PEBinaryFileInfo peBinFile(tszFileName);
            if (!m_CfgBOM.WriteFileInfo(fileName, peBinFile.ToMap()))
            {
                LOGERROR(_T("Error [%ld] when writing BOM information of PE binary file %s."), ::GetLastError(), tszFileName);
                return false;
            }
        }
        else
        {
            IFileInfo nonPEBinFile(tszFileName);
            if (!m_CfgBOM.WriteFileInfo(fileName, nonPEBinFile.ToMap()))
            {
                LOGERROR(_T("Error [%ld] when writing BOM information of Non-PE (binary) file %s."), ::GetLastError(), tszFileName);
                return false;
            }
        }
    }
    return true;
}

void BOMCreator::ListFilesInDirectory(_TCHAR* tszDirPath, std::vector<tstring>& vecFileNames, bool bScanRecursively)
{
    LOGVERBOSE(_T("Listing files %sin directory [%s]."), (bScanRecursively ? _T("recursively ") : _T("")), tszDirPath);
    // [BIB]:  http://stackoverflow.com/questions/3176208/files-in-directory-in-c
    HANDLE hFind;
    WIN32_FIND_DATA data;

    CString csPattern(tszDirPath);
    if (csPattern.Right(1).Compare(_T("\\")))
    {
        csPattern.Append(_T("\\*.*"));
    }
    else
    {
        csPattern.Append(_T("*.*"));
    }
    hFind = ::FindFirstFile(csPattern, &data);
    if (hFind != INVALID_HANDLE_VALUE)
    {
        _TCHAR tszTemp[MAX_PATH];
        do
        {
            ::PathCombine(tszTemp, tszDirPath, data.cFileName);
            LOGVERBOSE(_T("FileName:\t%s"), tszTemp);
            if (data.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY)
            {
                if (bScanRecursively)
                {
                    if (!((_tcscmp(data.cFileName, _T(".")) == 0) || (_tcscmp(data.cFileName, _T("..")) == 0)))
                    {
                        this->ListFilesInDirectory(tszTemp, vecFileNames, bScanRecursively);
                    }
                }
            }
            else
            {
                vecFileNames.push_back(tszTemp);
            }
        } while (::FindNextFile(hFind, &data));
        ::FindClose(hFind);
    }
}
