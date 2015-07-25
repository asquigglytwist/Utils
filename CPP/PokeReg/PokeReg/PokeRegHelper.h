#include "stdafx.h"
#include <vector>

typedef BOOL (WINAPI *LPFN_ISWOW64PROCESS) (HANDLE, PBOOL);
LPFN_ISWOW64PROCESS fnIsWow64Process;

namespace PokeReg
{
	struct PokeRegHelper
	{
	public:
		static bool PopulateVectorFromFile(const std::wstring& wsFileName, std::vector<CPokeRegKey>& regList, int& iTotalLines)
		{
			if(wsFileName.empty())
			{
				LOGERROR(_T("File name is empty; Bailing out."));
				return false;
			}
			std::wifstream ifInFile(wsFileName);
			if(ifInFile.fail())
			{
				LOGERROR(_T("File not found."));
				ifInFile.close();
				return false;
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
			return true;
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
				//if(wsRoot.length() > 3)
				//{
				//	if(wsRoot.at(0) == L'*' && wsRoot.at(1) == L'*')
				//	{
				//		LogError(_T("Registry Key that starts with ** cannot be tested by this tool."));
				//	}
				//	else
				//	{
				//		LogError(_T("Unable to recognize the root of the Registry Path: %s."), wsSource.c_str());
				//	}
				//}
				//else
				//{
				//	LogError(_T("Detected root is too short"));//: %s."), (wsRoot.length() ? wsRoot : _T("")));
				//}
			}
			return NULL;
		}

		static BOOL IsWow64()
		{
			BOOL bIsWow64 = FALSE;

			//IsWow64Process is not available on all supported versions of Windows.
			//Use GetModuleHandle to get a handle to the DLL that contains the function
			//and GetProcAddress to get a pointer to the function if available.

			fnIsWow64Process = (LPFN_ISWOW64PROCESS) GetProcAddress(GetModuleHandle(TEXT("kernel32")), "IsWow64Process");

			if(NULL != fnIsWow64Process)
			{
				if (!fnIsWow64Process(GetCurrentProcess(),&bIsWow64))
				{
					//handle error
				}
			}
			return bIsWow64;
		}
	};
}