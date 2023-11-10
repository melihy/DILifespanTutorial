using ConsoleDI.Sketch.Interface;

namespace ConsoleDI.Sketch.Service
{
    internal sealed class ExampleTransientService : IExampleTransientService
    {
        Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
    }
}
