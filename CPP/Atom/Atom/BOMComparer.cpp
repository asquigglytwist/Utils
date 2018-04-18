#include "stdafx.h"
#include "BOMComparer.h"
#include "Logs.h"
#include "INIManager.h"

template<typename T>
void DeleteInVector(std::vector<T>& vec, T& deleteThis)
{
    // [BIB]:  https://stackoverflow.com/a/3385249
    auto pos = std::find(vec.begin(), vec.end(), deleteThis);
    if (pos != vec.end())
    {
        vec.erase(pos);
    }
}

void DeleteByKeyInMap(PropertyMapType& propMap, const tstring propToDelete)
{
    // [BIB]:  https://stackoverflow.com/a/263958
    auto pm_it = propMap.begin();
    while (pm_it != propMap.end())
    {
        if (pm_it->first == propToDelete)
        {
            pm_it = propMap.erase(pm_it);
        }
        else
        {
            ++pm_it;
        }
    }
    // [BIB]:  https://stackoverflow.com/a/5464202
}

BOMComparer::BOMComparer(tstring& tsBaseline, tstring& tsCurrent)
    : m_tsBaseline(tsBaseline), m_tsCurrent(tsCurrent)
{
}

BOMComparer::~BOMComparer()
{
}

BOMComparisonResult BOMComparer::Compare()
{
    INIManager cfgBaseline(tstring(EmptyString), const_cast<LPTSTR>(m_tsBaseline.c_str())),
        cfgCurrent(tstring(EmptyString), const_cast<LPTSTR>(m_tsCurrent.c_str()));
    auto baseBOMVersion = cfgBaseline.GetBOMFormatVersion(), currentBOMVersion = cfgCurrent.GetBOMFormatVersion();
    // [BIB]:  https://stackoverflow.com/a/4010249
    if ((baseBOMVersion == currentBOMVersion) || (std::abs(currentBOMVersion - baseBOMVersion) < (1.0 / 10000000)))
    {
        m_bcrComparisonResults.SetBOMVersionMatch(true);
        auto baselineFiles = cfgBaseline.GetAllFileNames(), currentFiles = cfgCurrent.GetAllFileNames();
        //if (baselineFiles.size() == currentFiles.size())
        {
            LOGDEBUG(_T("Number of files Baseline [%d], Current [%d]."), baselineFiles.size(), currentFiles.size());
            for (auto& baseFileName : baselineFiles)
            {
                auto baseProps = cfgBaseline.GetFileInfo(baseFileName), currentProps = cfgCurrent.GetFileInfo(baseFileName);
                if (!baseProps.empty())
                {
                    if (!currentProps.empty())
                    {
                        for (auto const& baseProperty : baseProps)
                        {
                            if (currentProps.count(baseProperty.first) == 1)
                            {
                                auto currentProperty = currentProps.at(baseProperty.first);
                                if (currentProperty != baseProperty.second)
                                {
                                    LOGDEBUG(_T("Property [%s] differs; Baseline [%s] & Current; Value [%s]."),
                                        baseProperty.first.c_str(), baseProperty.second.c_str(), currentProperty.c_str());
                                    m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::DoesNotMatch,
                                        baseProperty.first, baseProperty.second, currentProperty);
                                    break;  // Break if not a match; No need to continue comparison for this file.
                                }
                                else if (baseProperty.second.empty())
                                {
                                    LOGDEBUG(_T("Property [%s] is empty in both Baseline & Current."), baseProperty.first.c_str());
                                    m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::PropertyEmpty);
                                    break;  // Break if empty; It is possible BOM is either Incomplete or Corrupted.
                                }
                                else
                                {
                                    LOGVERBOSE(_T("Property [%s] with Value [%s] is same in both Baseline & Current."), baseProperty.first.c_str(), currentProperty.c_str());
                                }
                                DeleteByKeyInMap(currentProps, baseProperty.first);
                            }
                            else
                            {
                                LOGDEBUG(_T("Property [%s] with expected value [%s] not found in Current."),
                                    baseProperty.first.c_str(), baseProperty.second.c_str());
                                m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::PropertyNotFound,
                                    baseProperty.first, baseProperty.second);
                                break;  // Break if not a match; No need to continue comparison for this file.
                            }
                        }
                        if (!currentProps.empty())
                        {
                            for (auto const& currentProperty : currentProps)
                            {
                                if (!currentProperty.first.empty())
                                {
                                    m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::UnexpectedProperty, currentProperty.first);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::Match);
                        }
                        //DeleteInVector(currentFiles, baseFileName);
                    }
                    else
                    {
                        m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::FileNotFound);
                    }
                    //DeleteInVector(baselineFiles, baseFileName);
                }
                else
                {
                    m_bcrComparisonResults.AddFileResult(baseFileName, FileComparisonResult::NoKnownProperties);
                }
            }
        }
        //else
        //{
        //    LOGERROR(_T("Number of files don't match.  Baseline [%d] Current [%d]."), baselineFiles.size(), currentFiles.size());
        //}
    }
    else
    {
        LOGCRITICAL(_T("The BOM versions don't match.  Baseline [%g] Current [%g]."), baseBOMVersion, currentBOMVersion);
        m_bcrComparisonResults.SetBOMVersionMatch(false);
    }
    return m_bcrComparisonResults;
}

void BOMComparisonResult::SetBOMVersionMatch(bool matches)
{
    BOMVersionMatch = matches;
}

void BOMComparisonResult::AddFileResult(tstring& file, FileComparisonResult compareResult, tstring propName, tstring expected, tstring actual)
{
    MapStatusCounter[compareResult]++;
    if (compareResult == FileComparisonResult::Match)
    {
        VecMatchedFiles.push_back(file);
    }
    else
    {
        MapUnmatchedFileResults[file] = { compareResult, propName, expected, actual };
    }
}
