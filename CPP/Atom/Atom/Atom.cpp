// Atom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Logs.h"
#include "Atom.h"
#include "BOMCreator.h"
#include "BOMComparer.h"
#include "Include\Version.h"

namespace NSAtom
{
    bool ParseCMD(int argc, _TCHAR* argv[], bool& bHelpMode)
    {
        Preferences.m_tsRegKeyPath = Preferences.m_tsRegValueName = EmptyString;
        Preferences.bIgnoreOtherProductNames = Preferences.bNonInteractiveMode = false;
        Preferences.bScanRecursively = true;

        for (int i = 1; i < argc; i++)
        {
            LOGVERBOSE(_T("CommandLine Arg at [%d] is [%s]."), i, argv[i]);
            if (_tcsicmp(argv[i], CmdParam_NonInteractiveMode) == 0)
            {
                Preferences.bNonInteractiveMode = true;
            }
            else if (_tcsicmp(argv[i], CmdParam_UsageMode) == 0)
            {
                i++;
                if (i < argc)
                {
                    if (_tcsicmp(argv[i], CmdArg_GenerateBaselineBOM) == 0)
                    {
                        Preferences.usageModeForAtom = UsageMode::GenerateBaselineBOM;
                    }
                    else if (_tcsicmp(argv[i], CmdArg_ExampleConfig) == 0)
                    {
                        Preferences.usageModeForAtom = UsageMode::ExampleConfig;
                    }
                    else if (_tcsicmp(argv[i], CmdArg_Compare) == 0)
                    {
                        i++;
                        if (i < argc)
                        {
                            Preferences.m_tsBaselineBOMPath = argv[i];
                        }
                        else
                        {
                            LOGCRITICAL(_T("Please check the CMD Args; Current # is Insufficient.  For %s mode, please include path to Baseline BOM file."), CmdArg_Compare);
                            return false;
                        }
                        Preferences.usageModeForAtom = UsageMode::CompareBOM;
                    }
                    else
                    {
                        LOGCRITICAL(_T("Usage mode %s is unknown.  Please check the params.  Valid options are %s or %s.  Please re-run with appropriate arguments."), argv[i], CmdArg_GenerateBaselineBOM, CmdArg_Compare);
                        return false;
                    }
                }
                else
                {
                    LOGCRITICAL(_T("Expected argument for %s missing; Valid options are %s or %s.  Please re-run with appropriate arguments."), CmdParam_UsageMode, CmdArg_GenerateBaselineBOM, CmdArg_Compare);
                    return false;
                }
            }
            else if ((_tcsicmp(argv[i], CmdParam_SlashQ) == 0) || (_tcsicmp(argv[i], CmdParam_SlashH) == 0) || (_tcsicmp(argv[i], CmdParam_SlashHelp) == 0) || (_tcsicmp(argv[i], CmdParam_HH) == 0)
                || (_tcsicmp(argv[i], CmdParam_HHelp) == 0) || (_tcsicmp(argv[i], CmdParam_HHH) == 0) || (_tcsicmp(argv[i], CmdParam_HHHelp) == 0) || (_tcsicmp(argv[i], CmdParam_SlashF1) == 0)
                || (_tcsicmp(argv[i], CmdParam_HF1) == 0) || (_tcsicmp(argv[i], CmdParam_HHF1) == 0))
            {
                bHelpMode = true;
                return true;
            }
            else if ((_tcsicmp(argv[i], CmdParam_SlashV) == 0) || (_tcsicmp(argv[i], CmdParam_SlashVersion) == 0) || (_tcsicmp(argv[i], CmdParam_HV) == 0)
                || (_tcsicmp(argv[i], CmdParam_HVersion) == 0) || (_tcsicmp(argv[i], CmdParam_HHV) == 0) || (_tcsicmp(argv[i], CmdParam_HHVersion) == 0))
            {
                Preferences.usageModeForAtom = UsageMode::Version;
                return true;
            }
            else
            {
                LOGCRITICAL(_T("Unable to parse option %s.  %s is now exiting."), argv[i], NAME_OF_TOOL);
                return false;
            }
        }
        return true;
    }

