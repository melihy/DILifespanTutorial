using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Sketch.Interface
{
    public interface IExampleTransientService : IReportServiceLifetime
    {
        ServiceLifetime IReportServiceLifetime.LifeTime => ServiceLifetime.Transient;
    }
}
