#include "stdafx.h"
#include "Logs.h"

LPCTSTR SevToStr(LogLevel nSeverity)
{
    switch (nSeverity)
    {
    case LogLevel::Success:
        return _T("SCS");
    case LogLevel::Activity:
        return _T("ACT");
    case LogLevel::Warning:
        return _T("WRN");
    case LogLevel::Error:
        return _T("ERR");
    case LogLevel::Critical:
        return _T("CRT");
    case LogLevel::Debug:
        return _T("DBG");
    case LogLevel::Verbose:
        return _T("VBS");
    }
    return _T("UNK");
}

LPTSTR Now()
{
    static SYSTEMTIME now;
    static _TCHAR tszTimeStamp[32];
    dout << _T("Getting LocalTime...") << std::endl;
    ::GetLocalTime(&now);
    swprintf_s(tszTimeStamp, _T("%04d-%02d-%02d  %02d:%02d:%02d:%03d"),
        now.wYear, now.wMonth, now.wDay, now.wHour, now.wMinute, now.wSecond, now.wMilliseconds);
    return tszTimeStamp;
}

void Log(LogLevel logLevelOfMsg, LPCTSTR tszFile, LPCTSTR tszFunction, int nLine, LPTSTR tszMsg, ...)
{
    if (!tszMsg)
    {
        return;
    }
    if (logLevelOfMsg > g_PermittedLogLevel)
    {
        return;
    }

    va_list _vl;
    va_start(_vl, tszMsg);
    static _TCHAR tszMetaData[METADATA_BUFFER_SIZE], tszLogMessage[LOGMESSAGE_BUFFER_SIZE];
    FILE *f = nullptr;
    _tfopen_s(&f, LOG_FILE, _T("a+"));

    if (f)
    {
        dout << _T("Emptying tszLogMessage...") << std::endl;
        tszMetaData[0] = tszLogMessage[0] = _T('\0');
        dout << _T("Dumping metadata to tszLogMessage...") << std::endl;
        swprintf_s(tszMetaData, _T("[%s] [%s] %s%d%s%s"),
            Now(),
            SevToStr(logLevelOfMsg), tszFile, nLine, tszFunction, tszMsg);
        dout << _T("...MetaData is") << tszMetaData << std::endl;
        dout << _T("Adding actual log message to tszLogMessage...") << std::endl;
        _vstprintf_s(tszLogMessage, tszMetaData, _vl);
        dout << _T("...LogMessage is") << tszLogMessage << std::endl;
        dout << _T("Writing tszLogMessage to file...") << std::endl;
        tcout << tszLogMessage << std::endl;
        _ftprintf_s(f, tszLogMessage);
        _ftprintf_s(f, _T("\n"));
        dout << _T("Dumping tszLogMessage to DbgView...") << std::endl;
        ::OutputDebugStringW(tszLogMessage);
        dout << _T("Closing file...") << std::endl;
        fclose(f);
    }
    va_end(_vl);
}