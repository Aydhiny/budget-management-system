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
    public partial class frmCategory : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        public frmCategory()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                int budgetAmount;

                if (int.TryParse(txtBudget.Text, out budgetAmount))
                {
                    var noviCategory = new BudgetCategory()
                    {
                        CategoryName = txtName.Text,
                        BudgetAmount = budgetAmount 
                    };

                    db.BudgetCategories.Add(noviCategory);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid budget amount. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool jeValidno()
        {
            return Validator.ProvjeriUnos(txtName, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txtBudget, err, Kljucevi.ReqiredValue);
        }

        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
