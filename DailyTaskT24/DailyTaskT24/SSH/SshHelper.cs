using Renci.SshNet;
using Serilog;

namespace DailyTaskT24.SSH
{
    public class SshHelper
    {

        private string _host;
        private string _username;
        private string _password;
        
        public SshHelper(string host, string username, string password)
        {
            _host = host;
            _username = username;
            _password = password;
        }

        public void ConnectAndExecuteCommand(string command)
        {
            try
            {
                using (var sshClient = new SshClient(_host, _username, _password))
                {
                    // Connect to the server
                    sshClient.Connect();

                    if (sshClient.IsConnected)
                    {
                        Log.Debug("Connected to the SSH server.");

                        // Execute the command
                        var result = sshClient.RunCommand(command);

                        // Output the result
                        Log.Debug($"Command Output: {result.Result}");
                    }
                    else
                    {
                        Log.Debug("Could not connect to the SSH server.");
                    }

                    // Disconnect after the command execution
                    sshClient.Disconnect();
                    Log.Debug("Disconnected from the SSH server.");
                }
            }
            catch (Exception ex)
            {
                Log.Debug($"Error: {ex.Message}");
            }
        }
    }
}
