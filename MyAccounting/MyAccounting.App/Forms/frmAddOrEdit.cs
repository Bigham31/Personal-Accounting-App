using MyAccounting.DataLayer;
using MyAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace MyAccounting.App.Forms
{
    public partial class frmAddOrEdit : Form
    {
        // Variable to store the contact ID
        public int contactid = 0;

        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            // Check if it's a new contact or an existing one
            if (contactid == 0)
            {
                // Set the form title for adding a new contact
                this.Text = "Add New Contact";
            }
            else
            {
                // Load existing contact data for editing
                using (AccountingContext db = new AccountingContext())
                {
                    var contact = db.ContactRepository.GetByID(contactid);

                    // Populate form fields with existing contact data
                    txtFullName.Text = contact.FullName;
                    txtMobile.Text = contact.Mobile;
                    txtEmail.Text = contact.Email;
                    txtAddress.Text = contact.Address;
                    pcImage.ImageLocation = Application.StartupPath + "/Images/" + contact.Image;

                    // Set the form title and button text for editing
                    this.Text = "Edit Contact";
                    btnSubmit.Text = "Edit";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Generate a unique image name
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcImage.ImageLocation);
            string path = Application.StartupPath + "/Images/";

            // Create the directory if it doesn't exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // Save the image to the specified path
            pcImage.Image.Save(path + imageName);

            // Check if the form is valid
            if (BaseValidator.IsFormValid(this.components))
            {
                // Create a new contact object
                Contacts newContact = new Contacts()
                {
                    FullName = txtFullName.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    Image = imageName
                };

                // Use the database context to perform the appropriate action (insert or update)
                using (AccountingContext db = new AccountingContext())
                {
                    if (contactid == 0)
                    {
                        // Insert new contact
                        db.ContactRepository.Insert(newContact);
                    }
                    else
                    {
                        // Update existing contact
                        newContact.ContactID = contactid;
                        db.ContactRepository.Update(newContact);
                    }

                    // Save changes to the database
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            // Open file dialog to select an image
            OpenFileDialog newDialog = new OpenFileDialog();
            if (newDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the image location to the selected file
                pcImage.ImageLocation = newDialog.FileName;
            }
        }
    }
}

