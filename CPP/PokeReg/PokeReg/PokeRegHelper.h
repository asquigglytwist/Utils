#include "stdafx.h"
#include <vector>

typedef BOOL (WINAPI *LPFN_ISWOW64PROCESS) (HANDLE, PBOOL);
LPFN_ISWOW64PROCESS fnIsWow64Process;

namespace PokeReg
{
	struct PokeRegHelper
	{
	public:
		static int PopulateVectorFromFile(ConfigHelper* config, const std::wstring& wsFileName, std::vector<CPokeRegKey>& regList, int& iTotalLines)
		{
			if(wsFileName.empty())
			{
				LOGEROR(config, _T("File name is empty; Bailing out."));
				return NO_INPUT_FILE;
			}
			std::wifstream ifInFile(wsFileName);
			if(ifInFile.fail())
			{
				LOGEROR(config, _T("File not found."));
				ifInFile.close();
				return INPUT_FILE_NOT_FOUND;
			}
			iTotalLines = 0;
			wchar_t szLine[BUFFER_SIZE];
			while(!ifInFile.eof())
			{
				ifInFile.getline(szLine, BUFFER_SIZE);
				iTotalLines++;
				LogVerbose(_T("Line:  %s"), szLine);
				int i = 0;
				wchar_t wszDelims[] = L"\\/*";
				CPokeRegKey* pokeregtemp = Tokenize(szLine, wszDelims);
				if(pokeregtemp)
					regList.push_back(*pokeregtemp);
			}
			ifInFile.close();
			return SUCCESS;
		}

		static inline CPokeRegKey* Tokenize(const std::wstring wsSource, const wchar_t* wszDelimiter = L" ")
		{
			if(!wsSource.empty())
			{
				wchar_t* wszSourceDup = const_cast<wchar_t*>(wsSource.c_str());
				wchar_t* wszPos = NULL, *wszToken = wcstok_s(wszSourceDup, wszDelimiter, &wszPos);
				std::wstring wsRoot = wszToken, wsStringToken = L"";
				int iLoopCount = 0;
				while((wszToken = wcstok_s(NULL, wszDelimiter, &wszPos)) != NULL)
				{
					if(iLoopCount++ > 0)
						wsStringToken.append(L"\\");
					if(wcslen(wszToken) > 0)
					{
						wsStringToken.append(wszToken);
					}
				}
				for(int i = 0; i < PokeReg::Last_Do_Not_Use; i++)
				{
					if(!_wcsicmp(wszRegRoots[i], wszSourceDup))
					{
						return new CPokeRegKey((RegRoot)i, wsStringToken);
					}
				}
			}
			return NULL;
		}

		static int IsWow64(bool& bIsWow64Machine)
		{
			BOOL bIsWow64 = FALSE;
			int iRetVal = SUCCESS;

			//IsWow64Process is not available on all supported versions of Windows.
			//Use GetModuleHandle to get a handle to the DLL that contains the function
			//and GetProcAddress to get a pointer to the function if available.

			fnIsWow64Process = (LPFN_ISWOW64PROCESS) GetProcAddress(GetModuleHandle(TEXT("kernel32")), "IsWow64Process");

			if(NULL != fnIsWow64Process)
			{
				if (!fnIsWow64Process(GetCurrentProcess(), &bIsWow64))
				{
					LOGERROR(_T("Unable to determine if running as Wow64 process; Error: %d"), GetLastError());
					iRetVal = WOW_CHECK_FAILED;
				}
			}
			bIsWow64Machine = (bIsWow64 != 0);
			return iRetVal;
		}
	};
}