
dotnet clean "../src/LinqToRegex.sln"
dotnet restore --force "../src/LinqToRegex.sln"
dotnet build "..\src\LinqToRegex.sln" -c Release /p:TreatWarningsAsErrors=true,WarningsNotAsErrors=1591 -v n /fl /m

if(!$?) { Read-Host; Exit }

dotnet pack -c Release --no-build -v normal "../src/LinqToRegex/LinqToRegex.csproj"

Write-Host "DONE"
Read-Host
