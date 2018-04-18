#pragma once
#ifndef ERROR_CODE_H
#define ERROR_CODE_H

enum class ErrorCode : int
{
    LocalAllocFailure = -3,
    File_UnableToGetSize = -2,
    AtomFailed = -1,
    Success = 0,
    RegKeyNotValid,
    RegValueNotValid,
    RegKeyNotAccessible,
    RegValueNotReadable,
    BOMGenFailed,
    BOMCompareFailed,
    CMDExecuteFailed,
    Trust_NoSignature,
    Trust_Subject_Form_Unknown,
    Trust_Provider_Unknown,
    Trust_Explicit_Distrust,
    Trust_Subject_Not_Trusted,
    Crypt_Security_Settings,
    WinVerifyTrust_UnknownError,
    ProcessCreationFailed,
    ProcessReturnedNonZero,
    ProcessUnableToGetExitCode,
    ProcessWaitForExitFailed,
    SigCheckNotFound,
    AcceptEULAFailed,
    SigCheckOutputParseFailure
};

#endif // !ERROR_CODE_H
