### SimpleProject1

SimpleProject1 showcases the simplest project there is for running MSTest tests using the new runner.

The project is a normal MSTest test project, generated from `mstest` template. It updates MSTest dependencies to `3.2.0-preview.23570.1` or newer, and defines:

```xml

<UseMSTestRunner>true</UseMSTestRunner>
```

After build an executable `SimpleProject.exe` is created which can run tests directly:

```
PS> cd SimpleProject1
PS SimpleProject1> dotnet build
PS SimpleProject1> bin\Debug\net8.0\SimpleProject.exe

Microsoft(R) Testing Platform Execution Command Line Tool
Version: 1.0.0-alpha.23567.1+9e2a929563d3929a92b57e402dceaaa1744a4ae5
RuntimeInformation: win-x64 - .NET 8.0.0
Copyright(c) Microsoft Corporation.  All rights reserved.

Passed! - Failed: 0, Passed: 1, Skipped: 0, Total: 1, Duration: 116ms - SimpleProject.dll (win-x64 - .NET 8.0.0)
```

This revolutionizes how you can run and ship tests, you can:

### Publish as standalone and run anywhere

You can restore and publish your application as standalone, which will bundle the test application and appropriate runtime, and you can then run it anywhere, for example on Linux:

```
PS SimpleProject1> dotnet restore --runtime linux-x64
PS SimpleProject1> dotnet publish --runtime linux-x64 --self-contained


# On linux (for example Ubuntu in WSL2):
$ SimpleProject1>  /bin/Release/net8.0/linux-x64/publish/SimpleProject

Microsoft(R) Testing Platform Execution Command Line Tool
Version: 1.0.0-alpha.23567.1+9e2a929563d3929a92b57e402dceaaa1744a4ae5
RuntimeInformation: linux-x64 - .NET 8.0.0
Copyright(c) Microsoft Corporation.  All rights reserved.

Passed! - Failed: 0, Passed: 1, Skipped: 0, Total: 1, Duration: 319ms - SimpleProject.dll (linux-x64 - .NET 8.0.0)
```
