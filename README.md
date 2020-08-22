# Webgoat Tests

This project uses WebGoat application running inside docker container.

```
$ git clone https://github.com/adamvlasak/Testing.git
$ cd Testing/Testing
$ make hub
$ make test
```
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
> Note: it is useful to have [dotnet-format|https://github.com/dotnet/format] installed as a global .NET tool:

```
dotnet tool install -g dotnet-format
```

Then you can format code before commit with this make target:
```
make format
```
