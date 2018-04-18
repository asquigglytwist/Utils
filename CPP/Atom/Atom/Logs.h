#ifndef LOGS_H
#define LOGS_H

#include "stdafx.h"
#include <iostream>

#if DEBUG_OUTPUT
#define dout tout
#else
#define dout 0 && tcout
#endif

constexpr auto METADATA_BUFFER_SIZE = 1024;
constexpr auto LOGMESSAGE_BUFFER_SIZE = 4096;
constexpr auto LOG_FILE = NAME_OF_TOOL _T(".log");

enum class LogLevel : int
{
    None,
    Critical,
    Error,
    Warning,
    Success,
    Activity,
    Debug,
    Verbose
};

#ifdef DEBUG
#define SOURCE_FILE_NAME (_T("[") _T(__FILE__) _T("] "))
#define SOURCE_FUNCTION_NAME (_T(" [") _T(__FUNCTION__) _T("]  "))
#define SOURCE_LINE_NUMBER (__LINE__)
#else
#define SOURCE_FILE_NAME (EmptyString)
#define SOURCE_FUNCTION_NAME (_T(" "))
#define SOURCE_LINE_NUMBER (0)
#endif

#define LOGSUCCESS(x, ...)			{Log(LogLevel::Success, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGACTIVITY(x, ...)			{Log(LogLevel::Activity, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGWARNING(x, ...)			{Log(LogLevel::Warning, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGERROR(x, ...)			{Log(LogLevel::Error, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGCRITICAL(x, ...)			{Log(LogLevel::Critical, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGDEBUG(x, ...)			{Log(LogLevel::Debug, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}
#define LOGVERBOSE(x, ...)			{Log(LogLevel::Verbose, SOURCE_FILE_NAME, SOURCE_FUNCTION_NAME, SOURCE_LINE_NUMBER, x, __VA_ARGS__);}

LPCTSTR SevToStr(LogLevel nSeverity);
LPTSTR Now();
void Log(LogLevel nSeverity, LPCTSTR tszFile, LPCTSTR tszFunction, int nLine, LPTSTR tszFormat, ...);

#ifdef DEBUG
constexpr auto g_PermittedLogLevel = LogLevel::Verbose;
#else
constexpr auto g_PermittedLogLevel = LogLevel::Warning;
#endif // DEBUG


#endif // !LOGS_H
