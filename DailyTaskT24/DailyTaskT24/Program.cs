using Microsoft.Extensions.Configuration;
using Serilog;

namespace DailyTaskT24;

static class Program
{
    [STAThread]
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log-.txt",
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            rollingInterval: RollingInterval.Day)
       .CreateLogger();

        IConfigurationBuilder builder = new ConfigurationBuilder();

        builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));




        var root = builder.Build();
        var sampleConnectionString = root.GetConnectionString("DefaultConnection");



        ApplicationConfiguration.Initialize();
        Application.Run(new CustomerMerger());
    }
}