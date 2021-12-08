# Smalls.Online Razor Components

Razor components to house commonly used web components in my Blazor projects. It is the Razor equivalent to my component library for ReactJS projects ([@Smalls1652/react-smallsonline-core](https://github.com/Smalls1652/react-smallsonline-core))

If you want to see the test app in action you can visit it here:

- [https://blazor-components-test.smalls.online/](https://blazor-components-test.smalls.online/)

## 🧰 What does this consist of?

This component library is utilizing [Bootstrap](https://github.com/twbs/bootstrap) and wrapping specific CSS classes into usable Razor components. The intention of making this component library is to make implementing the UI easier and to keep the UI consistent across various different projects. The goal is to keep it in line with what I'm doing in the [ReactJS version](https://github.com/Smalls1652/react-smallsonline-core) of this.

## 🏗️ Building

### Prerequisites

- [**.NET 6 SDK**](https://dotnet.microsoft.com/en-us/download)
- **PowerShell 7 (or higher)**
  - Install instructions:
    - [Windows](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows?view=powershell-7.2)
    - [macOS](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos?view=powershell-7.2)
    - [Linux](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-linux?view=powershell-7.2)
  - _PowerShell is needed for build scripts in the test project._
- [**NodeJS/NPM**](https://nodejs.org/)
  - _NPM is needed for installing/updating Bootstrap into the test project._

### Initializing project

To initialize both the component library and the test app, run the following in a PowerShell console (`pwsh`):

```powershell

# Either of these commands are valid:

# Using the parameter to directly specify
.\init.ps1 -Project "ComponentLibraryAndTestApp"

# Using the default parameter values:
.\init.ps1
```

To initialize only the component library, run:

```powershell
.\init.ps1 -Project "ComponentLibrary"
```

### Build

To build both the component library and the test app, run the following in a PowerShell console (`pwsh`):

```powershell

# Either of these commands are valid:

# Using the parameter to directly specify
.\build.ps1 -Project "ComponentLibraryAndTestApp"

# Using the default parameter values:
.\build.ps1
```

To build only the component library, run:

```powershell
.\build.ps1 -Project "ComponentLibrary"
```

In addition you can add the `-Config` parameter to select a config type (Either `Release` or `Debug`). By default it uses the `Release` config.

```powershell

# Build the component library using the 'Debug' config.
.\build.ps1 -Project "ComponentLibrary" -Config "Debug"

# Build the component library and the test app using the 'Release' config.
.\build.ps1 -Project "ComponentLibraryAndTestApp" -Config "Release"
```
