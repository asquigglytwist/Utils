#pragma once
#ifndef NSFILEUTILS_H
#define NSFILEUTILS_H

#include "stdafx.h"
#include <chrono>  // chrono::system_clock
#include <iomanip> // put_time

namespace NSFileUtils
{
    enum class HashType : short
    {
        HashMd5,
        HashSha1,
        HashSha256
    };

    _TCHAR* GetCurrentPath();
    _TCHAR* GetAppConfigPath();
    _TCHAR* GetExampleConfigPath();
    __int64 GetSizeOfFile(const _TCHAR* tszFileName);
    BYTE * GetFileContentAsByteArray(tstring tszFileName);
    tstring GetHashString(const void * data, const __int64 data_size, HashType hashType);
    tstring StringReplace(tstring& tsInput, tstring& tsFindThis, tstring& tsReplaceWithThis);
    tstring TrimString(tstring& tsStrToTrim, _TCHAR charToBeTrimmed = _T('"'));
    tstring CreateVersionOnlyString(tstring& tsVersionString);
    tstring UnQuoteString(tstring& tsQuotedString);
    ErrorCode CreateProcAndWaitForExit(LPTSTR appName, LPTSTR cmdLine, DWORD dwWaitTimeInMS, DWORD& dwExitCode, HANDLE hInput, HANDLE hOutput, HANDLE hError);
    tstring CurrentDateAndTime();
}

#endif // !NSFILEUTILS_H
