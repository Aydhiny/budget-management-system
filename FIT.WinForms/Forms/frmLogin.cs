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
    public partial class frmLogin : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        public frmLogin()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidirajKontrolu(txtUsername, txtPassword))
            {
                var korisnik = db.Users.FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                // Ako je korisnik pronađen
                if (korisnik != null)
                {
                    // Dohvati ID korisnika
                    this.Hide();
                    int userId = korisnik.UserId;
                    var frm = new frmDashboard(userId);
                    frm.Show();
                }
            }
            else
                MessageBox.Show("Netacno uneseni podaci!", "Niste pravilno unijeli podatke!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private bool ValidirajKontrolu(TextBox txt1, TextBox txt2)
        {
            return Validator.ProvjeriUnos(txt1, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txt2, err, Kljucevi.ReqiredValue);
        }
        private void label7_Click(object sender, EventArgs e)
        {
            var frm = new frmRegister();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmRegister();
            frm.ShowDialog();
        }
    }
}
