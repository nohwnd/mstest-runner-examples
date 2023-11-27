### NativeAOTProject1

NativeAOTProject1 shows a possible future, where the test framework and the runner are both native AOT compatible and can be published and run as native apps.

The project is a special test project using the core of the new MSTest runner, and a prototype testing framework. The testing framework generates test description using source generators on compile time, and avoids using any Reflection.

Extensibility is achieved by statically registering extension in Program.cs, such as the TRX reporter.

Application is then published with `-p:PublishAOT=true`, to produce a native application, and can be executed to run tests: 

```
PS> cd NativeAOTProject1
PS NativeAOTProject1> dotnet publish -p:PublishAOT=true
MSBuild version 17.8.3+195e7f5a3 for .NET
  Determining projects to restore...
  Restored... 
  Generating native code
  NativeAOTProject1 -> NativeAOTProject1\bin\Release\net8.0\win-x64\publish\


PS NativeAOTProject1> bin\Release\net8.0\win-x64\publish\NativeAOTProject1.exe --report-trx --report-trx-filename "run.trx"
Microsoft(R) Testing Platform Execution Command Line Tool
Copyright(c) Microsoft Corporation.  All rights reserved.
Passed! - Failed: 0, Passed: 1, Skipped: 0, Total: 1, Duration: 1ms - NativeAOTProject1.exe

In process file artifacts produced:
- bin\Release\net8.0\win-x64\publish\TestResults\run.trx
```

A full suite of tests using this framework and runner can be found in: <https://github.com/microsoft/testfx/tree/main/test/UnitTests/Microsoft.Testing.Platform.UnitTests>.