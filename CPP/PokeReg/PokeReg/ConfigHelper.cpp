#include "StdAfx.h"
#include "ConfigHelper.h"

typedef BOOL (WINAPI *LPFN_ISWOW64PROCESS) (HANDLE, PBOOL);
LPFN_ISWOW64PROCESS fnIsWow64Process;

namespace PokeReg
{
	void ConfigHelper::DisplayUsage()
	{
		std::wcout<<L"The commands themselves are optional but their arg(s) if any, are not.\n"
			<<L"Commands\tEffects"<<std::endl;
		_TCHAR* tszCmds[] = { CLA_IN_FILE, CLA_OUT_FILE, CLA_ENABLE_DEBUG_OUT, CLA_ENABLE_DEBUG_VIEW, CLA_MODE_BOT, CLA_HELP_TEXT };
		_TCHAR* tszCmdOpts[] = { _T("<File-Name> (required param if used)"), _T("<File-Name> (required param if used)"), _T(""), _T(""), _T(""), _T("") };
		_TCHAR* tszEffects[] = {
			_T("Spcifies the input file, followed by the file's name or path."),
			_T("Spcifies the output (log) file, followed by the file's name or path."),
			_T("Include to enable debug output."),
			_T("Include to enable output on DebugView (OutputDebugString)."),
			_T("To invoke program in BotMode i.e., non-interactive mode."),
			_T("Displays this help message regarding the tool usage.")
		};
		int num_elements = sizeof( tszCmds ) / sizeof( tszCmds[0] );
		for(int i = 0; i < num_elements; i++)
		{
			std::wcout<<tszCmds[i]<<L"  "<<tszCmdOpts[i]<<L"\n\t\t"<<tszEffects[i]<<std::endl;
		}
	}

	bool ConfigHelper::Init(int argc, _TCHAR* argv[])
	{
#ifndef _DEBUG
		if(argc < 2 || !argv)
		{
			LOGINFO(this, _T("No commandline options were recieved."));
			return false;
		}
#endif
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
			else if(!_tcsicmp(tszCmd, CLA_HELP_TEXT) || !_tcsicmp(tszCmd, CLA_HELP_SYM))
			{
				m_bHelpMode = true;
				LOG(_T("Switching to Help mode; Displaying usage...\n"));
				DisplayUsage();
				return true;
			}
			else
			{
				m_bHelpMode = true;
				LOGINFO(this, _T("Invalid command line parameter: %s; Switching to Help mode."), argv[i]);
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
			m_fsOutFile.open(m_wsOutFileName, std::ios::out | std::ios::trunc);
		}
		return true;
	}

	std::wstring ConfigHelper::GetTimeStamp()
	{
		time_t t = time(0);   // get time now
		struct tm now;
		if(_localtime64_s(&now, &t))
		{
			LOG(_T("[ERROR]  Unable to get time stamp."));
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

	ReturnCodes ConfigHelper::GetCurrentWorkingDirectory(ConfigHelper* config, std::wstring& wsCWD)
	{
		_TCHAR szCwd[BUFFER_SIZE];
		DWORD dwNumCharsInPath = GetModuleFileName(NULL, szCwd, BUFFER_SIZE);
		if(dwNumCharsInPath)
		{
			wsCWD = szCwd;
			return SUCCESS;
		}
		return GET_CWD_FAILED;
	}

	ReturnCodes ConfigHelper::IsWow64(bool& bIsWow64Machine)
	{
		BOOL bIsWow64 = FALSE;
		ReturnCodes iRetVal = SUCCESS;

		//IsWow64Process is not available on all supported versions of Windows.
		//Use GetModuleHandle to get a handle to the DLL that contains the function
		//and GetProcAddress to get a pointer to the function if available.

		fnIsWow64Process = (LPFN_ISWOW64PROCESS) GetProcAddress(GetModuleHandle(TEXT("kernel32")), "IsWow64Process");

		if(NULL != fnIsWow64Process)
		{
			if (!fnIsWow64Process(GetCurrentProcess(), &bIsWow64))
			{
				iRetVal = WOW_CHECK_FAILED;
			}
		}
		bIsWow64Machine = (bIsWow64 != 0);
		return iRetVal;
	}
}