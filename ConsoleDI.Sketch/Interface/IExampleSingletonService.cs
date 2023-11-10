using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Sketch.Interface
{
    public interface IExampleSingletonService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.LifeTime => ServiceLifetime.Singleton;
    }
}

