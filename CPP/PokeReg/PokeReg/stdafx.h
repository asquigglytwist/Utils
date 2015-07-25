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
#define TEST_NAME L"Test"
#define TEST_VALUE TEST_NAME
#define SYSTEM L"SYSTEM\\"
#define CURRENT_CONTROL_SET SYSTEM L"CurrentControlSet\\"
#define CONTROL_SET_00 SYSTEM L"ControlSet00"

#define PRINT_NEW_LINE { _tprintf(_T("\n")); }
#define LOG(x, ...) { _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGINFO(x, ...) { _tprintf(_T("[INFO]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGPASS(x, ...) { _tprintf(_T("[PASS]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGFAIL(x, ...) { _tprintf(_T("[FAIL]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGERROR(x, ...) { _tprintf(_T("[EROR]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGDEBUG(config, tszFormat, ...) {\
	_TCHAR tszDebugMsg[BUFFER_SIZE];\
	swprintf_s(tszDebugMsg, BUFFER_SIZE, tszFormat, __VA_ARGS__);\
	std::wstring wsDebugMsg = config->GetTimeStamp(); wsDebugMsg.append(_T("[DBUG]  ")); wsDebugMsg.append(tszDebugMsg);\
	if(config->IsDebugEnabled()) { _tprintf(wsDebugMsg.c_str()); PRINT_NEW_LINE; }\
	if(config->IsDebugViewEnabled()) { OutputDebugString(wsDebugMsg.c_str()); PRINT_NEW_LINE; }\
}

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
	Last_Do_Not_Use
};