using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.DataAcces;
using PasswordManager.Models;

namespace PasswordManager
{
    public partial class PasswordManagerForm : Form
    {
        public PasswordManagerForm()
        {
            InitializeComponent();

        }
        PasswordDal _passwordDal = new PasswordDal();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordManagerForm_Load(object sender, EventArgs e)
        {
            LoadPasswords();
        }

        private void LoadPasswords()
        {
            dgwPasswords.DataSource = _passwordDal.GetAll();
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            tbxAddPassword.Text = CreatePassword();
        }

        public string CreatePassword()
        {
            Random random = new Random();
            var password = "";

            for (int i = 0; i <= 2; i++)
            {
                password += (char)random.Next(33, 65); //rastgele Sembol oluşturma
                password += (char)random.Next(65, 91); //rastgele Büyük Harf Oluşturma
                password += (char)random.Next(97, 123); //rastgele küçük harf Oluşturma
                password += random.Next(0, 10); //rastgele Rakam oluşturma
            }

            return password;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _passwordDal.Add(new Passwords
                {
                    Platform = tbxAddPlatform.Text,
                    Username = tbxAddUsername.Text,
                    Password = tbxAddPassword.Text

                });
                LoadPasswords();
                MessageBox.Show("Başarıyla Eklendi!");
                tbxAddPlatform.Clear();
                tbxAddUsername.Clear();
                tbxAddPassword.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }

        }



        private void dgwPasswords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdatePlatform.Text = dgwPasswords.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateUsername.Text = dgwPasswords.CurrentRow.Cells[2].Value.ToString();
            tbxUpdatePassword.Text = dgwPasswords.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _passwordDal.Update(new Passwords
                {
                    Id = Convert.ToInt32(dgwPasswords.CurrentRow.Cells[0].Value),
                    Platform = tbxUpdatePlatform.Text,
                    Username = tbxUpdateUsername.Text,
                    Password = tbxUpdatePassword.Text
                });
                LoadPasswords();
                MessageBox.Show("Başarıyla Güncellendi!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnDeletePassword_Click(object sender, EventArgs e)
        {
            try
            {
                _passwordDal.Delete(new Passwords
                {
                    Id = Convert.ToInt32(dgwPasswords.CurrentRow.Cells[0].Value)
                });
                LoadPasswords();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tbxSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbxSearchByName.Text))
            {
                LoadPasswords();
            }
            else
            {
                dgwPasswords.DataSource = _passwordDal.GetAll(p => p.Platform.Contains(tbxSearchByName.Text));
            }
        }
    }
}
