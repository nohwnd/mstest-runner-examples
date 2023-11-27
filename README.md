# MSTestRunner examples

MSTestRunner is a light-weight and portable alternative to [microsoft/vstest](https://github.com/microsoft/vstest) for running tests in continuous integration pipelines, and in VisualStudio TestExplorer (Coming soon!).

This runner is embedded directly in your test project, and there is no additional application (e.g. vstest.console / dotnet test) or any additional infrastructure (e.g. dotnet SDK) needed to run your tests.

MSTestRunner lives in [microsoft/testfx](https://github.com/microsoft/testfx/tree/main/src/Platform/Microsoft.Testing.Platform) repository, and comes bundled with MSTest in 3.2.0-preview. This preview is available on [test-tools NuGet feed](https://pkgs.dev.azure.com/dnceng/public/_packaging/test-tools/nuget/v3/index.json).

## Examples

### SimpleProject1

SimpleProject1 showcases the simplest project there is for running MSTest tests using the new runner.

[Full example](SimpleProject1/README.md)

### NativeAOTProject1

NativeAOTProject1 shows a future approach, where the test framework and the runner are both native AOT compatible and can be published and run as native apps.

[Full example](NativeAOTProject1/README.md)