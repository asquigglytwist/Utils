#pragma once
#ifndef BOMCOMPARER_H
#define BOMCOMPARER_H

#include <vector>

enum class FileComparisonResult : int
{
    Match,
    DoesNotMatch,
    NoKnownProperties,
    FileNotFound = 404, // Had to do it; Couldn't resist
    PropertyNotFound,
    PropertyEmpty,
    UnexpectedProperty
};

typedef std::tuple<FileComparisonResult, tstring, tstring, tstring> ComparisonFailure;
typedef std::map<tstring, ComparisonFailure> ComparisonResultMap;
typedef std::vector<tstring> MatchedFilesVector;
typedef std::map<FileComparisonResult, int> StatusCountMap;

struct BOMComparisonResult
{
private:
    bool BOMVersionMatch;
    ComparisonResultMap MapUnmatchedFileResults;
    MatchedFilesVector VecMatchedFiles;
    StatusCountMap MapStatusCounter;
public:
    void SetBOMVersionMatch(bool matches);
    void AddFileResult(tstring& file, FileComparisonResult compareResult,
        tstring propName = _T(""), tstring expected = _T(""), tstring actual = _T(""));
};

class BOMComparer
{
    tstring m_tsBaseline, m_tsCurrent;
    BOMComparisonResult m_bcrComparisonResults;
public:
    BOMComparer(tstring& baseline, tstring& current);
    ~BOMComparer();
    BOMComparisonResult Compare();
};
#endif // !BOMCOMPARER_H
