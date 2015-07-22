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
#define LOGDEBUG(x, ...) { wprintf(L"[DEBUG]:  %s", x, __VA_ARGS__); }
#define LOGSUCCESS(x, ...) { wprintf(L"[SUCCESS]:  %s", x, __VA_ARGS__); }
#define LOGERROR(x, ...) { wprintf(L"[ERROR]:  %s", x, __VA_ARGS__); }

#define SVC_QRYSTS_N_START (SERVICE_QUERY_STATUS | SERVICE_START)
#define DWORD_WAIT_TIME 1000
#define MAX_RETRY_ATTEMPTS 10