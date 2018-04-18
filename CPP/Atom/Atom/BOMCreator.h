#pragma once
#ifndef BOMCREATOR_H
#define BOMCREATOR_H

#include "stdafx.h"
#include <vector>
#include "INIManager.h"
#include "NSFileUtils.h"

const static _TCHAR *BOMFileExtension = _T("bom");

class BOMCreator
{
    _TCHAR m_tszProductInstallDir[MAX_PATH];
    INIManager m_CfgBOM;
    void ListFilesInDirectory(_TCHAR* tszDirPath, std::vector<tstring>& vecFileNames, bool bScanRecursively/* = true*/);
public:
    BOMCreator(tstring& tsBOMFilePath, const _TCHAR* tszProductInstallDir);
    ~BOMCreator();

    bool GenerateBOM(ErrorCode& ecBOMGenStatus, bool bIgnoreSigCheck, bool bScanRecursively);
    static tstring GenerateUniqueFileName(tstring& tsProdName);
};

#endif // !BOMCREATOR_H
