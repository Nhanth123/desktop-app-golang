using System.Data;
using System.Data.SQLite;

namespace DailyTaskT24.Database
{
    public class SQLiteHelper
    {
        private string _connectionString;

        public SQLiteHelper(string databaseFilePath)
        {
            // If the database file doesn't exist, create it
            if (!File.Exists(databaseFilePath))
            {
                SQLiteConnection.CreateFile(databaseFilePath);
            }

            _connectionString = $"Data Source={databaseFilePath};Version=3;";
        }

        // Open connection to the database (async)
        public async Task<SQLiteConnection> OpenConnectionAsync()
        {
            var connection = new SQLiteConnection(_connectionString);
            await connection.OpenAsync();
            return connection;
        }

        public SQLiteConnection OpenConnectionSync()
        {
            var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            return connection;
        }

        // Close connection to the database
        public void CloseConnection(SQLiteConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Execute a SQL query without returning data (INSERT, UPDATE, DELETE)
        public async Task ExecuteNonQueryAsync(string query)
        {
            using (var connection = await OpenConnectionAsync())
            using (var command = new SQLiteCommand(query, connection))
            {
                await command.ExecuteNonQueryAsync();
            }
        }

        // Execute a SQL query and return a single value (SELECT)
        public async Task<object> ExecuteScalarAsync(string query)
        {
            using (var connection = await OpenConnectionAsync())
            using (var command = new SQLiteCommand(query, connection))
            {
                return await command.ExecuteScalarAsync();
            }
        }

        // Execute a SQL query and return data (SELECT)
        public async Task<DataTable> ExecuteQueryAsync(string query)
        {
            using (var connection = await OpenConnectionAsync())
            using (var command = new SQLiteCommand(query, connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                var dataTable = new DataTable();
                await Task.Run(() => adapter.Fill(dataTable)); // Async filling the DataTable
                return dataTable;
            }
        }

        // Execute a parameterized SQL query (to prevent SQL injection)
        public async Task ExecuteNonQueryWithParamsAsync(string query, params SQLiteParameter[] parameters)
        {
            using (var connection = await OpenConnectionAsync())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                await command.ExecuteNonQueryAsync();
            }
        }

        // Example: Bind a parameterized SELECT query
        public async Task<DataTable> ExecuteQueryWithParamsAsync(string query, params SQLiteParameter[] parameters)
        {
            using (var connection = await OpenConnectionAsync())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddRange(parameters);
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    await Task.Run(() => adapter.Fill(dataTable)); // Async filling the DataTable
                    return dataTable;
                }
            }
        }

        public DataTable ExecuteQuerySync(string query)
        {
            using (var connection =  OpenConnectionSync())
            using (var command = new SQLiteCommand(query, connection))
            using (var adapter = new SQLiteDataAdapter(command))
            {
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

    }
}
