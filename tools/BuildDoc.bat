@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\iPowerShellSmbios\bin\Release\iPowerShellSmbios.dll ..\documentation

PAUSE