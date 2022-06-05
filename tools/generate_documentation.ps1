$msbuildPath = ./vswhere.exe -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe
$roslynatorExe="../../roslynator/src/CommandLine/bin/Debug/net48/roslynator"

dotnet restore "../../Roslynator/src/CommandLine.sln" -c Debug /p:RoslynatorCommandLine=true -v m
& $msbuildPath "../../Roslynator/src/CommandLine.sln" /t:Build /p:Configuration=Debug,RoslynatorCommandLine=true /v:m /m

& $roslynatorExe generate-doc "../src/LinqToRegex.sln" `
 --properties "Configuration=Release" `
 --projects "LinqToRegex(netstandard2.0)" `
 --heading "LINQ to Regex Reference" `
 -o "../docs/api"

& $roslynatorExe list-symbols "../src/LinqToRegex.sln" `
 --properties "Configuration=Release" `
 --projects "LinqToRegex(netstandard2.0)" `
 --visibility public `
 --depth member `
 --ignored-parts containing-namespace assembly-attributes `
 --ignored-attributes System.Runtime.CompilerServices.InternalsVisibleToAttribute `
 --output "../docs/api.txt"

 Write-Host "DONE"
 Read-Host
