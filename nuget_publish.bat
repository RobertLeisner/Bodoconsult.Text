set version=1.0.0

dotnet nuget push Nuget\Bodoconsult.Typography.%version%.nupkg --source https://api.nuget.org/v3/index.json
dotnet nuget push Nuget\Bodoconsult.Text.%version%.nupkg --source https://api.nuget.org/v3/index.json
dotnet nuget push Nuget\Bodoconsult.Pdf.%version%.nupkg --source https://api.nuget.org/v3/index.json
dotnet nuget push Nuget\Bodoconsult.Text.Pdf.%version%.nupkg --source https://api.nuget.org/v3/index.json
dotnet nuget push Nuget\Bodoconsult.Test.%version%.nupkg --source https://api.nuget.org/v3/index.json
dotnet nuget push Nuget\Bodoconsult.Latex.%version%.nupkg --source https://api.nuget.org/v3/index.json
pause