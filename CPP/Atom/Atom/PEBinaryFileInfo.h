#pragma once
#ifndef PEBINARYFILEINFO_H
#define PEBINARYFILEINFO_H

#include "IFileInfo.h"
#include "SigCheckHandler.h"

#pragma comment(lib, "crypt32.lib")
#pragma comment (lib, "wintrust")

constexpr auto CERT_ENCODING = (X509_ASN_ENCODING | PKCS_7_ASN_ENCODING);

class PEBinaryFileInfo : public IFileInfo
{
public:
    PEBinaryFileInfo() = delete;
    ~PEBinaryFileInfo()
    {
        if (m_sigCheckResults != nullptr)
        {
            delete m_sigCheckResults;
            m_sigCheckResults = nullptr;
        }
    }

    PEBinaryFileInfo(tstring fileName) : IFileInfo(fileName)
    {}

    // Inherited via IFileInfo
    virtual PropertyMapType ToMap() override;
#if MAKE_IFILEINFO_PURE_VIRTUAL
    virtual bool CollectMetaData() override;
#else
    ErrorCode CollectMetaData();
#endif // MAKE_IFILEINFO_PURE_VIRTUAL
protected:
    static ErrorCode GetStatusOfEmbeddedSignature(const _TCHAR* tszFileName);
    bool m_bAuthentiCodeCheckStatus;
    SigCheckHandler::SigCheckResults *m_sigCheckResults;
};
#endif // !PEBINARYFILEINFO_H
