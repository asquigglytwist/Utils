#include "stdafx.h"
#include "PokeReg.h"
#include "PokeRegHelper.h"
#include "ConfigHelper.h"

int _tmain(int argc, _TCHAR* argv[])
{
#ifdef _DEBUG
		MessageBox(NULL,L"Attach",L"Attach",MB_OK);
#endif
	PokeReg::ConfigHelper* config = new PokeReg::ConfigHelper(argc, argv);
	const std::wstring &wsFileName = config->GetInputFileName();
	LOGINFO(_T("FileName: %s."), wsFileName);
	int iTotalLines = 0;
	std::vector<PokeReg::CPokeRegKey> regList;
	if(PokeReg::PokeRegHelper::PopulateVectorFromFile(wsFileName, regList, iTotalLines))
	{
		LOGERROR(_T("Unable to populate array from file."));
		PauseAndReturn(config, -1);
	}
	LOGINFO(_T("Total %d valid entries"), regList.size());
	bool bIsWow64Machine;
	PokeReg::PokeRegHelper::IsWow64(bIsWow64Machine);
	int iTotal = 0, iProtected = 0, iNotProtected = 0, iNotPresent = 0;
	for(std::vector<PokeReg::CPokeRegKey>::iterator itr = regList.begin(); itr < regList.end(); itr++)
	{
		bool bIsKeyPresent = false;
		iTotal++;
		LOGINFO(_T("Poking registry key: %s."), itr->ToString());
		if(itr->TestProtection(config, bIsWow64Machine, bIsKeyPresent))
		{
			iProtected++;
			LOGINFO(_T("Protection is available"));
		}
		else if(bIsKeyPresent)
		{
			iNotProtected++;
			LOGERROR(_T("Protection is not available "));
		}
		else
		{
			iNotPresent++;
			LOGERROR(_T("Key is not available"));
		}
	}
	LOG(_T("iTotalLines = %d\niTotal = %d\niProtected = %d\niNotProtected = %d\niNotPresent = %d"), iTotalLines, iTotal, iProtected, iNotProtected, iNotPresent);
	PauseAndReturn(config, SUCCESS);
}