namespace MyAccounting.App.Forms
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEditT = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteT = new System.Windows.Forms.ToolStripButton();
            this.btnPrintT = new System.Windows.Forms.ToolStripButton();
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.toolStrip1.SuspendLayout();
            this.gbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditT,
            this.btnDeleteT,
            this.btnPrintT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 77);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEditT
            // 
            this.btnEditT.Image = global::MyAccounting.App.Properties.Resources.icons8_edit_50;
            this.btnEditT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditT.Name = "btnEditT";
            this.btnEditT.Size = new System.Drawing.Size(54, 74);
            this.btnEditT.Text = "Edit";
            this.btnEditT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditT.Click += new System.EventHandler(this.btnEditT_Click);
            // 
            // btnDeleteT
            // 
            this.btnDeleteT.Image = global::MyAccounting.App.Properties.Resources.icons8_remove_50;
            this.btnDeleteT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteT.Name = "btnDeleteT";
            this.btnDeleteT.Size = new System.Drawing.Size(57, 74);
            this.btnDeleteT.Text = "Delete";
            this.btnDeleteT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteT.Click += new System.EventHandler(this.btnDeleteT_Click);
            // 
            // btnPrintT
            // 
            this.btnPrintT.Image = global::MyAccounting.App.Properties.Resources.icons8_print_50;
            this.btnPrintT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrintT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintT.Name = "btnPrintT";
            this.btnPrintT.Size = new System.Drawing.Size(54, 74);
            this.btnPrintT.Text = "Print";
            this.btnPrintT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintT.Click += new System.EventHandler(this.btnPrintT_Click);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(421, 27);
            this.txtFromDate.Mask = "00/00/0000";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 24);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Date :";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(581, 27);
            this.txtToDate.Mask = "00/00/0000";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(100, 24);
            this.txtToDate.TabIndex = 3;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            // 
            // gbReport
            // 
            this.gbReport.Controls.Add(this.dgvReport);
            this.gbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReport.Location = new System.Drawing.Point(0, 77);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(774, 384);
            this.gbReport.TabIndex = 4;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Income Report";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(3, 20);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(768, 361);
            this.dgvReport.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ContactID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FullName";
            this.Column2.HeaderText = "FullName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "Amount";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Discription";
            this.Column4.HeaderText = "Discription";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DateTime";
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search :";
            // 
            // txtSearchT
            // 
            this.txtSearchT.Location = new System.Drawing.Point(245, 27);
            this.txtSearchT.Name = "txtSearchT";
            this.txtSearchT.Size = new System.Drawing.Size(100, 24);
            this.txtSearchT.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "From Date :";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(687, 25);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "1e9a9d6181e34d1292869796f576c848";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 461);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnEditT;
        private System.Windows.Forms.ToolStripButton btnPrintT;
        private System.Windows.Forms.ToolStripButton btnDeleteT;
        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnApply;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}