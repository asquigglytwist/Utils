#pragma once

#include "stdafx.h"

namespace PokeReg
{
	enum RegRoot {
		HKCU = 0,
		HKCR,
		HKLM,
		HKCUS,
		HKLMS,
		HKCCS,
		Last_Do_Not_Use
	};

	static wchar_t* wszRegRoots[] = {
		L"HKCU",
		L"HKCR",
		L"HKLM",
		L"HKCUS",
		L"HKLMS",
		L"HKCCS"
	};

	class CPokeRegKey
	{
	private:
		RegRoot m_rrRoot;
		std::wstring m_wsPath, m_wsStringRepresentation;

		bool Test(HKEY hParent, std::wstring& wsPath, bool& bIsKeyPresent);

	public:
		CPokeRegKey(std::wstring& line)
		{
		}

		CPokeRegKey(RegRoot root, std::wstring& path):m_rrRoot(root), m_wsPath(path)
		{
			m_wsStringRepresentation.clear();
		}

		~CPokeRegKey(void)
		{
			m_wsPath.clear();
			m_wsStringRepresentation.clear();
		}

		std::wstring ToString()
		{
			if(m_wsStringRepresentation.empty())
			{
				m_wsStringRepresentation = wszRegRoots[m_rrRoot];
				m_wsStringRepresentation.append(L"\\");
				m_wsStringRepresentation.append(m_wsPath);
			}
			return m_wsStringRepresentation;
		}

		bool TestProtection(bool bTestWowNode, bool& bIsKeyPresent);
	};
}