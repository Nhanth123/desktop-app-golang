using System.ComponentModel;

namespace DailyTaskT24;

partial class CustomerMerger
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        btn_Verify = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        dgvCustomerInput = new DataGridView();
        col_MKH_Cancel = new DataGridViewTextBoxColumn();
        col_CMND_Cancel = new DataGridViewTextBoxColumn();
        col_MKH_InUse = new DataGridViewTextBoxColumn();
        col_CMND_InUse = new DataGridViewTextBoxColumn();
        col_Company_Cancel = new DataGridViewTextBoxColumn();
        col_TicketNumber = new DataGridViewTextBoxColumn();
        col_CompanyCode = new DataGridViewTextBoxColumn();
        dgvCustomerOutput = new DataGridView();
        tableLayoutPanel2 = new TableLayoutPanel();
        progressBar1 = new ProgressBar();
        bgwWorker = new BackgroundWorker();
        bsCustomerImport = new BindingSource(components);
        tableLayoutPanel3 = new TableLayoutPanel();
        btn_Upload = new Button();
        tableLayoutPanel1.SuspendLayout();
        ((ISupportInitialize)dgvCustomerInput).BeginInit();
        ((ISupportInitialize)dgvCustomerOutput).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        ((ISupportInitialize)bsCustomerImport).BeginInit();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // btn_Verify
        // 
        btn_Verify.Location = new Point(3, 35);
        btn_Verify.Name = "btn_Verify";
        btn_Verify.Size = new Size(75, 23);
        btn_Verify.TabIndex = 0;
        btn_Verify.Text = "Verify";
        btn_Verify.UseVisualStyleBackColor = true;
        btn_Verify.Click += btn_Verify_ClickAsync;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.73291F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2670918F));
        tableLayoutPanel1.Controls.Add(dgvCustomerInput, 0, 1);
        tableLayoutPanel1.Controls.Add(dgvCustomerOutput, 1, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(progressBar1, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 413F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(1097, 543);
        tableLayoutPanel1.TabIndex = 3;
        // 
        // dgvCustomerInput
        // 
        dgvCustomerInput.AllowUserToAddRows = false;
        dgvCustomerInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomerInput.Columns.AddRange(new DataGridViewColumn[] { col_MKH_Cancel, col_CMND_Cancel, col_MKH_InUse, col_CMND_InUse, col_Company_Cancel, col_TicketNumber, col_CompanyCode });
        dgvCustomerInput.Dock = DockStyle.Fill;
        dgvCustomerInput.Location = new Point(3, 74);
        dgvCustomerInput.Name = "dgvCustomerInput";
        dgvCustomerInput.Size = new Size(748, 407);
        dgvCustomerInput.TabIndex = 1;
        dgvCustomerInput.KeyUp += dgvCustomerInput_KeyUp;
        // 
        // col_MKH_Cancel
        // 
        col_MKH_Cancel.HeaderText = "MKH_HUY";
        col_MKH_Cancel.Name = "col_MKH_Cancel";
        // 
        // col_CMND_Cancel
        // 
        col_CMND_Cancel.HeaderText = "CMND_HUY";
        col_CMND_Cancel.Name = "col_CMND_Cancel";
        // 
        // col_MKH_InUse
        // 
        col_MKH_InUse.HeaderText = "MKH_SuDung";
        col_MKH_InUse.Name = "col_MKH_InUse";
        // 
        // col_CMND_InUse
        // 
        col_CMND_InUse.HeaderText = "CMND_SuDung";
        col_CMND_InUse.Name = "col_CMND_InUse";
        // 
        // col_Company_Cancel
        // 
        col_Company_Cancel.HeaderText = "Company_Huy";
        col_Company_Cancel.Name = "col_Company_Cancel";
        // 
        // col_TicketNumber
        // 
        col_TicketNumber.HeaderText = "PYC_HUY";
        col_TicketNumber.Name = "col_TicketNumber";
        // 
        // col_CompanyCode
        // 
        col_CompanyCode.HeaderText = "CompanyCode";
        col_CompanyCode.Name = "col_CompanyCode";
        // 
        // dgvCustomerOutput
        // 
        dgvCustomerOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomerOutput.Dock = DockStyle.Fill;
        dgvCustomerOutput.Location = new Point(757, 74);
        dgvCustomerOutput.Name = "dgvCustomerOutput";
        dgvCustomerOutput.RowTemplate.Height = 25;
        dgvCustomerOutput.Size = new Size(337, 407);
        dgvCustomerOutput.TabIndex = 2;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.9172935F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.08271F));
        tableLayoutPanel2.Controls.Add(btn_Verify, 0, 1);
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Size = new Size(532, 65);
        tableLayoutPanel2.TabIndex = 3;
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(3, 487);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(159, 23);
        progressBar1.TabIndex = 4;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.85714F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.14286F));
        tableLayoutPanel3.Controls.Add(btn_Upload, 0, 1);
        tableLayoutPanel3.Location = new Point(757, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel3.Size = new Size(337, 65);
        tableLayoutPanel3.TabIndex = 5;
        // 
        // btn_Upload
        // 
        btn_Upload.Location = new Point(3, 35);
        btn_Upload.Name = "btn_Upload";
        btn_Upload.Size = new Size(75, 23);
        btn_Upload.TabIndex = 0;
        btn_Upload.Text = "Upload";
        btn_Upload.UseVisualStyleBackColor = true;
        // 
        // CustomerMerger
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1097, 543);
        Controls.Add(tableLayoutPanel1);
        Name = "CustomerMerger";
        Text = "CustomerMerger";
        tableLayoutPanel1.ResumeLayout(false);
        ((ISupportInitialize)dgvCustomerInput).EndInit();
        ((ISupportInitialize)dgvCustomerOutput).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        ((ISupportInitialize)bsCustomerImport).EndInit();
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private TableLayoutPanel tableLayoutPanel1;

    #endregion

    private Button btn_Verify;
    private DataGridView dgvCustomerInput;
    private BackgroundWorker bgwWorker;
    private DataGridView dgvCustomerOutput;
    private TableLayoutPanel tableLayoutPanel2;
    private ProgressBar progressBar1;
    private BindingSource bsCustomerImport;
    private DataGridViewTextBoxColumn col_MKH_Cancel;
    private DataGridViewTextBoxColumn col_CMND_Cancel;
    private DataGridViewTextBoxColumn col_MKH_InUse;
    private DataGridViewTextBoxColumn col_CMND_InUse;
    private DataGridViewTextBoxColumn col_Company_Cancel;
    private DataGridViewTextBoxColumn col_TicketNumber;
    private DataGridViewTextBoxColumn col_CompanyCode;
    private TableLayoutPanel tableLayoutPanel3;
    private Button btn_Upload;
}