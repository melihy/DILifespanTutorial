using ConsoleDI.Sketch.Interface;

namespace ConsoleDI.Sketch
{
    internal sealed class ServiceLifeTimeReporter
    {
        private readonly IExampleScopedService _exampleScopedService;
        private readonly IExampleTransientService _exampleTransientService;
        private readonly IExampleSingletonService _exampleSingletonService;

        public ServiceLifeTimeReporter(
            IExampleTransientService exampleTransientService
            , IExampleScopedService exampleScopedService
            , IExampleSingletonService exampleSingletonService) =>
            (_exampleTransientService, _exampleScopedService, _exampleSingletonService) =
            (exampleTransientService, exampleScopedService, exampleSingletonService);

        internal void ReportServiceLifetimeDetails(string lifeTimeDetails)
        {
            Console.WriteLine(lifeTimeDetails);

            LogService(_exampleTransientService, "Always different");
            LogService(_exampleScopedService, "Changes only with lifetime");
            LogService(_exampleSingletonService, "Always the same");

        }

        private static void LogService<T>(T Service, string message)
            where T : IReportServiceLifetime =>
            Console.WriteLine($"    {typeof(T).Name}: {Service.Id} ({message})");
    }
}