    ErrorCode CalcProdInstallDir()
    {
        tstring tsHKCR(_T("HKEY_CLASSES_ROOT")), tsHKCU(_T("HKEY_CURRENT_USER")), tsHKLM(_T("HKEY_LOCAL_MACHINE")), tsHKU(_T("HKEY_USERS")), tsHKCC(_T("HKEY_CURRENT_CONFIG"));

        HKEY hKeyParent;
        if (Preferences.m_tsRegKeyPath.find(tsHKCR) != tstring::npos)
        {
            hKeyParent = HKEY_CLASSES_ROOT;
            Preferences.m_tsRegKeyPath = Preferences.m_tsRegKeyPath.substr(tsHKCR.length() + 1);
        }
        else if (Preferences.m_tsRegKeyPath.find(tsHKCU) != tstring::npos)
        {
            hKeyParent = HKEY_CURRENT_USER;
            Preferences.m_tsRegKeyPath = Preferences.m_tsRegKeyPath.substr(tsHKCU.length() + 1);
        }
        else if (Preferences.m_tsRegKeyPath.find(tsHKLM) != tstring::npos)
        {
            hKeyParent = HKEY_LOCAL_MACHINE;
            Preferences.m_tsRegKeyPath = Preferences.m_tsRegKeyPath.substr(tsHKLM.length() + 1);
        }
        else if (Preferences.m_tsRegKeyPath.find(tsHKU) != tstring::npos)
        {
            hKeyParent = HKEY_USERS;
            Preferences.m_tsRegKeyPath = Preferences.m_tsRegKeyPath.substr(tsHKU.length() + 1);
        }
        else if (Preferences.m_tsRegKeyPath.find(tsHKCC) != tstring::npos)
        {
            hKeyParent = HKEY_CURRENT_CONFIG;
            Preferences.m_tsRegKeyPath = Preferences.m_tsRegKeyPath.substr(tsHKCC.length() + 1);
        }
        else
        {
            LOGCRITICAL(_T("Unable to parse provided registry key Path %s."), Preferences.m_tsRegKeyPath.c_str());
            return ErrorCode::RegKeyNotValid;
        }

        CRegKey regKey;
        if (regKey.Open(hKeyParent, Preferences.m_tsRegKeyPath.c_str(), KEY_READ) != ERROR_SUCCESS)
        {
            LOGCRITICAL(_T("Unable to open specified registry key path %s."), Preferences.m_tsExpectedProductName.c_str());
            return ErrorCode::RegKeyNotAccessible;
        }

        _TCHAR tszExpandablePathInReg[MAX_PATH], tszInstallPath[MAX_PATH];
        ULONG ulInstallPathLength = _countof(tszExpandablePathInReg);
        if (regKey.QueryStringValue(Preferences.m_tsRegValueName.c_str(), tszExpandablePathInReg, &ulInstallPathLength) != ERROR_SUCCESS)
        {
            LOGCRITICAL(_T("Unable to query install path from value %s under %s."), Preferences.m_tsRegValueName.c_str(), Preferences.m_tsRegKeyPath.c_str());
            return ErrorCode::RegValueNotReadable;
        }
        if (::ExpandEnvironmentStrings(tszExpandablePathInReg, tszInstallPath, MAX_PATH) > 0)
        {
            Preferences.m_tsProdInstallDir = tszInstallPath;
            return ErrorCode::Success;
        }
        return ErrorCode::RegValueNotValid;
    }

    ErrorCode GenerateBOMOnCurrentMachine()
    {
        INIManager appConfig(tstring(EmptyString), NSFileUtils::GetAppConfigPath());
        auto tsTemp = appConfig.GetProductRegKey();
        if (!tsTemp.empty())
        {
            Preferences.m_tsRegKeyPath = tsTemp;
        }
        tsTemp = appConfig.GetProductRegValueName();
        if (!tsTemp.empty())
        {
            Preferences.m_tsRegValueName = tsTemp;
        }

        auto prodInstallDirCalcStatus = CalcProdInstallDir();
        if (prodInstallDirCalcStatus != ErrorCode::Success)
        {
            return prodInstallDirCalcStatus;
        }

        tsTemp = appConfig.GetProductName();
        if (!tsTemp.empty())
        {
            Preferences.m_tsExpectedProductName = tsTemp;
        }
        Preferences.bScanRecursively = appConfig.IsRecursiveScanEnabled();
        Preferences.m_tsLocalMachineBOMPath = BOMCreator::GenerateUniqueFileName(NSAtom::GetProductName());
        BOMCreator bomCreator(Preferences.m_tsLocalMachineBOMPath, NSAtom::GetProductInstallDir().c_str());
        auto ecBOMGenStatus = ErrorCode::Success;
        if (bomCreator.GenerateBOM(ecBOMGenStatus, false, Preferences.bScanRecursively))
        {
            LOGSUCCESS(_T("BOM Generation Success."));
            return ErrorCode::Success;
        }
        else
        {
            LOGERROR(_T("BOM Generation Failed."));
            return ErrorCode::BOMGenFailed;
        }
    }

    ErrorCode CompareBOMFiles()
    {
        auto ecBOMGenStatus = GenerateBOMOnCurrentMachine();
        if (ecBOMGenStatus == ErrorCode::Success)
        {
            BOMComparer bomComparer(Preferences.m_tsBaselineBOMPath, Preferences.m_tsLocalMachineBOMPath);
            bomComparer.Compare();
        }
        return ecBOMGenStatus;
    }

