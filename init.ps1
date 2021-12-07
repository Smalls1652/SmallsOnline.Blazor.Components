[CmdletBinding(SupportsShouldProcess)]
param(
    [Parameter(Position = 0)]
    [ValidateSet(
        "ComponentLibrary",
        "ComponentLibraryAndTestApp"
    )]
    [string]$Project = "ComponentLibraryAndTestApp"
)

$scriptRoot = $PSScriptRoot

$slnPath = $null
switch ($Project) {
    "ComponentLibraryAndTestApp" {
        $slnPath = Join-Path -Path $scriptRoot -ChildPath "SmallsOnline.Blazor.Components_with_Test.sln"
        break
    }

    Default {
        $slnPath = Join-Path -Path $scriptRoot -ChildPath "SmallsOnline.Blazor.Components.sln"
        break
    }
}

$buildTarget = "InitProject_Combined"
if ($PSCmdlet.ShouldProcess("Run command", "dotnet msbuild -target:`"$($buildTarget)`" -noLogo -verbosity:`"minimal`" `"$($slnPath)`"")) {
    dotnet msbuild -target:"$($buildTarget)" -noLogo -verbosity:"minimal" "$($slnPath)"
}