


using ConsoleDI.Sketch;
using ConsoleDI.Sketch.Interface;
using ConsoleDI.Sketch.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = new HostApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
builder.Services.AddTransient<ServiceLifeTimeReporter>();

using IHost host = builder.Build();

ExamplifyServiceLifetime(host.Services, "Lifetime 1");
ExamplifyServiceLifetime(host.Services, "Lifetime 2");

await host.RunAsync();


static void ExamplifyServiceLifetime(IServiceProvider hostProvider, string lifetime) {
    using IServiceScope serviceScope = hostProvider.CreateScope();
    IServiceProvider provider = serviceScope.ServiceProvider;
    ServiceLifeTimeReporter logger = provider.GetRequiredService<ServiceLifeTimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifeTimeReporter>()");

    Console.WriteLine("...");

    logger = provider.GetRequiredService<ServiceLifeTimeReporter>();
    logger.ReportServiceLifetimeDetails(
        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifeTimeReporter>()");

    Console.WriteLine("...");



}


