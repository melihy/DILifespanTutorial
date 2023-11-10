using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Sketch.Interface
{
    public interface IExampleScopedService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.LifeTime => ServiceLifetime.Scoped;
    }
}

