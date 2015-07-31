#pragma once
#include "stdafx.h"
#include <ctime>
#include <sstream>
#include <iostream>

#define INPUT_FILE_NAME_DEF _T("RegKeys.txt")
#define OUTPUT_FILE_NAME_DEF _T("Unique.log")

// CLA Prefix for Command Line Argument
#define CLA_IN_FILE _T("--infile")
#define CLA_OUT_FILE _T("--outfile")
#define CLA_ENABLE_DEBUG_OUT _T("--enabledebugout")
#define CLA_ENABLE_DEBUG_VIEW _T("--enabledebugview")
#define CLA_MODE_BOT _T("--botmode")

namespace PokeReg
{
	class ConfigHelper
	{
	private:
		bool m_bEnableDebug, m_bEnableDebugView, m_bEnableFileLogging, m_bBotMode;
		std::wstring m_wsInFileName, m_wsOutFileName;
		std::wofstream m_fsOutFile;
		bool Init(int argc, _TCHAR* argv[]);
		void DisplayUsage();
	public:
#ifdef _DEBUG
		ConfigHelper::ConfigHelper(int argc, _TCHAR* argv[]) : m_bEnableDebug(true), m_bEnableDebugView(true), m_bEnableFileLogging(true),
			m_bBotMode(false), m_wsInFileName(INPUT_FILE_NAME_DEF)
#else
		ConfigHelper::ConfigHelper(int argc, _TCHAR* argv[]) : m_bEnableDebug(false), m_bEnableDebugView(false), m_bEnableFileLogging(false),
			m_bBotMode(false), m_wsInFileName(INPUT_FILE_NAME_DEF)
#endif
		{
			m_wsOutFileName.clear();
			Init(argc, argv);
		}

		ConfigHelper::~ConfigHelper(void)
		{
			if(m_fsOutFile.is_open())
			{
				m_fsOutFile.flush();
				m_fsOutFile.close();
			}
		}

		inline bool IsDebugEnabled() { return m_bEnableDebug; }
		inline bool IsDebugViewEnabled() { return m_bEnableDebugView; }
		inline bool IsFileLoggingEnabled() { return m_bEnableFileLogging; }
		inline bool IsInBotMode() { return m_bBotMode; }
		inline const std::wstring GetInputFileName() { return m_wsInFileName; }

		void LogToFile(const _TCHAR* szMsg)
		{
			m_fsOutFile<<szMsg<<std::endl;
		}

		static std::wstring GetTimeStamp();
		static ReturnCodes IsWow64(bool& bIsWow64Machine);
		static ReturnCodes GetCurrentWorkingDirectory(ConfigHelper* config, std::wstring& wsCWD);
	};
}