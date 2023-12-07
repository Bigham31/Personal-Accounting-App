using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MyAccounting.App.Forms;
using MyAccounting.Business;
using MyAccounting.DataLayer.Context;
using MyAccounting.ViewModel;

namespace MyAccounting.App
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                BindGrid();
            }
            else
            {
                Application.Exit();
            }




        }
        void BindGrid()
        {
            // Clear existing points
            lineChart.Series["seri"].Points.Clear();

            ReportChart rc = Account.LineChart();

            //Add Data points to the series
            lineChart.Series["seri"].Points.AddXY("Income", rc.Income);
            lineChart.Series["seri"].Points.AddXY("Expenses", rc.Expenses);

            //Set the colors of the columns
            lineChart.Series["seri"].Points[0].Color = Color.Green;
            lineChart.Series["seri"].Points[1].Color = Color.Red;


            List<PieChart> descriptionCounts = PieChartAccount.chart();

            // Clear existing points
            pieChart.Series["DescriptionSeries"].Points.Clear();

            // Add Data points to the series
            foreach (var descriptionCount in descriptionCounts)
            {
                pieChart.Series["DescriptionSeries"].Points.AddXY(descriptionCount.Description, descriptionCount.Amount);
            }
            
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            //Create contact form
            frmContacts frmcontacts = new frmContacts();
            if (frmcontacts.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnTrancaction_Click(object sender, EventArgs e)
        {
            //Open Add/Edit form to the add new Transaction
            frmAddEditTransaction frmadd = new frmAddEditTransaction();
            frmadd.ShowDialog();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            //Open the report form to show the income report
            frmReport frmIncome = new frmReport();
            frmIncome.reportType = 1;
            frmIncome.ShowDialog();

        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            //Open the report form to show the expenses report
            frmReport frmExpenses = new frmReport();
            frmExpenses.reportType = 2;
            frmExpenses.ShowDialog();
        }

        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.loginOrEdit = 1;
            frmLogin.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }

}
