#pragma once
#ifndef VERSION_H
#define VERSION_H

#include "stdafx.h"
#include "NSFileUtils.h"

struct Version
{
    static constexpr _TCHAR *ExpectedFormat = _T("\"%u.%u.%u.%u\""), Separator = _T('.');
    unsigned int m_iMajor, m_iMinor, m_iRevision, m_iBuild;
    tstring m_tsExtraInformation;

    Version(tstring tsVersionString);// : Version(static_cast<LPCTSTR>(tsVersionString.c_str())){}
                                     //Version(LPCTSTR tszVersionString);
                                     //Version(tstring, tstring, tstring, tstring);
    tstring ToString()
    {
        tstringstream tssVerInfo(QuoteString, std::ios_base::app | std::ios_base::out);
        tssVerInfo << m_iMajor << Version::Separator << m_iMinor << Version::Separator << m_iRevision << Version::Separator << m_iBuild;
        if (!m_tsExtraInformation.empty())
        {
            tssVerInfo << Version::Separator << m_tsExtraInformation;
        }
        tssVerInfo << QuoteString;
        return tssVerInfo.str();
    }
};

#endif // !VERSION_H