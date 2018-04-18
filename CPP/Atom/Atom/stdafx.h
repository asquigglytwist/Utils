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
#include <iostream>
#include <string>
#include <sstream>
#include <map>
#include "ErrorCode.h"

#if UNICODE
typedef std::wstring tstring;
typedef std::wstringstream tstringstream;
typedef std::wostringstream tostringstream;
typedef std::wifstream tfstream;
#define to_tstring std::to_wstring
#define tcout std::wcout
#else
typedef std::string tstring;
typedef std::stringstream tstringstream;
typedef std::ostringstream tostringstream;
typedef std::ifstream tfstream;
#define to_tstring std::to_string
#define tcout std::cout
#endif

typedef std::map<tstring, tstring> PropertyMapType;

#define NAME_OF_TOOL _T("Atom")
#define USAGE_OF_TOOL NAME_OF_TOOL _T(".exe ")

constexpr auto FIELD_NAME_DELIM_CHAR = _T('=');
//#define FIELD_NAME_DELIM _T(" :<-[#]($)->: ")
#define FIELD_NAME_DELIM _T("=")
#define BLOCK_SEPARATOR _T("- - - - - - - - - - - - - - - - - - -")
#define NEW_LINE _T("\n")
#define DOUBLE_TAB_INDENT _T("\t\t")

constexpr auto EmptyString = _T("");
constexpr auto QuoteString = _T("\"");
