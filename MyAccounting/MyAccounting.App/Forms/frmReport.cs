using MyAccounting.DataLayer;
using MyAccounting.DataLayer.Context;
using MyAccounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Stimulsoft.Report.StiOptions;

namespace MyAccounting.App.Forms
{
    public partial class frmReport : Form
    {
        public int reportType = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {


            if (reportType == 1)
            {
                this.Text = "Income Report";
                BindGrid();
            }
            else
            {
                this.Text = "Expenses Report";
                gbReport.Text = "Expenses Report";
                BindGrid();
            }


        }

        private void BindGrid(string fillter = "", DateTime? startDate = null, DateTime? endDate = null)
        {

            using (var context = new MyAccountingDBEntities())
            {
                var query = from t1 in context.Contacts
                            join t2 in context.Transactions on t1.ContactID equals t2.ContactID
                            where t2.TypeID == reportType &&
                          (string.IsNullOrEmpty(fillter) ||
                           t1.FullName.Contains(fillter)) &&
                           (!startDate.HasValue || t2.DateTime >= startDate) &&
                           (!endDate.HasValue || t2.DateTime <= endDate)
                            select new
                            {
                                t2.ID,
                                t1.FullName,
                                t2.Amount,
                                t2.Discription,
                                t2.DateTime
                            };

                dgvReport.DataSource = query.ToList();
            }



        }

        private void btnEditT_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                frmAddEditTransaction frmEdit = new frmAddEditTransaction();
                int id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                frmEdit.TypeId = id;
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction");
            }

        }

        private void btnDeleteT_Click(object sender, EventArgs e)
        {
            if (dgvReport.CurrentRow != null)
            {
                int id = int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString());
                string contantName = dgvReport.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"Are you sure about deleting the {contantName}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (AccountingContext db = new AccountingContext())
                    {
                        db.TransactionRepository.Delete(id);
                        db.Save();

                    }
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("Please select a transaction");
                }
            }
        }
    

        private void btnApply_Click(object sender, EventArgs e)
        {
            DateTime? startDate = null;
            DateTime? endDate = null;

           
            if (DateTime.TryParse(txtFromDate.Text, out DateTime start))
            {
                startDate = start;
            }

            
            if (DateTime.TryParse(txtToDate.Text, out DateTime end))
            {
                endDate = end;
            }

            BindGrid(txtSearchT.Text, startDate, endDate);
        }

        private void btnPrintT_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("FullName");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Discription");
            dtPrint.Columns.Add("Date");



            foreach (DataGridViewRow item in dgvReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT",dtPrint);
            stiPrint.Show();


        }
    }
}
