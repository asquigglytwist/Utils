#include "stdafx.h"
#include "PokeReg.h"
#include "PokeRegHelper.h"

int _tmain(int argc, _TCHAR* argv[])
{
	#ifdef _DEBUG
		MessageBox(NULL,L"Attach",L"Attach",MB_OK);
	#endif
	_TCHAR* tszFileName = INPUT_FILE_NAME;
	if(argc != 2)
	{
		LOGDEBUG(_T("Value of argc is %d (not the expected 2); Falling back to default file name."), argc);
		//tszFileName = INPUT_FILE_NAME;
	}
	else
		tszFileName = argv[1];
	LOGDEBUG(_T("FileName: %s."), tszFileName);
	int iTotalLines = 0;
	std::vector<PokeReg::CPokeRegKey> regList;
	if(!PokeReg::PokeRegHelper::PopulateVectorFromFile(tszFileName, regList, iTotalLines))
	{
		LOGERROR(_T("Unable to populate array from file."));
		PauseAndReturn(-2);
	}
	LOGDEBUG(_T("Total %d valid entries"), regList.size());
	bool bIsWow64Machine = PokeReg::PokeRegHelper::IsWow64();
	int iTotal = 0, iProtected = 0, iNotProtected = 0, iNotPresent = 0;
	for(std::vector<PokeReg::CPokeRegKey>::iterator itr = regList.begin(); itr < regList.end(); itr++)
	{
		bool bIsKeyPresent = false;
		iTotal++;
		LOGDEBUG(_T("Poking registry key: %s."), itr->ToString());
		if(itr->TestProtection(bIsWow64Machine, bIsKeyPresent))
		{
			iProtected++;
			LOGSUCCESS(_T("Protection is available"));
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
	PauseAndReturn(0);
}