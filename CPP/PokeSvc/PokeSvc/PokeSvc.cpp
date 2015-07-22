// PokeSvc.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

DWORD g_dwSleepTimeInMS = DWORD_WAIT_TIME;
WCHAR* g_wszServiceName = L"BITS"; //Background Intelligent Transfer Service

bool StartServiceIfStopped(WCHAR* wszSvcName, DWORD dwDesiredAccess, DWORD& dwSvcOrigStatus)
{
	SC_HANDLE theService, scm;

	scm = OpenSCManager(0, 0, SC_MANAGER_CREATE_SERVICE);
	if (!scm)
	{
		LOGERROR(_T("OpenSCManager failed with error code: %d."), GetLastError());
		return false;
	}


	theService = OpenService(scm, wszSvcName, dwDesiredAccess);
	if (!theService)
	{
		CloseServiceHandle(scm);
		LOGERROR(_T("OpenService failed with error code: %d."), GetLastError());
		return false;
	}

	SERVICE_STATUS_PROCESS ssStatus;
	DWORD dwBytesNeeded;

	if(!QueryServiceStatusEx(theService, SC_STATUS_PROCESS_INFO, (LPBYTE)&ssStatus, sizeof(SERVICE_STATUS_PROCESS), &dwBytesNeeded))
	{
		CloseServiceHandle(theService);
		CloseServiceHandle(scm);
		dwSvcOrigStatus = ssStatus.dwCurrentState;
		LOGERROR(_T("QueryServiceStatusEx failed with error code: %d."), GetLastError());
		return false;
	}
	dwSvcOrigStatus = ssStatus.dwCurrentState;
	if(dwSvcOrigStatus != SERVICE_RUNNING && dwSvcOrigStatus != SERVICE_START_PENDING && dwSvcOrigStatus != SERVICE_STOP_PENDING)
	{
		StartService(theService, 0, NULL);
	}
	CloseServiceHandle(theService);
	CloseServiceHandle(scm);
	return true;
}

void PokeSvc(int iRetryCount = 0)
{
	DWORD dwSvcOrigStatus;
	++iRetryCount;
	if(StartServiceIfStopped(g_wszServiceName, SVC_QRYSTS_N_START, dwSvcOrigStatus))
	{
		if(dwSvcOrigStatus != SERVICE_STOPPED && dwSvcOrigStatus != SERVICE_STOP_PENDING)
		{
			LOGSUCCESS(L"Service status queried successfully; Was running already.")
		}
		else
		{
			LOGSUCCESS(L"Service queried and started successfully.")
		}
	}
	else if(iRetryCount < MAX_RETRY_ATTEMPTS)
	{
		while (SERVICE_STOP_PENDING == dwSvcOrigStatus)
		{
			LOGDEBUG(L"Attempt: %d;  Service is in SERVICE_STOP_PENDING state.  Will attempt again after a delay of %ldms.", iRetryCount, g_dwSleepTimeInMS);
			Sleep(g_dwSleepTimeInMS);
			PokeSvc(iRetryCount);
		}
	}
	else
	{
		LOGERROR(_T("StartServiceIfStopped failed."));
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	if(argc > 1)
	{
		g_wszServiceName = argv[1];
	}
	PokeSvc();
	return 0;
}

