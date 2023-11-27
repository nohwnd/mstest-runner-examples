using NativeAOTProject1;

ITestApplicationBuilder builder = await TestApplication.CreateBuilderAsync(args);
builder.AddTestFramework(new SourceGeneratedTestNodesBuilder());
builder.AddCrashDumpGenerator();
builder.AddHangDumpGenerator();
builder.AddAppInsightsTelemetryProvider();
builder.AddTrxReportGenerator();
using ITestApplication app = await builder.BuildAsync();
return await app.RunAsync();
