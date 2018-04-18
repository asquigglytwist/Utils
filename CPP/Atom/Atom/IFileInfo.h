#pragma once
#ifndef IFILEINFO_H
#define IFILEINFO_H

#include "stdafx.h"
#include <WinTrust.h>
#include <Softpub.h>
#include <map>

#include "NSFileUtils.h"

#define MAKE_IFILEINFO_PURE_VIRTUAL 0

constexpr auto FLD_FILE_PATH = _T("FilePath");
constexpr auto FLD_FILE_SIZE = _T("FileSize");
constexpr auto FLD_FILE_MD5 = _T("HashMD5");
constexpr auto FLD_FILE_SHA1 = _T("HashSHA1");
constexpr auto FLD_FILE_SHA256 = _T("HashSHA256");

class IFileInfo
{
public:
    // Generic Functions (Rule of 5 but Move-Assignment Operator is not supported in VS 2015 now and hence skipped)
    IFileInfo() = delete;
    IFileInfo(IFileInfo&) = delete;
    IFileInfo(IFileInfo&&) noexcept = default;
    
    virtual ~IFileInfo() noexcept = default;
    
    IFileInfo(tstring filePath) : m_tsFilePath(filePath), m_liFileSize(NSFileUtils::GetSizeOfFile(m_tsFilePath.c_str()))
    {
        BYTE* pbFileContent = NSFileUtils::GetFileContentAsByteArray(filePath);
        if (pbFileContent != nullptr)
        {
            m_tsHashMD5 = NSFileUtils::GetHashString(pbFileContent, m_liFileSize, NSFileUtils::HashType::HashMd5);
            m_tsHashSHA1 = NSFileUtils::GetHashString(pbFileContent, m_liFileSize, NSFileUtils::HashType::HashSha1);
            m_tsHashSHA256 = NSFileUtils::GetHashString(pbFileContent, m_liFileSize, NSFileUtils::HashType::HashSha256);
            ::free(pbFileContent);
        }
    }

#if MAKE_IFILEINFO_PURE_VIRTUAL
    virtual bool CollectMetaData() = 0;
#endif

#define FIELD_FILE_PATH _T("FileName") FIELD_NAME_DELIM
#define FIELD_FILE_SIZE _T("FileSize") FIELD_NAME_DELIM
#define FIELD_FILE_MD5 _T("HashMD5") FIELD_NAME_DELIM
#define FIELD_FILE_SHA1 _T("HashSHA1") FIELD_NAME_DELIM
#define FIELD_FILE_SHA256 _T("HashSHA256") FIELD_NAME_DELIM

#if MAKE_IFILEINFO_PURE_VIRTUAL
    virtual PropertyMapType ToMap() = 0
#else
    virtual PropertyMapType ToMap()
#endif
    {
        PropertyMapType mapFileInfo;
        mapFileInfo[FLD_FILE_PATH] = m_tsFilePath;
        mapFileInfo[FLD_FILE_SIZE] = to_tstring(m_liFileSize);
        mapFileInfo[FLD_FILE_MD5] = m_tsHashMD5;
        mapFileInfo[FLD_FILE_SHA1] = m_tsHashSHA1;
        mapFileInfo[FLD_FILE_SHA256] = m_tsHashSHA256;
        return mapFileInfo;
    }
    //virtual void FromString(tstring) = 0;
protected:
    tstring m_tsFilePath;
private:
    decltype(NSFileUtils::GetSizeOfFile(nullptr)) m_liFileSize;
    decltype(NSFileUtils::GetHashString(nullptr, 0, NSFileUtils::HashType::HashMd5)) m_tsHashMD5, m_tsHashSHA1, m_tsHashSHA256;
};
#endif // !IFILEINFO_H
