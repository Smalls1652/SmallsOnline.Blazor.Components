[CmdletBinding(SupportsShouldProcess)]
param(
    [Parameter(Position = 0)]
    [ValidateSet(
        "ComponentLibrary",
        "ComponentLibraryAndTestApp"
    )]
    [string]$Project = "ComponentLibraryAndTestApp",
    [Parameter(Position = 1)]
    [ValidateSet(
        "Debug",
        "Release"
    )]
    [string]$Config = "Release"
)

$scriptRoot = $PSScriptRoot

$slnPath = $null
$projectPath = $null
switch ($Project) {
    "ComponentLibraryAndTestApp" {
        $slnPath = Join-Path -Path $scriptRoot -ChildPath "SmallsOnline.Blazor.Components_with_Test.sln"
        $projectPath = Join-Path -Path $scriptRoot -ChildPath "src\SmallsOnline.Blazor.Components.Test\"
        break
    }

    Default {
        $slnPath = Join-Path -Path $scriptRoot -ChildPath "SmallsOnline.Blazor.Components.sln"
        $projectPath = Join-Path -Path $scriptRoot -ChildPath "src\SmallsOnline.Blazor.Components\"
        break
    }
}

$buildTarget = "BuildProject_Combined"
if ($PSCmdlet.ShouldProcess("Run command", "dotnet msbuild -target:`"$($buildTarget)`" -property:`"Configuration=$($Config)`" -noLogo -verbosity:`"minimal`" `"$($slnPath)`"")) {
    dotnet msbuild -target:"$($buildTarget)" -property:"Configuration=$($Config)" -noLogo -verbosity:"minimal" "$($slnPath)"
}

if ($PSCmdlet.ShouldProcess("Run command", "dotnet publish `"$($projectPath)`" --configuration $($Config)")) {
    dotnet publish "$($projectPath)" --configuration $($Config)
}