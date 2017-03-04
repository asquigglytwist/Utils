#(Get-Content .\AppMetaDataTemplate.cs).Replace('[PS_Stub_Date]', (Get-Date).ToString("yyyyMMdd")) | Set-Content .\AppMetaData.cs
#timeout /t 10
#(Get-Content .\AppMetaData.cs).Replace('[PS_Stub_Time]', (Get-Date).ToString("hhmmssfff")) | Set-Content .\AppMetaData.cs
#pause

$content = [System.IO.File]::ReadAllText(".\AppMetaDataTemplate.cs").Replace("[PS_Stub_Date]", ((Get-Date).ToString("yyyyMMdd"))).Replace("[PS_Stub_Time]", ((Get-Date).ToString("hhmmssfff")))
[System.IO.File]::WriteAllText(".\AppMetaData.cs", $content)
pause