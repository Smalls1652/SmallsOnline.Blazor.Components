[CmdletBinding()]
param()

$scriptRoot = $PSScriptRoot

$writeInfoSplat = @{
    "InformationAction" = "Continue";
}

$bootstrapCssPath = Join-Path -Path $scriptRoot -ChildPath "node_modules\bootstrap\dist\css\bootstrap.min.css"
$bootstrapCssMapPath = Join-Path -Path $scriptRoot -ChildPath "node_modules\bootstrap\dist\css\bootstrap.min.css.map"
$bootstrapOutPath = Join-Path -Path $scriptRoot -ChildPath "wwwroot\css\bootstrap\"

if (!(Test-Path -Path $bootstrapOutPath)) {
    $null = New-Item -Path $bootstrapOutPath -ItemType "Directory"
}

foreach ($fileItem in (Get-ChildItem -Path $bootstrapOutPath)) {
    Write-Information @writeInfoSplat -MessageData "`t| Removing '$($fileItem.Name)'"
    Remove-Item -Path $fileItem.FullName -Force
}

Write-Information @writeInfoSplat -MessageData "`t| bootstrap.min.css-> $($bootstrapOutPath)"
Copy-Item -Path $bootstrapCssPath -Destination $bootstrapOutPath -ErrorAction "Stop"

Write-Information @writeInfoSplat -MessageData "`t| bootstrap.min.css.map-> $($bootstrapOutPath)"
Copy-Item -Path $bootstrapCssMapPath -Destination $bootstrapOutPath -ErrorAction "Stop"