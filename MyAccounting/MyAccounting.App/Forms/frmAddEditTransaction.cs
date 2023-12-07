using MyAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAccounting.DataLayer;
using ValidationComponents;

namespace MyAccounting.App.Forms
{
    public partial class frmAddEditTransaction : Form
    {
        public int TypeId = 0;
        public frmAddEditTransaction()
        {
            InitializeComponent();
        }

        private void frmAddEditTransaction_Load(object sender, EventArgs e)
        {
            using (AccountingContext db = new AccountingContext())
            {

                dgvTransaction.AutoGenerateColumns = false;
                dgvTransaction.DataSource = db.ViewModelRepository.GetContactNames();

                if (TypeId != 0)
                {
                    var Transaction = db.TransactionRepository.GetByID(TypeId);
                    txtContact.Text = db.ViewModelRepository.GetContactNameByid(Transaction.ContactID);
                    if (Transaction.TypeID == 1)
                    {
                        rbIncome.Checked = true;
                    }
                    else
                    {
                        rbExpenses.Checked = true;
                    }
                    nudAmount.Text = Transaction.Amount.ToString();
                    txtDiscription.Text = Transaction.Discription;

                }



            }
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtContact.Text = dgvTransaction.CurrentRow.Cells[1].Value.ToString();
        }


        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (AccountingContext db = new AccountingContext())
            {
                dgvTransaction.DataSource = db.ViewModelRepository.GetContactNames(txtSearch.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (AccountingContext db = new AccountingContext())
                {
                    if (rbIncome.Checked || rbExpenses.Checked)
                    {
                        Transactions newT = new Transactions()
                        {
                            Amount = int.Parse(nudAmount.Value.ToString()),
                            ContactID = db.ViewModelRepository.GetContactidByName(txtContact.Text),
                            TypeID = (rbIncome.Checked) ? 1 : 2,
                            DateTime = DateTime.Now,
                            Discription = txtDiscription.Text,

                        };
                        if (TypeId == 0)
                        {
                            db.TransactionRepository.Insert(newT);
                        }
                        else
                        {
                            newT.ID = TypeId;
                            db.TransactionRepository.Update(newT);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please select the type of transaction");
                    }
                    db.Save();
                    DialogResult = DialogResult.OK;

                }

            }
        }
    }
}
