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

#ifndef _DEBUG
#define _DEBUG
#endif
#define VERBOSE_LOGGING

#define PauseAndReturn(ReturnValue) { wprintf(L"\nPaused; Press any key to continue...\n"); _getch(); return ReturnValue; }
#define LOGDEBUG(x, ...) { wprintf(L"[DEBUG]:  %s\n", x, __VA_ARGS__); }
#define LOGSUCCESS(x, ...) { wprintf(L"[SUCCESS]:  %s\n", x, __VA_ARGS__); }
#define LOGERROR(x, ...) { wprintf(L"[ERROR]:  %s\n", x, __VA_ARGS__); }

#ifdef _DEBUG
#ifdef VERBOSE_LOGGING
	#define LogVerbose(tszFormat, ...) { _tprintf(L"[VERBOSE]:  "); _tprintf(tszFormat, __VA_ARGS__); _tprintf(L"\n"); }
#else
#define LogVerbose(tszFormat, ...)
#endif
	#define LogDebug(tszFormat, ...) { _tprintf(L"[DEBUG]:  "); _tprintf(tszFormat, __VA_ARGS__); _tprintf(L"\n"); }
#else
	#define LogDebug(tszFormat, ...)
	#define LogVerbose(tszFormat, ...)
#endif


#define INPUT_FILE_NAME L"RegKeys.txt"