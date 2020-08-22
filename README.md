# WebGoat Tests

This project is focused on writing tests using C#, NUnit and .NET Core 3.1. It uses [WebGoat 7.1](https://github.com/WebGoat/WebGoat/releases/tag/7.1) as application under test running inside docker container.

## Prerequisites

### Windows 10 Version 2004 or later

**Turn on Windows Features**
- Windows Subsystem for Linux
- Virtual Machine Platform

**Install WSL2 Linux kernel update package**
- https://docs.microsoft.com/en-us/windows/wsl/wsl2-kernel

**Install Docker for desktop**
 - https://hub.docker.com/editions/community/docker-ce-desktop-windows/

Use **Visual Studio Test Explorer** to run tests or **make**:

```
make test
```
```
make test-parallel
```
> Note: it is useful to have [dotnet-format](https://github.com/dotnet/format) installed as a global .NET tool:

```
dotnet tool install -g dotnet-format
```

Then you can format code before commit with this make target:
```
make format
```

> To be able to customize formatting rules you can check [this page](https://docs.microsoft.com/en-us/visualstudio/ide/editorconfig-formatting-conventions?view=vs-2019) or see [.editorconfig](https://editorconfig.org/) within the project.
