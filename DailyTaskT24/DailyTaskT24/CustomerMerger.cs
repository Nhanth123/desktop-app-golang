using DailyTaskT24.Database;
using Serilog;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace DailyTaskT24;

public partial class CustomerMerger : Form
{
    private SQLiteHelper _sqliteHelper;

    public CustomerMerger()
    {
        InitializeComponent();
        Log.Information("CustomerMergerForm initialized.");

        _sqliteHelper = new SQLiteHelper("mydatabase.db");

    }

    private async Task LoadData()
    {
        Cursor.Current = Cursors.WaitCursor;

        var companyTable = await _sqliteHelper.ExecuteQueryAsync("SELECT Name, Code FROM CompanyCode");


        Cursor.Current = Cursors.Default;

    }

    private async Task InitializeDatabaseAsync()
    {
        // Create table if not exists
        await _sqliteHelper.ExecuteNonQueryAsync(@"CREATE TABLE IF NOT EXISTS CompanyCode (
                                                    Id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                                    Name TEXT NOT NULL, 
                                                    Code TEXT NOT NULL)");

        // Insert some sample data
        await _sqliteHelper.ExecuteNonQueryAsync(@"INSERT INTO CompanyCode (Name, Code) VALUES ('John Doe', 30)");

        // Query and display data
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        var companyTable = await _sqliteHelper.ExecuteQueryAsync("SELECT Name, Code FROM CompanyCode");
        dgvCustomerOutput.DataSource = companyTable; // Assuming you have a DataGridView to show data
    }

    private void dgvCustomerInput_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.V)
        {
            if (!Clipboard.ContainsText()) return;

            try
            {
                string clipboardText = Clipboard.GetText();

                string[] rows = clipboardText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var row in rows)
                {
                    string[] columns = row.Split('\t');

                    if (columns.Length <= 0) return;

                    string mkhCancel = columns[0];
                    string cmndCancel = columns[1];
                    string mkhInUse = columns[2];
                    string cmndInUse = columns[3];
                    string companyCancel = columns[4];
                    string ticketnumber = columns[5];

                    // Add the data to the DataGridView's new row
                    int newRowIndex = dgvCustomerInput.Rows.Add(); // Add a new row
                    DataGridViewRow newRow = dgvCustomerInput.Rows[newRowIndex];

                    newRow.Cells["col_MKH_Cancel"].Value = mkhCancel;
                    newRow.Cells["col_CMND_Cancel"].Value = cmndCancel;
                    newRow.Cells["col_MKH_InUse"].Value = mkhInUse;
                    newRow.Cells["col_CMND_InUse"].Value = cmndInUse;
                    newRow.Cells["col_Company_Cancel"].Value = companyCancel;
                    newRow.Cells["col_TicketNumber"].Value = ticketnumber;

                    dt

                }
            }
            catch (Exception ex)
            {
                Log.Error($"Exeception occurs: {ex.Message}");
                MessageBox.Show("Error");
            }

        }
    }

    private async void btn_Verify_ClickAsync(object sender, EventArgs e)
    {
        // Add a new user to the database using parameterized query
        string name = "Jane Doe"; // Example input
        int code = 25; // Example input

        var parameters = new SQLiteParameter[]
        {
            new SQLiteParameter("@Name", name),
            new SQLiteParameter("@Code", code)
        };

        string query = "INSERT INTO CompanyCode (Name, Code) VALUES (@Name, @Code)";
        await _sqliteHelper.ExecuteNonQueryWithParamsAsync(query, parameters);

        // Refresh the data in the DataGridView
        await LoadDataAsync();
    }
}