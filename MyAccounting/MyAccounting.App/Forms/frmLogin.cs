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
using ValidationComponents;

namespace MyAccounting.App.Forms
{
    public partial class frmLogin : Form
    {
        public int loginOrEdit = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (loginOrEdit != 0)
            {
                using (AccountingContext db = new AccountingContext())
                {
                    this.Text = "Edit user settings";
                    btnLogin.Text = "Edit";
                    var User = db.LoginRepository.Get().First();
                    txtUser.Text = User.UserName;
                    txtPassword.Text = User.Password;

                }
            }
            else
            {
                this.Text = "Login";
                btnLogin.Text = "Login";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (AccountingContext db = new AccountingContext())

                {
                    if (loginOrEdit != 0)
                    {


                        var User = db.LoginRepository.Get().First();
                        User.UserName = txtUser.Text;
                        User.Password = txtPassword.Text;
                        db.LoginRepository.Update(User);
                        db.Save();
                        Application.Restart();
                    }
                    if (db.LoginRepository.Get(l => l.UserName == txtUser.Text && l.Password == txtPassword.Text).Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("The information entered is not correct");
                    }
                }


            }
        }
    }
}
