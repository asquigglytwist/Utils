#pragma once
#include "stdafx.h"
#include <ctime>
#include <sstream>

#define INPUT_FILE_NAME_DEF _T("RegKeys.txt")
#define OUTPUT_FILE_NAME_DEF _T("Debug.log")

// CLA Prefix for Command Line Argument
#define CLA_IN_FILE _T("--infile")
#define CLA_OUT_FILE _T("--outfile")
#define CLA_ENABLE_DEBUG_OUT _T("--enabledebugout")
#define CLA_ENABLE_DEBUG_VIEW _T("--enabledebugview")

namespace PokeReg
{
	class ConfigHelper
	{
		bool m_bEnableDebug, m_bEnableDebugView, m_bEnableFileLogging;
		std::wstring m_wsInFileName, m_wsOutFileName;
		bool Init(int argc, _TCHAR* argv[]);
	public:
#ifdef _DEBUG
		ConfigHelper::ConfigHelper(int argc, _TCHAR* argv[]): m_bEnableDebug(true), m_bEnableDebugView(true), m_bEnableFileLogging(true),
			m_wsInFileName(INPUT_FILE_NAME_DEF)
#else
		ConfigHelper::ConfigHelper(int argc, _TCHAR* argv[]): m_bEnableDebug(false), m_bEnableDebugView(false), m_bEnableFileLogging(false),
			m_wsInFileName(INPUT_FILE_NAME_DEF)
#endif
		{
			m_wsOutFileName.clear();
			Init(argc, argv);
#ifdef _DEBUG
			if(m_bEnableFileLogging && m_wsOutFileName.empty())
			{
				LOGINFO(_T("No Output FileName provided; Falling back to default: %s."), OUTPUT_FILE_NAME_DEF);
				m_wsOutFileName = OUTPUT_FILE_NAME_DEF;
			}
#endif
		}
		ConfigHelper::~ConfigHelper(void) {}

		inline bool GetDebugEnabled() { return m_bEnableDebug; }
		inline bool GetDebugViewEnabled() { return m_bEnableDebugView; }
		inline const std::wstring GetInputFileName() { return m_wsInFileName; }

		static std::wstring GetTimeStamp()
		{
			time_t t = time(0);   // get time now
			struct tm now;
			if(_localtime64_s(&now, &t))
			{
				LOGERROR(_T("Unable to get time stamp."));
				return _T("");
			}
			std::wstringstream wssNow;
			wssNow << L"["
				<< (now.tm_year + 1900) << '/' 
					<< (now.tm_mon + 1) << '/'
					<<  now.tm_mday
					<< L"  "
					<< now.tm_hour << L"-"
					<< now.tm_min << L"-"
					<< now.tm_sec
					<< L"]  ";
			return wssNow.str();
		}
	};
}