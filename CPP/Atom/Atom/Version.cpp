#include "stdafx.h"
#include "Version.h"

Version::Version(tstring tsVersionString)
{
    m_iMajor = m_iMinor = m_iRevision = m_iBuild = 0;
    tsVersionString = NSFileUtils::CreateVersionOnlyString(tsVersionString);// .substr(1, tsVersionString.length() - 1);
    tstringstream tssVersion(tsVersionString);
    tstring tsToken;
    auto iCount = 0;
    while (iCount++ < 4)
    {
        if (std::getline(tssVersion, tsToken, Version::Separator))
        {
            switch (iCount)
            {
            case 1:
                m_iMajor = std::stoi(tsToken);
                break;
            case 2:
                m_iMinor = std::stoi(tsToken);
                break;
            case 3:
                m_iRevision = std::stoi(tsToken);
                break;
            case 4:
                m_iBuild = std::stoi(tsToken);
                break;
            default:
                break;
            }
        }
    }
    if (std::getline(tssVersion, tsToken))
    {
        m_tsExtraInformation = tsToken;
    }
}