    ErrorCode ExecuteCMD()
    {
        if (Preferences.usageModeForAtom == UsageMode::GenerateBaselineBOM)
        {
            return GenerateBOMOnCurrentMachine();
        }
        else if (Preferences.usageModeForAtom == UsageMode::ExampleConfig)
        {
            INIManager cfgExampleConfig(tstring(EmptyString), NSFileUtils::GetExampleConfigPath());
            if (cfgExampleConfig.WriteExampleConfig())
            {
                return ErrorCode::Success;
            }
        }
        else if (Preferences.usageModeForAtom == UsageMode::Version)
        {
            tcout << NEW_LINE PRODUCT_FILE_VER_STR_DOT NEW_LINE;
            return ErrorCode::Success;
        }
        else if (Preferences.usageModeForAtom == UsageMode::CompareBOM)
        {
            return CompareBOMFiles();
        }
        LOGERROR(_T("Unable to execute CMD."));
        return ErrorCode::CMDExecuteFailed;
    }

    void PrintHeader()
    {
        if (Preferences.bNonInteractiveMode)
        {
            return;
        }
        tcout << DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE DOUBLE_TAB_INDENT _T(" ") NAME_OF_TOOL _T(" :: ") DESC_OF_TOOL NEW_LINE DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE;
        tcout << CONSOLE_DISCLAIMER << std::endl;
    }

    void PauseForInteraction()
    {
        if (Preferences.bNonInteractiveMode)
        {
            return;
        }
        tcout << NEW_LINE _T("Press any key to continue...") << std::endl;
        getchar();
    }

    void PrintFooter()
    {
        if (Preferences.bNonInteractiveMode)
        {
            return;
        }
        tcout << NEW_LINE DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE DOUBLE_TAB_INDENT NAME_OF_TOOL _T(" ::  For any doubts, please contact SAE / VSES team.") NEW_LINE DOUBLE_TAB_INDENT BLOCK_SEPARATOR NEW_LINE;
    }

    void PrintUsageInfo(bool bPauseForInteraction)
    {
        tcout << NEW_LINE _T("Usage:") NEW_LINE _T("\t") << USAGE_OF_TOOL _T("[") << CmdParam_NonInteractiveMode << _T("] ") << CmdParam_UsageMode << _T(" (") << CmdArg_GenerateBaselineBOM << _T(" or ") << CmdArg_Compare << _T(" or ") << CmdArg_ExampleConfig << _T(")") << NEW_LINE;
        tcout << NEW_LINE _T("Description:") NEW_LINE _T("\t") _T("This utility is a BOM Generator & Validator.") NEW_LINE;
        tcout << NEW_LINE _T("Examples:") NEW_LINE _T("To get help info:") NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_SlashQ << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_SlashH << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_SlashHelp << NEW_LINE;
        tcout << NEW_LINE _T("To find ") NAME_OF_TOOL _T("'s version") NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << _T(" ") << CmdParam_SlashV << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << _T(" ") << CmdParam_SlashVersion << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << _T(" ") << CmdParam_HHVersion << NEW_LINE;
        tcout << NEW_LINE _T("To make use of ") NAME_OF_TOOL _T(":") NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_NonInteractiveMode << _T(" ") << CmdParam_UsageMode << _T(" ") << CmdArg_ExampleConfig << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_UsageMode << _T(" ") << CmdArg_GenerateBaselineBOM << NEW_LINE;
        tcout << _T("\t") USAGE_OF_TOOL << CmdParam_NonInteractiveMode << _T(" ") << CmdParam_UsageMode << _T(" ") << CmdArg_Compare << _T(" (This feature has not been implemented yet).") NEW_LINE;

        PrintFooter();
        if (bPauseForInteraction)
        {
            PauseForInteraction();
        }
    }
}

int _tmain(int argc, _TCHAR* argv[])
{
#ifdef DEBUG
    _TCHAR* argvDebug[] = { _T(""), _T("/UsageMode"), _T("CompareBOM"), _T("MSWIN_BaseLine.bom") };
    argv = argvDebug;
    argc = sizeof(argvDebug) / sizeof(*argvDebug);
#endif // DEBUG
    using namespace NSAtom;
    bool bHelpMode = false;
    if (ParseCMD(argc, argv, bHelpMode))
    {
        PrintHeader();
        if (ExecuteCMD() == ErrorCode::Success)
        {
            PrintFooter();
            PauseForInteraction();
            return static_cast<int>(ErrorCode::Success);
        }
    }
    PrintUsageInfo(!bHelpMode);
    return static_cast<int>(ErrorCode::AtomFailed);
}

