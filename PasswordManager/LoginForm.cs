using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var username = tbxUsername.Text;
            var password = tbxPassword.Text;

            if (username=="Furkan Dur"&& password=="bY!lPSo%")
            {
                PasswordManagerForm mainForm = new PasswordManagerForm();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
                tbxUsername.Clear();
                tbxPassword.Clear();
            }
                
        }
    }
}
