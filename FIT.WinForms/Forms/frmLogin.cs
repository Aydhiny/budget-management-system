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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidirajKontrolu(txtUsername, txtPassword))
            {
                var podaci = db.Users.ToList();
                var frm = new frmDashboard(podaci.First);

            }
        }

        private bool ValidirajKontrolu(TextBox txt1, TextBox txt2)
        {
            return Validator.ProvjeriUnos(txt1, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txt2, err, Kljucevi.ReqiredValue);
        }
    }
}
