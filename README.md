# WebGoat Tests

This project is focused on writing tests using C#, NUnit and .NET Core 3.1. It uses [WebGoat 7.1](https://github.com/WebGoat/WebGoat/releases/tag/7.1) as application under test running inside docker container.

## Prerequisites

### Windows 10 Version 2004 or later

**Turn on Windows Features**
- Windows Subsystem for Linux
- Virtual Machine Platform
```
dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart
dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
```
> Restart your PC.
```
wsl --set-default-version 2
```

**Install WSL2 Linux kernel update package**
- https://docs.microsoft.com/en-us/windows/wsl/wsl2-kernel

**Install Docker for desktop**
- https://hub.docker.com/editions/community/docker-ce-desktop-windows/

**Install dotnet-format as global .NET tool**
- [github.com/dotnet/format](https://github.com/dotnet/format)
```
dotnet tool install -g dotnet-format
```

**Install docfx**
- [github.com/dotnet/docfx](https://github.com/dotnet/docfx/releases)

## Running tests

In Visual Studio 2019 you can use Test Explorer. Or make:

```
make test
```
```
make test-parallel
```

## Enforcing code style

It is useful to enforce source files formatting (VS 2019 uses .editorconfig file in the root of the project). If you don't have VS 2019:

```
make format
```

> To be able to customize formatting rules you can check [this page](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-formatting-conventions?view=vs-2019) or see [.editorconfig homepage](https://editorconfig.org/) or see the file [within the project](https://github.com/adamvlasak/Testing/blob/master/.editorconfig).

## Generating Documentation

```
make doc
```

or

```
make doc-watch
```
