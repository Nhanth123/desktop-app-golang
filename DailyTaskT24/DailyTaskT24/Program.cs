using Microsoft.Extensions.Configuration;
using Serilog;
using Renci.SshNet;
using DailyTaskT24.SSH;

namespace DailyTaskT24;

static class Program
{
    [STAThread]
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("logs\\app.log-.txt",
            outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
            rollingInterval: RollingInterval.Day)
       .CreateLogger();

        Log.Information("Application Starting...");


        // Set up configuration to read appsettings.json
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();


        // Read SSH configuration from appsettings.json
        var sshSettings = config.GetSection("SSHSettings");
        string host = sshSettings["Host"];
        string username = sshSettings["Username"];
        string password = sshSettings["Password"];

        SshHelper sshClient = new SshHelper(host, username, password);
        string command = "ls";

        // Execute the command
        sshClient.ConnectAndExecuteCommand(command);

        //builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));

        //var root = builder.Build();
        //var sampleConnectionString = root.GetConnectionString("DefaultConnection");



        ApplicationConfiguration.Initialize();
        Application.Run(new CustomerMerger());

        Log.CloseAndFlush();
    }
}