using BUDGET.Data;
using FIT.Infrastructure;
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
    public partial class frmDelete : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        public frmDelete()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            cmbDelete.DataSource = db.BudgetCategories.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDelete.SelectedItem == null)
            {
                MessageBox.Show("Please select a budget category to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected budget category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    BudgetCategory selectedCategory = cmbDelete.SelectedItem as BudgetCategory;

                    if (selectedCategory != null)
                    {
                        db.BudgetCategories.Remove(selectedCategory);
                        db.SaveChanges();
                        MessageBox.Show("Budget category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbDelete.DataSource = db.BudgetCategories.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Invalid budget category selection. Please select a valid category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the budget category. Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
