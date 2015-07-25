#include "StdAfx.h"
#include "ConfigHelper.h"

namespace PokeReg
{
	bool ConfigHelper::Init(int argc, _TCHAR* argv[])
	{
		if(argc < 2 || !argv)
		{
			LOGINFO(_T("No commandline options were recieved."));
			return false;
		}
		for(int i = 1; i < argc; i++)
		{
			_TCHAR* tszCmd = argv[i];
			if(!_tcsicmp(tszCmd, CLA_IN_FILE))
			{
				LOGDEBUG(this, _T("Argument at %d is %s."), i, CLA_IN_FILE);
				i++;
				m_wsInFileName = argv[i];
				LOGINFO(_T("Input FileName detected: %s."), m_wsInFileName.c_str());
			}
			else if(!_tcsicmp(tszCmd, CLA_OUT_FILE))
			{
				LOGDEBUG(this, _T("Argument at %d is %s."), i, CLA_IN_FILE);
				i++;
				m_wsOutFileName = argv[i];
				m_bEnableFileLogging = true;
				LOGINFO(_T("Output FileName detected: %s."), m_wsOutFileName.c_str());
			}
			else if(!_tcsicmp(tszCmd, CLA_ENABLE_DEBUG_OUT))
			{
				LOGDEBUG(this, _T("Argument at %d is %s."), i, CLA_ENABLE_DEBUG_OUT);
				m_bEnableDebug = true;
				LOGINFO(_T("Debug Output Enabled."));
			}
			else if(!_tcsicmp(tszCmd, CLA_ENABLE_DEBUG_VIEW))
			{
				LOGDEBUG(this, _T("Argument at %d is %s."), i, CLA_ENABLE_DEBUG_VIEW);
				m_bEnableDebugView = true;
				LOGINFO(_T("Debug Output Enabled."));
			}
		}
		return true;
	}
}