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
    public partial class frmExpense : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        private int userId;
        public frmExpense(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            cmbCategories.DataSource = db.BudgetCategories.ToList();
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            cmbCategories.DataSource = db.BudgetCategories.ToList();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                int budgetAmount;

                if (int.TryParse(txtAmount.Text, out budgetAmount))
                {
                    var noviExpense = new Expense()
                    {
                        UserId = userId,
                        Amount = budgetAmount,
                        Description = txtDesc.Text,
                        Date = dtpDate.Text,
                        CategoryId = cmbCategories.SelectedIndex,
                    };

                    db.Expenses.Add(noviExpense);
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
            return Validator.ProvjeriUnos(txtAmount, err, Kljucevi.ReqiredValue)
                && Validator.ProvjeriUnos(txtDesc, err, Kljucevi.ReqiredValue); 
        }
    }
}
