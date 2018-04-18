#pragma once
#ifndef ATOM_H
#define ATOM_H

#include "stdafx.h"
#include "INIManager.h"

#define DESC_OF_TOOL _T("All Tacit bill Of Materials")

#define CONSOLE_HEADER_TITLE (BLOCK_SEPARATOR NEW_LINE _T("\t---\t") NAME_OF_TOOL _T("\t---") NEW_LINE BLOCK_SEPARATOR)
#define CONSOLE_HEADER_DESCRIPTION (BLOCK_SEPARATOR NEW_LINE _T("-\t") DESC_OF_TOOL _T("\t-") NEW_LINE BLOCK_SEPARATOR)
#define CONSOLE_USE_CORRECT_BITNESS (NEW_LINE _T("Windows does not allow 32-Bit \"") NAME_OF_TOOL _T("\" to access System32 directory even in \"Read\" mode.  Hence use 32-Bit & 64-Bit Binaries on respective version of Windows.") NEW_LINE)
#define CONSOLE_DISCLAIMER (CONSOLE_USE_CORRECT_BITNESS)

#define CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("/")
#define CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("-")
#define CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("--")

namespace NSAtom
{
    enum class UsageMode : short
    {
        Unknown,
        ExampleConfig,
        Version,
        GenerateBaselineBOM,
        CompareBOM
    };

    struct/* prefs_t*/
    {
        tstring m_tsRegKeyPath, m_tsRegValueName, m_tsExpectedProductName;
        bool bIgnoreOtherProductNames, bScanRecursively, bNonInteractiveMode;
        tstring m_tsBaselineBOMPath;

        // Below are calculated values
        tstring m_tsProdInstallDir, m_tsLocalMachineBOMPath;
        UsageMode usageModeForAtom;
    } Preferences;

    constexpr auto
        Prop_RegKeyPath = Key_ProductRegKey,
        Prop_RegValueName = Key_ProductRegValue,
        Prop_ExpectedProductName = Key_ProductName,
        Prop_EnableRecursiveScan = Key_ScanRecursively,
        Prop_ExpectedProductVersion = Key_ProductVersion,
        CmdParam_SlashQ = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("?"),
        CmdParam_SlashH = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("H"),
        CmdParam_SlashHelp = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("Help"),
        CmdParam_HH = CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("H"),
        CmdParam_HHelp = CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("Help"),
        CmdParam_HHH = CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("H"),
        CmdParam_HHHelp = CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("Help"),
        CmdParam_SlashF1 = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("F1"),
        CmdParam_HF1 = CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("F1"),
        CmdParam_HHF1 = CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("F1"),
        CmdParam_NonInteractiveMode = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("NonInteractiveMode"),
        CmdParam_UsageMode = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("UsageMode"),
        CmdParam_SlashV = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("V"),
        CmdParam_SlashVersion = CONSOLE_CMD_PREFIX_SYMBOL_SLASH _T("Version"),
        CmdParam_HV = CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("V"),
        CmdParam_HVersion = CONSOLE_CMD_PREFIX_SYMBOL_HYPHEN _T("Version"),
        CmdParam_HHV = CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("V"),
        CmdParam_HHVersion = CONSOLE_CMD_PREFIX_SYMBOL_DOUBLE_HYPHEN _T("Version"),
        CmdArg_GenerateBaselineBOM = _T("GenerateBaselineBOM"),
        CmdArg_ExampleConfig = _T("ExampleConfig"),
        CmdArg_Compare = _T("CompareBOM")
        ;

    void PrintHeader();
    bool ParseCMD(int argc, _TCHAR* argv[], bool& bHelpMode);
    ErrorCode CalcProdInstallDir();
    ErrorCode ExecuteCMD();
    void PauseForInteraction();
    void PrintFooter();
    void PrintUsageInfo(bool bPauseForInteraction = true);

    tstring GetProductInstallDir() { return Preferences.m_tsProdInstallDir; }
    tstring GetProductName() { return Preferences.m_tsExpectedProductName; }
}
#endif // !ATOM_H
