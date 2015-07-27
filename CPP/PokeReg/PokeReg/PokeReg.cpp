// PokeReg.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include "PokeReg.h"

namespace PokeReg
{
	bool CPokeRegKey::Test(ConfigHelper* config, HKEY hParent, std::wstring& wsPath, bool& bIsKeyPresent)
	{
		HKEY hActualKey = NULL;
		LONG lResult = RegOpenKeyEx(hParent, wsPath.c_str(), 0, KEY_READ, &hActualKey);
		ATL::CRegKey regKey;
		if(ERROR_SUCCESS == lResult)//regKey.Open(hParent, wsPath.c_str()))
		{
			bIsKeyPresent = true;
			regKey.Attach(hActualKey);
			LOGDBUG(config, _T("Creating string value for Key: \"%s\""), this->ToString());
			if(ERROR_SUCCESS == regKey.SetStringValue(TEST_NAME, TEST_VALUE))
			{
				LOGDBUG(config, _T("Succeeded when expected to Fail.."));
				LogVerbose(_T("Cleaning up the residues."));
				regKey.DeleteValue(_T("Test"));
				return false;
			}
			else
			{
				LOGDBUG(config, _T("Failed as expected."));
				return true;
			}
		}
		else if (ERROR_FILE_NOT_FOUND == lResult)
		{
			bIsKeyPresent = false;
			LOGDBUG(config, _T("Key : %s not found."), this->ToString());
		}
		else
		{
			bIsKeyPresent = true;
			LOGDBUG(config, _T("Unable to open key : %s."), this->ToString());
		}
		return false;
	}

	bool CPokeRegKey::TestProtection(ConfigHelper* config, bool bTestWowNode, bool& bIsKeyPresent)
	{
		bool bRetValue = false;
		switch(m_rrRoot)
		{
		case HKCU:
			{
				bRetValue = Test(config, HKEY_CURRENT_USER, m_wsPath, bIsKeyPresent);
			}
			break;
		case HKCR:
			{
				bRetValue = Test(config, HKEY_CLASSES_ROOT, m_wsPath, bIsKeyPresent);
			}
			break;
		case HKLM:
			{
				bRetValue = Test(config, HKEY_LOCAL_MACHINE, m_wsPath, bIsKeyPresent);
			}
			break;
		case HKCUS:
			{
				bool bKeyCheck = false;
				std::wstring wsNormal = _T("Software\\");
				wsNormal.append(m_wsPath);
				bRetValue = Test(config, HKEY_CURRENT_USER, wsNormal, bKeyCheck);
				if(bTestWowNode)
				{
					std::wstring wsWowNode = _T("Software\\Wow6432Node\\");
					wsWowNode.append(m_wsPath);
					bIsKeyPresent = bKeyCheck;
					bRetValue = bRetValue && Test(config, HKEY_CURRENT_USER, wsWowNode, bKeyCheck);
				}
				bIsKeyPresent = (bIsKeyPresent || bKeyCheck);
			}
			break;
		case HKLMS:
			{
				bool bKeyCheck = false;
				std::wstring wsNormal = _T("Software\\");
				wsNormal.append(m_wsPath);
				bRetValue = Test(config, HKEY_LOCAL_MACHINE, wsNormal, bKeyCheck);
				if(bTestWowNode)
				{
					std::wstring wsWowNode = _T("Software\\Wow6432Node\\");
					wsWowNode.append(m_wsPath);
					bIsKeyPresent = bKeyCheck;
					bRetValue = bRetValue && Test(config, HKEY_LOCAL_MACHINE, wsWowNode, bKeyCheck);
				}
				bIsKeyPresent = (bIsKeyPresent || bKeyCheck);
			}
			break;
		case HKCCS:
			{
				bool bKeyCheck1 = false, bKeyCheck2 = false, bKeyCheck3 = false, bKeyCheck4 = false;
				std::wstring wsHKLM_CCS = CURRENT_CONTROL_SET, wsHKLM_CS1 = CONTROL_SET_00,
					wsHKLM_CS2 = CONTROL_SET_00, wsHKCC_CCS = CURRENT_CONTROL_SET;
				wsHKLM_CCS.append(m_wsPath);
				wsHKLM_CCS.append(m_wsPath);
				wsHKCC_CCS.append(m_wsPath);
				wsHKCC_CCS.append(m_wsPath);
				wsHKLM_CS1.append(_T("1\\"));
				wsHKLM_CS1.append(m_wsPath);
				wsHKLM_CS2.append(_T("2\\"));
				wsHKLM_CS2.append(m_wsPath);
				bRetValue = (Test(config, HKEY_LOCAL_MACHINE, wsHKLM_CCS, bKeyCheck1)
					&& Test(config, HKEY_CURRENT_CONFIG, wsHKCC_CCS, bKeyCheck2)
					&& Test(config, HKEY_LOCAL_MACHINE, wsHKLM_CS1, bKeyCheck3)
					&& Test(config, HKEY_LOCAL_MACHINE, wsHKLM_CS2, bKeyCheck4));
				bIsKeyPresent = bKeyCheck1 || bKeyCheck2 || bKeyCheck3 || bKeyCheck4;
			}
			break;
		default:
			LOGEROR(config, _T("Unknown Registry Root value supplied; Unable to Test."));
			break;
		}
		return bRetValue;
	}
}