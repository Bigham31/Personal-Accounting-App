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

namespace MyAccounting.App.Forms
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            // Bind the data grid view on form load
            BindGrid();

        }

        private void BindGrid()
        {
            using (AccountingContext db = new AccountingContext())
            {
                // Configure data grid view to not auto-generate columns and set its data source
                dgvContacts.AutoGenerateColumns = false;
                dgvContacts.DataSource = db.ContactRepository.Get();
            }
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            // Open the Add/Edit form to add a new contact
            frmAddOrEdit frmAdd = new frmAddOrEdit();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                // Refresh the data grid view after adding a new contact
                BindGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the data grid view
            BindGrid();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            // Open the Add/Edit form to edit an existing contact
            frmAddOrEdit frmEdit = new frmAddOrEdit();
            if (dgvContacts.CurrentRow != null)
            {
                // Get the ID of the selected contact and pass it to the Add/Edit form
                int id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
                frmEdit.contactid = id;
            }
            else
            {
                MessageBox.Show("Please Select a Contact");
            }
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                // Refresh the data grid view after editing a contact
                BindGrid();
            }
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            // Get the ID and name of the selected contact for deletion
            int id = int.Parse(dgvContacts.CurrentRow.Cells[0].Value.ToString());
            string contactName = dgvContacts.CurrentRow.Cells[1].Value.ToString();

            using (AccountingContext db = new AccountingContext())
            {
                //Checking whether the contact has a transaction or not
                bool hasTransactions = db.TransactionRepository.Get(c => c.ContactID == id).Any();
                if (hasTransactions == false)
                {
                    // Confirm deletion with a warning message
                    if (MessageBox.Show($"Are You Sure About Deleting The {contactName}", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Delete the contact from the database
                          db.ContactRepository.Delete(id);
                          db.Save();

                        // }
                    }
                    // Refresh the data grid view after deletion
                       BindGrid();

                }
                else
                {
                    MessageBox.Show("You cannot delete this contact because you have a transaction with this contact\r\n !First, you must delete the relevant transaction!");
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (AccountingContext db = new AccountingContext())
            {
                // Filter contacts in the data grid view based on the search text
                dgvContacts.DataSource = db.ContactRepository.Get(c => c.FullName.Contains(txtSearch.Text) || c.Email.Contains(txtSearch.Text) || c.Mobile.Contains(txtSearch.Text));
            }
        }
    }
}
