#include "StdAfx.h"
#include "INIManager.h"
#include "NSFileUtils.h"
#include "Logs.h"

double INIManager::GetBOMFormatVersion()
{
    ::GetPrivateProfileString(Section_BOMInfo, Key_BOMFormatVersion, Def_BOMFormatVersion, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return std::stod(m_tszBuf);
}

bool INIManager::IsRecursiveScanEnabled()
{
    ::GetPrivateProfileString(Section_BOMInfo, Key_ScanRecursively, Def_ScanRecursively, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    if (!_tcsicmp(m_tszBuf, Def_ScanRecursively))
    {
        return false;
    }
    return true;
}

tstring INIManager::GetProductName()
{
    ::GetPrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductName, Def_ProductName, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return tstring(m_tszBuf);
}

tstring INIManager::GetProductVersion()
{
    ::GetPrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductVersion, Def_ProductVersion, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return tstring(m_tszBuf);
}

tstring INIManager::GetProductPlatform()
{
    ::GetPrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductPlatform, Def_ProductPlatform, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return tstring(m_tszBuf);
}

tstring INIManager::GetProductRegKey()
{
    ::GetPrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductRegKey, Def_ProductRegKey, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return tstring(m_tszBuf);
}

tstring INIManager::GetProductRegValueName()
{
    ::GetPrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductRegValue, Def_ProductRegValue, m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    return tstring(m_tszBuf);
}

PropertyMapType INIManager::GetFileInfo(tstring& tsFileName)
{
    PropertyMapType mapFileInfo;
    DWORD dwCharsRead = ::GetPrivateProfileSection(tsFileName.c_str(), m_tszBuf, ConfigMgr_BufferSize, m_tszConfigFile);
    if(dwCharsRead > 1)
    {
        size_t sectionDataLength;
        _TCHAR *p = m_tszBuf;
        while(*p)
        {
            sectionDataLength = _tcslen(p);
            tstringstream tssKeyValuePair(p);
            tstring tsTokenKey, tsTokenValue;
            if(std::getline(tssKeyValuePair, tsTokenKey, FIELD_NAME_DELIM_CHAR))
            {
                std::getline(tssKeyValuePair, tsTokenValue);
                LOGDEBUG(_T("Line is:\n%s\n"), p);
                LOGDEBUG(_T("After Split:\n%s\t"), tsTokenKey.c_str());
                LOGDEBUG(_T(":\t%s"), tsTokenValue.c_str());
                mapFileInfo[tsTokenKey] = tsTokenValue;
            }
            p += (sectionDataLength + 1);
        }
    }
    return mapFileInfo;
}

std::vector<tstring> INIManager::GetAllFileNames()
{
    std::vector<tstring> fileNames;
    DWORD dwExpectedSize = sizeof(_TCHAR) * 270 * 260;
    _TCHAR* tszFileNames = new _TCHAR[dwExpectedSize];
    DWORD dwRetVal = ::GetPrivateProfileSectionNames(tszFileNames, dwExpectedSize, m_tszConfigFile);
    if(dwRetVal > 1)
    {
        size_t sectionNameLength;
        _TCHAR *p = tszFileNames; // Skip the first section as it is the BOM MetaData
        while(*p)
        {
            sectionNameLength = _tcslen(p);
            if(!((_tcsicmp(p, Section_BOMInfo) == 0) || (_tcsicmp(p, Section_GenerateBaselineBOMConfig) == 0)))
            {
                fileNames.push_back(p);
            }
            p += (sectionNameLength + 1);
        }
    }
    return fileNames;
}

bool INIManager::WriteBOMFormatVersion()
{
    return (::WritePrivateProfileString(Section_BOMInfo, Key_BOMFormatVersion, Def_BOMFormatVersion, m_tszConfigFile) != FALSE);
}

bool INIManager::WriteBOMGeneratedTimeStamp()
{
    return (::WritePrivateProfileString(Section_BOMInfo, Key_BOMTimeStamp, Now(), m_tszConfigFile) != FALSE);
}

bool INIManager::WriteProductName()
{
    return (::WritePrivateProfileString(Section_BOMInfo, Key_ProductName, Def_ProductName, m_tszConfigFile) != FALSE);
}

bool INIManager::WriteProductVersion()
{
    return (::WritePrivateProfileString(Section_BOMInfo, Key_ProductVersion, Def_ProductVersion, m_tszConfigFile) != FALSE);
}

bool INIManager::WriteProductPlatform()
{
    return (::WritePrivateProfileString(Section_BOMInfo, Key_ProductPlatform, Def_ProductPlatform, m_tszConfigFile) != FALSE);
}

bool INIManager::WriteFileInfo(tstring& tsFilePath, PropertyMapType& mapFileInfo)
{
    auto tszSectionName = NSFileUtils::StringReplace(tsFilePath, tstring(m_csProductRootDirectory), tstring(EmptyString));
    //return (::WritePrivateProfileSection(tszSectionName.c_str(), tsFileInfo.c_str(), m_tszConfigFile) != FALSE);
    bool bRetVal = true;
    for (auto& kvPair : mapFileInfo)
    {
        bRetVal = (bRetVal && (::WritePrivateProfileString(tszSectionName.c_str(), kvPair.first.c_str(), kvPair.second.c_str(), m_tszConfigFile) != FALSE));
    }
    return bRetVal;
}

bool INIManager::WriteExampleConfig()
{
    if (::WritePrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductName, Def_ProductName, m_tszConfigFile) != FALSE)
    {
        if (::WritePrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductVersion, Def_ProductVersion, m_tszConfigFile) != FALSE)
        {
            if (::WritePrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductRegKey, Def_ProductRegKey, m_tszConfigFile) != FALSE)
            {
                if (::WritePrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ProductRegValue, Def_ProductRegValue, m_tszConfigFile) != FALSE)
                {
                    if (::WritePrivateProfileString(Section_GenerateBaselineBOMConfig, Key_ScanRecursively, Def_ScanRecursively, m_tszConfigFile) != FALSE)
                    {
                        return true;
                    }
                }
            }
        }
    }
    return false;
}
