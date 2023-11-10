using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Sketch.Interface
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }

        ServiceLifetime LifeTime { get; }
    }
}
