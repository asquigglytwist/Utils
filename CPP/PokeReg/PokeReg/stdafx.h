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

/*
#ifndef _DEBUG
#define _DEBUG
#endif
*/
#define VERBOSE_LOGGING

#define PRINT_NEW_LINE { _tprintf(_T("\n")); }
#define LOGINFO(x, ...) { _tprintf(_T("[INFO]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGPASS(x, ...) { _tprintf(_T("[PASS]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGFAIL(x, ...) { _tprintf(_T("[FAIL]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }
#define LOGERROR(x, ...) { _tprintf(_T("[EROR]:  ")); _tprintf(x, __VA_ARGS__); PRINT_NEW_LINE; }

#ifdef _DEBUG
#ifdef VERBOSE_LOGGING
	#define LogVerbose(tszFormat, ...) { _tprintf(_T("[VERBOSE]:  ")); _tprintf(tszFormat, __VA_ARGS__); PRINT_NEW_LINE; }
#else
#define LogVerbose(tszFormat, ...)
#endif
	#define LOGDEBUG(tszFormat, ...) { _tprintf(L"[DBUG]:  "); _tprintf(tszFormat, __VA_ARGS__); PRINT_NEW_LINE; }
	#define PauseAndReturn(ReturnValue) { _tprintf(_T("\nPaused; Press any key to continue...\n")); _getch(); return ReturnValue; }
#else
	#define PauseAndReturn(ReturnValue) { /*_tprintf(_T("\nPaused; Press any key to continue...\n")); _getch();*/ return ReturnValue; }
	#define LOGDEBUG(tszFormat, ...)
	#define LogVerbose(tszFormat, ...)
#endif


#define INPUT_FILE_NAME L"RegKeys.txt"