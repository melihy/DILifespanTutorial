using ConsoleDI.Sketch.Interface;

namespace ConsoleDI.Sketch.Service
{
    internal sealed class ExampleSingletonService : IExampleSingletonService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}

