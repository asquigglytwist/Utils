#(Get-Content .\AppMetaDataTemplate.cs).Replace('[PS_Stub_Date]', (Get-Date).ToString("yyyyMMdd")) | Set-Content .\AppMetaData.cs
#timeout /t 10
#(Get-Content .\AppMetaData.cs).Replace('[PS_Stub_Time]', (Get-Date).ToString("hhmmssfff")) | Set-Content .\AppMetaData.cs
#pause

$content = [System.IO.File]::ReadAllText(".\AppMetaData.cs.Template").Replace("[PS_Stub_Date]", ((Get-Date).ToString("yyMMdd"))).Replace("[PS_Stub_Time]", ((Get-Date).ToString("hhmmss"))).Replace("[PS_Stub_CopyRightYear]", ((Get-Date).ToString("yyyy")))
[System.IO.File]::WriteAllText(".\AppMetaData.cs", $content)
pause