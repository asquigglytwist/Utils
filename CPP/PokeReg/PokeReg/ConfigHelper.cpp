#include "StdAfx.h"
#include "ConfigHelper.h"

namespace PokeReg
{
	void ConfigHelper::DisplayUsage()
	{
	}

	bool ConfigHelper::Init(int argc, _TCHAR* argv[])
	{
		if(argc < 2 || !argv)
		{
			LOGINFO(this, _T("No commandline options were recieved."));
			return false;
		}
		for(int i = 1; i < argc; i++)
		{
			_TCHAR* tszCmd = argv[i];
			if(!_tcsicmp(tszCmd, CLA_IN_FILE))
			{
				LOGDBUG(this, _T("Argument at %d is %s."), i, CLA_IN_FILE);
				i++;
				m_wsInFileName = argv[i];
				LOGINFO(this, _T("Input FileName detected: %s."), m_wsInFileName.c_str());
			}
			else if(!_tcsicmp(tszCmd, CLA_OUT_FILE))
			{
				LOGDBUG(this, _T("Argument at %d is %s."), i, CLA_OUT_FILE);
				i++;
				m_wsOutFileName = argv[i];
				m_bEnableFileLogging = true;
				LOGINFO(this, _T("Output FileName detected: %s."), m_wsOutFileName.c_str());
			}
			else if(!_tcsicmp(tszCmd, CLA_ENABLE_DEBUG_OUT))
			{
				LOGDBUG(this, _T("Argument at %d is %s."), i, CLA_ENABLE_DEBUG_OUT);
				m_bEnableDebug = true;
				LOGINFO(this, _T("Debug Output Enabled."));
			}
			else if(!_tcsicmp(tszCmd, CLA_ENABLE_DEBUG_VIEW))
			{
				LOGDBUG(this, _T("Argument at %d is %s."), i, CLA_ENABLE_DEBUG_VIEW);
				m_bEnableDebugView = true;
				LOGINFO(this, _T("Debug Output Enabled."));
			}
			else if(!_tcsicmp(tszCmd, CLA_MODE_BOT))
			{
				LOGDBUG(this, _T("Argument at %d is %s."), i, CLA_MODE_BOT);
				m_bBotMode = true;
				LOGINFO(this, _T("Bot Mode Enabled."));
			}
			else
			{
				LOGINFO(this, _T("Invalid command line parameter: %s."), argv[i]);
				DisplayUsage();
			}
		}
		if(m_bEnableFileLogging)
		{
			if(m_wsOutFileName.empty())
			{
				LOGDBUG(this, _T("No Output FileName provided; Falling back to default: %s."), OUTPUT_FILE_NAME_DEF);
				m_wsOutFileName = OUTPUT_FILE_NAME_DEF;
			}
		}
		return true;
	}

	std::wstring ConfigHelper::GetTimeStamp()
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
}