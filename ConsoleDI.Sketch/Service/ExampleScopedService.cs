using ConsoleDI.Sketch.Interface;

namespace ConsoleDI.Sketch.Service
{
    internal sealed class ExampleScopedService : IExampleScopedService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}

