#pragma once
#ifndef CONFIGMANAGER_H
#define CONFIGMANAGER_H

#include "stdafx.h"
#include <string>
#include <vector>
#include <map>

constexpr auto ConfigMgr_BufferSize = 2048;

constexpr auto Section_BOMInfo = _T("BOMInformation");
constexpr auto Key_BOMFormatVersion = _T("FormatVersion");
constexpr auto Def_BOMFormatVersion = _T("1.0");
constexpr auto Key_BOMTimeStamp = _T("BOMGenerated");
constexpr auto Def_BOMTimeStamp = _T("");

constexpr auto Section_GenerateBaselineBOMConfig = _T("GenerateBaselineBOMConfig");
constexpr auto Key_ProductName = _T("ProductName");
constexpr auto Key_ProductVersion = _T("ProductVersion");
constexpr auto Key_ProductPlatform = _T("ProductPlatform");
constexpr auto Key_ProductRegKey = _T("ProductRegKey");
constexpr auto Key_ProductRegValue = _T("ProductRegValue");
constexpr auto Key_ScanRecursively = _T("EnableRecursiveScan");
constexpr auto Def_ProductName = _T("Microsoft Windows");
constexpr auto Def_ProductVersion = _T("10.0.14393");
#ifdef _WIN64
constexpr auto Def_ProductPlatform = _T("64");
#else
constexpr auto Def_ProductPlatform = _T("32");
#endif
constexpr auto Def_ProductRegKey = _T("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Environment");
constexpr auto Def_ProductRegValue = _T("windir");
constexpr auto Def_ScanRecursively = _T("false");

class INIManager
{
    CString m_csProductRootDirectory;
    _TCHAR m_tszConfigFile[ConfigMgr_BufferSize], m_tszBuf[ConfigMgr_BufferSize];

public:
    INIManager() = delete;
    INIManager(tstring tsProductRootDirectory, LPTSTR tszConfigFile) : m_csProductRootDirectory(tsProductRootDirectory.c_str())
    {
        _tcscpy_s(m_tszConfigFile, tszConfigFile);
        if (m_csProductRootDirectory.Right(1).Compare(_T("\\")))
        {
            m_csProductRootDirectory.Append(_T("\\"));
        }
    }
    
    ~INIManager(void)
    {
    }

    double GetBOMFormatVersion();
    bool IsRecursiveScanEnabled();
    tstring GetProductName();
    tstring GetProductVersion();
    tstring GetProductPlatform();
    tstring GetProductRegKey();
    tstring GetProductRegValueName();

    PropertyMapType GetFileInfo(tstring& tsFileName);
    std::vector<tstring> GetAllFileNames();

    bool WriteBOMFormatVersion();
    bool WriteBOMGeneratedTimeStamp();
    bool WriteProductName();
    bool WriteProductVersion();
    bool WriteProductPlatform();
    bool WriteFileInfo(tstring & tsFilePath, PropertyMapType & mapFileInfo);

    bool WriteExampleConfig();
};

#endif // !CONFIGMANAGER_H
