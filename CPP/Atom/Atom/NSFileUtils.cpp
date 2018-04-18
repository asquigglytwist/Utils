#include "stdafx.h"
#include "NSFileUtils.h"
#include <vector>
#include <comdef.h>

namespace NSFileUtils
{
    constexpr auto iMinModuleFileNameLength = 4;
    constexpr auto AppConfigFileName = NAME_OF_TOOL _T(".config"), ExampleAppConfigFileName = _T("[Example]  ") NAME_OF_TOOL _T(".config");

    tstring CurrentDateAndTime()
    {
        // [BIB]:  http://stackoverflow.com/questions/17223096/outputting-date-and-time-in-c-using-stdchrono
        auto now = std::chrono::system_clock::now();
        auto in_time_t = std::chrono::system_clock::to_time_t(now);

        tm tmLocal;
        localtime_s(&tmLocal, &in_time_t);
        tstringstream tssLocalTime;
        tssLocalTime << std::put_time(&tmLocal, _T("[%Y_%m_%d %H_%M_%S]"));
        return tssLocalTime.str();
    }

    _TCHAR* GetCurrentPath()
    {
        static _TCHAR tszCurrentPath[MAX_PATH] = {};
        if (!*tszCurrentPath)
        {
            if (::GetModuleFileName(NULL, tszCurrentPath, MAX_PATH) > iMinModuleFileNameLength)
            {
                ::PathRemoveFileSpec(tszCurrentPath);
            }
        }
        return tszCurrentPath;
    }

    _TCHAR* GetAppConfigPath()
    {
        static _TCHAR tszAppConfigFilePath[MAX_PATH] = {};
        if (!*tszAppConfigFilePath)
        {
            ::PathCombine(tszAppConfigFilePath, NSFileUtils::GetCurrentPath(), AppConfigFileName);
        }
        return tszAppConfigFilePath;
    }

    _TCHAR* GetExampleConfigPath()
    {
        static _TCHAR tszExampleAppConfigFilePath[MAX_PATH] = {};
        if (!*tszExampleAppConfigFilePath)
        {
            ::PathCombine(tszExampleAppConfigFilePath, NSFileUtils::GetCurrentPath(), ExampleAppConfigFileName);
        }
        return tszExampleAppConfigFilePath;
    }

    __int64 GetSizeOfFile(const _TCHAR* tszFileName)
    {
        // [BIB]:  http://stackoverflow.com/questions/8991192/check-filesize-without-opening-file-in-c
        WIN32_FILE_ATTRIBUTE_DATA fad;
        if (!::GetFileAttributesEx(tszFileName, GetFileExInfoStandard, &fad))
        {
            return (__int64)ErrorCode::File_UnableToGetSize; // error condition, could call GetLastError to find out more
        }
        LARGE_INTEGER size;
        size.HighPart = fad.nFileSizeHigh;
        size.LowPart = fad.nFileSizeLow;
        return size.QuadPart;
    }

    BYTE* GetFileContentAsByteArray(tstring tszFileName)
    {
        // [BIB]:  http://stackoverflow.com/questions/22059189/read-a-file-as-byte-array
        FILE *fileptr;
        BYTE *buffer;

        _bstr_t b(tszFileName.c_str());
        const char* c = b;
        if (::fopen_s(&fileptr, c, "rb"))  // Open the file in binary mode
        {
            return nullptr;
        }
        ::fseek(fileptr, 0, SEEK_END);          // Jump to the end of the file
        long filelen = ::ftell(fileptr);             // Get the current byte offset in the file
        ::rewind(fileptr);                      // Jump back to the beginning of the file

        buffer = (BYTE*)::malloc((filelen + 1) * sizeof(BYTE)); // Enough memory for file + \0
        ::fread(buffer, filelen, 1, fileptr); // Read in the entire file
        ::fclose(fileptr); // Close the file
        return buffer;
    }

