using BUDGET.Data;
using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUDGET.WinForms.Forms
{
    public partial class frmRegister : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var noviUser = new User()
                {
                    Username = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPass.Text,
                };
                db.Users.Add(noviUser);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string password = GenerateRandomPassword(10);

            txtPass.Text = password;
        }

        private string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            var random = new Random();
            var passwordChars = new char[length];
            for (int i = 0; i < length; i++)
            {
                passwordChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(passwordChars);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text = txtName.Text + "@gmail.com";
        }

        private bool jeValidno()
        {
            return Validator.ProvjeriUnos(txtName, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txtEmail, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txtPass, err, Kljucevi.ReqiredValue);
        }
    }
}
