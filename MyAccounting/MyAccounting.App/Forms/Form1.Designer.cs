namespace MyAccounting.App
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbChart = new System.Windows.Forms.GroupBox();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnTrancaction = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.gbChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChart
            // 
            this.gbChart.Controls.Add(this.pieChart);
            this.gbChart.Controls.Add(this.btnRefresh);
            this.gbChart.Controls.Add(this.lineChart);
            this.gbChart.Location = new System.Drawing.Point(12, 12);
            this.gbChart.Name = "gbChart";
            this.gbChart.Size = new System.Drawing.Size(657, 379);
            this.gbChart.TabIndex = 4;
            this.gbChart.TabStop = false;
            this.gbChart.Text = "Charts";
            // 
            // pieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea1);
            this.pieChart.Location = new System.Drawing.Point(303, 20);
            this.pieChart.Name = "pieChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsVisibleInLegend = false;
            series1.Name = "DescriptionSeries";
            this.pieChart.Series.Add(series1);
            this.pieChart.Size = new System.Drawing.Size(287, 353);
            this.pieChart.TabIndex = 2;
            this.pieChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Expenses";
            this.pieChart.Titles.Add(title1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(596, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(55, 25);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lineChart
            // 
            chartArea2.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea2);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineChart.Location = new System.Drawing.Point(3, 20);
            this.lineChart.Name = "lineChart";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Name = "seri";
            this.lineChart.Series.Add(series2);
            this.lineChart.Size = new System.Drawing.Size(294, 356);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lChart";
            title2.Name = "Title1";
            title2.Text = "Icome and Expenses";
            this.lineChart.Titles.Add(title2);
            // 
            // btnContacts
            // 
            this.btnContacts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnContacts.Image = global::MyAccounting.App.Properties.Resources.icons8_customer_50;
            this.btnContacts.Location = new System.Drawing.Point(675, 89);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(77, 71);
            this.btnContacts.TabIndex = 5;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContacts.UseVisualStyleBackColor = false;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnIncome.Image = global::MyAccounting.App.Properties.Resources.icons8_income_50;
            this.btnIncome.Location = new System.Drawing.Point(675, 320);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(77, 71);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "Income";
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExpenses.Image = global::MyAccounting.App.Properties.Resources.icons8_general_ledger_50;
            this.btnExpenses.Location = new System.Drawing.Point(675, 243);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(77, 71);
            this.btnExpenses.TabIndex = 2;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnTrancaction
            // 
            this.btnTrancaction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTrancaction.Image = global::MyAccounting.App.Properties.Resources.icons8_transactions_50;
            this.btnTrancaction.Location = new System.Drawing.Point(675, 166);
            this.btnTrancaction.Name = "btnTrancaction";
            this.btnTrancaction.Size = new System.Drawing.Size(77, 71);
            this.btnTrancaction.TabIndex = 1;
            this.btnTrancaction.Text = "Transaction";
            this.btnTrancaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrancaction.UseVisualStyleBackColor = false;
            this.btnTrancaction.Click += new System.EventHandler(this.btnTrancaction_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserSetting.Image = global::MyAccounting.App.Properties.Resources.icons8_setting_50;
            this.btnUserSetting.Location = new System.Drawing.Point(675, 12);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(77, 71);
            this.btnUserSetting.TabIndex = 0;
            this.btnUserSetting.Text = "User Setting";
            this.btnUserSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserSetting.UseVisualStyleBackColor = false;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 403);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.gbChart);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnTrancaction);
            this.Controls.Add(this.btnUserSetting);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Personal Accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserSetting;
        private System.Windows.Forms.Button btnTrancaction;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.GroupBox gbChart;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
    }
}