    tstring GetHashString(const void * data, const __int64 data_size, HashType hashType)
    {
        // [BIB]:  http://stackoverflow.com/a/13259720
        HCRYPTPROV hProv = NULL;
        if (!::CryptAcquireContext(&hProv, nullptr, nullptr, PROV_RSA_AES, CRYPT_VERIFYCONTEXT))
        {
            return EmptyString;
        }
        BOOL hash_ok = FALSE;
        HCRYPTPROV hHash = NULL;
        switch (hashType)
        {
        case HashType::HashSha1:
            hash_ok = ::CryptCreateHash(hProv, CALG_SHA1, 0, 0, &hHash);
            break;
        case HashType::HashMd5:
            hash_ok = ::CryptCreateHash(hProv, CALG_MD5, 0, 0, &hHash);
            break;
        case HashType::HashSha256:
            hash_ok = ::CryptCreateHash(hProv, CALG_SHA_256, 0, 0, &hHash);
            break;
        }

        if (!hash_ok)
        {
            ::CryptReleaseContext(hProv, 0);
            return EmptyString;
        }
        if (!::CryptHashData(hHash, static_cast<const BYTE *>(data), static_cast<DWORD>(data_size), 0))
        {
            ::CryptDestroyHash(hHash);
            ::CryptReleaseContext(hProv, 0);
            return EmptyString;
        }
        DWORD cbHashSize = 0, dwCount = sizeof(DWORD);
        if (!::CryptGetHashParam(hHash, HP_HASHSIZE, (BYTE *)&cbHashSize, &dwCount, 0))
        {
            ::CryptDestroyHash(hHash);
            ::CryptReleaseContext(hProv, 0);
            return EmptyString;
        }
        std::vector<BYTE> buffer(cbHashSize);
        if (!CryptGetHashParam(hHash, HP_HASHVAL, reinterpret_cast<BYTE*>(&buffer[0]), &cbHashSize, 0))
        {
            ::CryptDestroyHash(hHash);
            ::CryptReleaseContext(hProv, 0);
            return EmptyString;
        }

        tstringstream oss;
        for (std::vector<BYTE>::const_iterator iter = buffer.begin(); iter != buffer.end(); ++iter)
        {
            oss.fill('0');
            oss.width(2);
            oss << std::hex << static_cast<const int>(*iter);
        }
        ::CryptDestroyHash(hHash);
        ::CryptReleaseContext(hProv, 0);
        return oss.str();
    }

    tstring StringReplace(tstring& tsInput, tstring& tsFindThis, tstring& tsReplaceWithThis)
    {
        CString csInput(tsInput.c_str());
        if (csInput.Replace(tsFindThis.c_str(), tsReplaceWithThis.c_str()) == 0)
        {
            return tsInput; // No replacement happened.
        }
        return tstring(csInput);
    }

    tstring TrimString(tstring& tsStrToTrim, _TCHAR charToBeTrimmed)
    {
        if (tsStrToTrim.length() < 3)
        {
            return EmptyString;
        }
        tstring tsTrimmedString = tsStrToTrim;
        auto start = tsStrToTrim.begin();
        auto end = tsStrToTrim.rbegin();
        if (*start == charToBeTrimmed)
        {
            tsTrimmedString = tsStrToTrim.substr(1);
        }
        if (*end == charToBeTrimmed)
        {
            tsTrimmedString = tsTrimmedString.substr(0, tsTrimmedString.length() - 1);
        }
        return tsTrimmedString;
    }

    tstring CreateVersionOnlyString(tstring& tsVersionString)
    {
        if (tsVersionString.length() < 3)
        {
            return EmptyString;
        }
        tostringstream tssOutput;
        auto start = tsVersionString.begin(), end = tsVersionString.end();
        _TCHAR current;
        while (start != end && (current = *start))
        {
            if ((current >= _T('0') && current <= _T('9')) || (current == _T('.')))
            {
                tssOutput << current;
            }
            start++;
        }
        return TrimString(tssOutput.str(), _T('.'));
    }

    tstring UnQuoteString(tstring& tsQuotedString)
    {
        return NSFileUtils::TrimString(tsQuotedString);
    }
    
    ErrorCode CreateProcAndWaitForExit(LPTSTR appName, LPTSTR cmdLine, DWORD dwWaitTimeInMS, DWORD& dwExitCode, HANDLE hInput, HANDLE hOutput, HANDLE hError)
    {
        STARTUPINFO si;
        PROCESS_INFORMATION pi;

        ::ZeroMemory(&si, sizeof(si));
        si.cb = sizeof(si);
        si.dwFlags |= STARTF_USESTDHANDLES;
        si.hStdInput = hInput;
        si.hStdError = hError;
        si.hStdOutput = hOutput;
        ::ZeroMemory(&pi, sizeof(pi));

#ifdef DEBUG
        DWORD dwProcessCreationFlags = CREATE_NEW_CONSOLE;
#else
        DWORD dwProcessCreationFlags = CREATE_NO_WINDOW;
#endif // !DEBUG

        // [BIB]:  http://stackoverflow.com/questions/10044230/unhandled-error-with-createprocess
        // [BIB]:  https://blogs.msdn.microsoft.com/oldnewthing/20090601-00/?p=18083/
        LPTSTR tszCmdline = _tcsdup(cmdLine);
        if (::CreateProcess(appName, tszCmdline, nullptr, nullptr, TRUE, dwProcessCreationFlags, nullptr, nullptr, &si, &pi))
        {
            auto waitRetCode = ::WaitForSingleObject(pi.hProcess, dwWaitTimeInMS);
            if (waitRetCode == WAIT_OBJECT_0)
            {
                if (::GetExitCodeProcess(pi.hProcess, &dwExitCode))
                {
                    if (dwExitCode == 0)
                    {
                        return ErrorCode::Success;
                    }
                    return ErrorCode::ProcessReturnedNonZero;
                }
                return ErrorCode::ProcessUnableToGetExitCode;
            }
            else
            {
                // TODO:  Handle the logic to either kill / retry depending on preferences
                return ErrorCode::ProcessWaitForExitFailed;
            }
            ::CloseHandle(pi.hProcess);
            ::CloseHandle(pi.hThread);
        }
        return ErrorCode::ProcessCreationFailed;
    }
}