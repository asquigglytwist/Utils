// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>


#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS      // some CString constructors will be explicit

#include <atlbase.h>
#include <atlstr.h>

// TODO: reference additional headers your program requires here
#ifndef UNICODE
#define UNICODE
#endif
#include <xstring>
#include <vector>
#include <fstream>
#include <conio.h>

#define BUFFER_SIZE 2048

#define PRINT_NEW_LINE { _tprintf(_T("\n")); }
#define LOG(tszFormat, ...) { _tprintf(tszFormat, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOG_WITH_LEVEL(Level, config, tszFormat, ...) {\
	_TCHAR tszDebugMsg[BUFFER_SIZE];\
	swprintf_s(tszDebugMsg, BUFFER_SIZE, tszFormat, __VA_ARGS__);\
	std::wstring wsDebugMsg = config->GetTimeStamp(); wsDebugMsg.append(Level); wsDebugMsg.append(tszDebugMsg);\
	LOG(wsDebugMsg.c_str());\
	OutputDebugString(wsDebugMsg.c_str()); PRINT_NEW_LINE;\
	config->LogToFile(wsDebugMsg.c_str());\
}
#define LOGINFO(config, tszFormat, ...) { LOG_WITH_LEVEL(_T("[INFO]  "), config, tszFormat, __VA_ARGS__); }
#define LOGPASS(config, tszFormat, ...) { LOG_WITH_LEVEL(_T("[PASS]  "), config, tszFormat, __VA_ARGS__); }
#define LOGFAIL(config, tszFormat, ...) { LOG_WITH_LEVEL(_T("[FAIL]  "), config, tszFormat, __VA_ARGS__); }
#define LOGEROR(config, tszFormat, ...) { LOG_WITH_LEVEL(_T("[EROR]  "), config, tszFormat, __VA_ARGS__); }
#define LOGDBUG(config, tszFormat, ...) {\
	_TCHAR tszDebugMsg[BUFFER_SIZE];\
	swprintf_s(tszDebugMsg, BUFFER_SIZE, tszFormat, __VA_ARGS__);\
	std::wstring wsDebugMsg = config->GetTimeStamp(); wsDebugMsg.append(_T("[DBUG]  ")); wsDebugMsg.append(tszDebugMsg);\
	if(config->IsDebugEnabled()) { LOG(wsDebugMsg.c_str()); }\
	if(config->IsDebugViewEnabled()) { OutputDebugString(wsDebugMsg.c_str()); PRINT_NEW_LINE; }\
	if(config->IsFileLoggingEnabled()) { config->LogToFile(wsDebugMsg.c_str()); }\
}
//#define LOGERROR(tszFormat, ...) { _tprintf(_T("[ERROR]  ")); LOG(tszFormat, __VA_ARGS__); }

#ifdef _DEBUG
#define VERBOSE_LOGGING
#ifdef VERBOSE_LOGGING
	#define LogVerbose(tszFormat, ...) { _tprintf(_T("[VERBOSE]:  ")); _tprintf(tszFormat, __VA_ARGS__); PRINT_NEW_LINE; }
#else
#define LogVerbose(tszFormat, ...)
#endif
#else
	#define LogVerbose(tszFormat, ...)
#endif

#define PauseAndReturn(config, ReturnValue) {\
		if(!config->IsInBotMode())\
		{\
			_tprintf(_T("\nPaused; Press any key to continue...\n"));\
			_getch();\
		}\
		return ReturnValue;\
	}

enum ReturnCodes {
	SUCCESS = 0,
	NO_INPUT_FILE,
	INPUT_FILE_NOT_FOUND,
	WOW_CHECK_FAILED,
	GET_CWD_FAILED,
	Last_Do_Not_Use
};