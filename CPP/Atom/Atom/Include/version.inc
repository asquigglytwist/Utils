/////////////////////////////////////////////////////////////////////////////
//
// Version
//

#ifndef _MAC

#include "bldcmpnm.h"
#include "version.h"

VS_VERSION_INFO VERSIONINFO
 FILEVERSION PRODUCT_MAJOR_VERSION,PRODUCT_MINOR_VERSION,PRODUCT_REVISION,PRODUCT_BUILD_NUMBER
 PRODUCTVERSION PRODUCT_MAJOR_VERSION,PRODUCT_MINOR_VERSION,0,0
 FILEFLAGSMASK 0x3fL
#ifdef _DEBUG
 FILEFLAGS 0x1L
#else
 FILEFLAGS 0x0L
#endif
 FILEOS 0x4L
 FILETYPE 0x1L
 FILESUBTYPE 0x0L
BEGIN
    BLOCK "StringFileInfo"
    BEGIN
        BLOCK "040904e4"
        BEGIN
            VALUE "CompanyName", GLOBAL_COMPANY_NAME_STR
            VALUE "FileDescription", "Atom: A Bill Of Materials (BOM) Generation and Validation Utility"
            VALUE "FileVersion", PRODUCT_FILE_VER_STR_DOT
            VALUE "InternalName", MODULE_INTERNAL_NAME
            VALUE "LegalCopyright", GLOBAL_LEGAL_COPY_RIGHT_STR
			VALUE "MIMEType", "application/x-msdownload\0"
            VALUE "OriginalFilename", MODULE_ORIGINAL_FILENAME
            VALUE "ProductName", GLOBAL_RC_PRODUCT_NAME
            VALUE "ProductVersion", PRODUCT_VERSION_STR
        END
    END
    BLOCK "VarFileInfo"
    BEGIN
        VALUE "Translation", 0x409, 1252
    END
END

#endif

