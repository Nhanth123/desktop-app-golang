using DailyTaskT24.Database;
using Serilog;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace DailyTaskT24;

public partial class CustomerMerger : Form
{
    private SQLiteHelper _sqliteHelper;
    DataTable companyTable = new();
    DataTable textMessageTable = new();

    public CustomerMerger()
    {
        InitializeComponent();
        Log.Information("CustomerMergerForm initialized.");

        _sqliteHelper = new SQLiteHelper("mydatabase.db");
    }
    private void LoadData()
    {
        companyTable = _sqliteHelper.ExecuteQuerySync("SELECT Name, Code FROM CompanyCode");

        col_MKH_Cancel.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_CMND_Cancel.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_Company_Cancel.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_MKH_InUse.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_CMND_InUse.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_TicketNumber.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 255);
        col_CompanyCode.DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128);

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
        //await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        var companyTable = await _sqliteHelper.ExecuteQueryAsync("SELECT Name, Code FROM CompanyCode");
        dgvCustomerOutput.DataSource = companyTable;
    }

    private void dgvCustomerInput_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.V)
        {
            if (!Clipboard.ContainsText()) return;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                LoadData();

                string clipboardText = Clipboard.GetText();

                string[] rows = clipboardText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                string errorMessage = "";

                foreach (var row in rows)
                {
                    string[] columns = row.Split('\t');

                    if (columns.Length <= 0) return;

                    string mkhCancel = columns[0];
                    string cmndCancel = columns[1];
                    string companyCancel = columns[2];
                    string mkhInUse = columns[3];
                    string cmndInUse = columns[4];
                    string ticketnumber = columns[5];

                    // Add the data to the DataGridView's new row
                    int newRowIndex = dgvCustomerInput.Rows.Add(); // Add a new row
                    DataGridViewRow newRow = dgvCustomerInput.Rows[newRowIndex];

                    newRow.Cells["col_MKH_Cancel"].Value = mkhCancel;
                    newRow.Cells["col_CMND_Cancel"].Value = cmndCancel;
                    newRow.Cells["col_Company_Cancel"].Value = companyCancel;
                    newRow.Cells["col_MKH_InUse"].Value = mkhInUse;
                    newRow.Cells["col_CMND_InUse"].Value = cmndInUse;
                    newRow.Cells["col_TicketNumber"].Value = ticketnumber;

                    var foundCompanyCode = from x in companyTable.AsEnumerable()
                                           where x.Field<string>("Name").ToUpper().Trim() == companyCancel.ToUpper().Trim()
                                           select x;

                    if (foundCompanyCode.Any())
                    {
                        foreach (DataRow item in foundCompanyCode)
                        {
                            newRow.Cells["col_CompanyCode"].Value = item["Code"];
                            break;
                        }
                    }
                    else
                    {
                        errorMessage = "Not found company name in database";
                        Log.Error(errorMessage);
                    }

                    newRow.ErrorText += errorMessage;

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Exeception occurs: {ex.Message}");
                MessageBox.Show($"Error. Please try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    private void btn_Verify_ClickAsync(object sender, EventArgs e)
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
        _sqliteHelper.ExecuteNonQueryWithParamsAsync(query, parameters);

    }

    private void btn_Verify_Click(object sender, EventArgs e)
    {
        if (dgvCustomerInput.Rows.Count < 0) return;

        DataTable messageTable = new DataTable();
        messageTable.Columns.Add("Message", typeof(string));

        string ticknumbepath = string.Empty;

        try
        {
            foreach (DataGridViewRow item in dgvCustomerInput.Rows)
            {
                string mkhCancel = item.Cells["col_MKH_Cancel"].Value.ToString() ?? string.Empty;
                string cmndCancel = item.Cells["col_CMND_Cancel"].Value.ToString() ?? string.Empty;
                string companyCodeCancel = item.Cells["col_CompanyCode"].Value.ToString() ?? string.Empty;
                string mkhInUse = item.Cells["col_MKH_InUse"].Value.ToString() ?? string.Empty;
                string cmndInUse = item.Cells["col_CMND_InUse"].Value.ToString() ?? string.Empty;
                string ticketnumber = item.Cells["col_TicketNumber"].Value.ToString() ?? string.Empty;
                string messsage = $"{mkhCancel}*{cmndCancel}*{mkhInUse}*{cmndInUse}*{companyCodeCancel}*{ticketnumber}";
                ticknumbepath = ticketnumber;
                messageTable.Rows.Add(messsage);
                Log.Debug($"Message:{messsage}");
            }

            dgvCustomerOutput.DataSource = messageTable;

            string filePath = $"{ticknumbepath}";
            ExportDataTableToCsv(messageTable, filePath);

        }
        catch (Exception ex)
        {
            Log.Error($"{ex.Message}");
            MessageBox.Show($"Error. Please try again.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    public void ExportDataTableToCsv(DataTable dataTable, string filePath)
    {

        // Add column names to the CSV
        //string[] columnNames = new string[dataTable.Columns.Count];
        //for (int i = 0; i < dataTable.Columns.Count; i++)
        //{
        //    columnNames[i] = dataTable.Columns[i].ColumnName;
        //}
        //sb.AppendLine(string.Join(",", columnNames));

        StringBuilder sb = new();

        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string file = Path.Combine(baseDirectory, filePath);

        // Add rows to the CSV
        foreach (DataRow row in dataTable.Rows)
        {
            string[] fields = new string[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                fields[i] = row[i].ToString().Replace(",", ";"); // Ensure commas inside values are handled
            }
            sb.AppendLine(string.Join(",", fields));
        }

        // Write to a file
        File.WriteAllText(file, sb.ToString());
    }

    private void btn_Upload_Click(object sender, EventArgs e)
    {

    }
}