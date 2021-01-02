@echo off

set _programFiles=%ProgramFiles(x86)%
if not defined _programFiles set _programFiles=%ProgramFiles%

"%_programFiles%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\msbuild" "..\src\LinqToRegex.sln" ^
 /t:Build ^
 /p:Configuration=Debug ^
 /v:normal ^
 /fl ^
 /m

if errorlevel 1 (
 pause
 exit
)

echo OK
pause
