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
            this.components = new System.ComponentModel.Container();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCustomerInput = new System.Windows.Forms.DataGridView();
            this.col_MKH_Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CMND_Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Company_Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MKH_InUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CMND_InUse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TicketNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomerOutput = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
            this.bsCustomerImport = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOutput)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerImport)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(3, 35);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(75, 23);
            this.btn_Verify.TabIndex = 0;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.00152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.99848F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvCustomerOutput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1314, 542);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvCustomerInput
            // 
            this.dgvCustomerInput.AllowUserToAddRows = false;
            this.dgvCustomerInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MKH_Cancel,
            this.col_CMND_Cancel,
            this.col_Company_Cancel,
            this.col_MKH_InUse,
            this.col_CMND_InUse,
            this.col_TicketNumber,
            this.col_CompanyCode});
            this.dgvCustomerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerInput.Location = new System.Drawing.Point(3, 74);
            this.dgvCustomerInput.Name = "dgvCustomerInput";
            this.dgvCustomerInput.Size = new System.Drawing.Size(743, 435);
            this.dgvCustomerInput.TabIndex = 1;
            this.dgvCustomerInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCustomerInput_KeyUp);
            // 
            // col_MKH_Cancel
            // 
            this.col_MKH_Cancel.HeaderText = "MKH_HUY";
            this.col_MKH_Cancel.Name = "col_MKH_Cancel";
            // 
            // col_CMND_Cancel
            // 
            this.col_CMND_Cancel.HeaderText = "CMND_HUY";
            this.col_CMND_Cancel.Name = "col_CMND_Cancel";
            // 
            // col_Company_Cancel
            // 
            this.col_Company_Cancel.HeaderText = "Company_Huy";
            this.col_Company_Cancel.Name = "col_Company_Cancel";
            // 
            // col_MKH_InUse
            // 
            this.col_MKH_InUse.HeaderText = "MKH_SuDung";
            this.col_MKH_InUse.Name = "col_MKH_InUse";
            // 
            // col_CMND_InUse
            // 
            this.col_CMND_InUse.HeaderText = "CMND_SuDung";
            this.col_CMND_InUse.Name = "col_CMND_InUse";
            // 
            // col_TicketNumber
            // 
            this.col_TicketNumber.HeaderText = "PYC_HUY";
            this.col_TicketNumber.Name = "col_TicketNumber";
            // 
            // col_CompanyCode
            // 
            this.col_CompanyCode.HeaderText = "CompanyCode";
            this.col_CompanyCode.Name = "col_CompanyCode";
            // 
            // dgvCustomerOutput
            // 
            this.dgvCustomerOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerOutput.Location = new System.Drawing.Point(752, 74);
            this.dgvCustomerOutput.Name = "dgvCustomerOutput";
            this.dgvCustomerOutput.RowTemplate.Height = 25;
            this.dgvCustomerOutput.Size = new System.Drawing.Size(559, 435);
            this.dgvCustomerOutput.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.91729F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.08271F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Verify, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 65);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 515);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Upload, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(752, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(337, 65);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(3, 35);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(75, 23);
            this.btn_Upload.TabIndex = 0;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            // 
            // CustomerMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 542);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerMerger";
            this.Text = "CustomerMerger";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOutput)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerImport)).EndInit();
            this.ResumeLayout(false);

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
    private TableLayoutPanel tableLayoutPanel3;
    private Button btn_Upload;
    private DataGridViewTextBoxColumn col_MKH_Cancel;
    private DataGridViewTextBoxColumn col_CMND_Cancel;
    private DataGridViewTextBoxColumn col_Company_Cancel;
    private DataGridViewTextBoxColumn col_MKH_InUse;
    private DataGridViewTextBoxColumn col_CMND_InUse;
    private DataGridViewTextBoxColumn col_TicketNumber;
    private DataGridViewTextBoxColumn col_CompanyCode;
}