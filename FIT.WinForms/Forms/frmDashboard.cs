using BUDGET.Data;
using FIT.Infrastructure;
using MindFusion.Charting.WinForms;
using MindFusion.Charting;
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
    public partial class frmDashboard : Form
    {
        BUDGETDbContext db = new BUDGETDbContext();
        private int userId;

        public frmDashboard(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            dgvBudget.AutoGenerateColumns = false;
            UcitajTabelu();
            LoadLabels();
            LoadChart();
        }

        private void LoadLabels()
        {
            lblTotal.Text = db.Expenses.Where(x => x.UserId == userId).Sum(x => x.Amount).ToString();
            lblCategories.Text = db.BudgetCategories.Count().ToString();
            lblUsers.Text = db.Users.Count().ToString();
        }

        private void LoadChart()
        {
            var user = db.Users.FirstOrDefault(x => x.UserId == userId);
            if (user != null)
            {
                var expensesByCategory = db.Expenses
                    .Where(x => x.UserId == user.UserId)
                    .GroupBy(x => x.CategoryId)
                    .Select(g => new
                    {
                        CategoryId = g.Key,
                        TotalAmount = g.Sum(x => x.Amount)
                    })
                    .ToList();

                var chart = new BarChart3D();
                chart.Dock = DockStyle.Fill;

                foreach (var expense in expensesByCategory)
                {
                    var category = db.BudgetCategories.FirstOrDefault(x => x.CategoryId == expense.CategoryId);
                    if (category != null)
                    {
                        double totalAmount = Convert.ToDouble(expense.TotalAmount);
                        chart.Series.Add(new MindFusion.Charting.Series3D(new double[] { totalAmount },
                            new double[] { 0 }, new double[] { 0 },
                            new string[] { category.CategoryName }));
                    }
                }

                chart.XAxis.Title = "Categories";
                chart.YAxis.Title = "Total Expense Amount ($)";
                chart.ShowLegend = true;
                chart.LegendTitle = "Categories";

                barChart3d1.Controls.Clear();
                barChart3d1.Controls.Add(chart);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBudget.ColumnCount - 1)
            {
                var expenseIdCell = dgvBudget.Rows[e.RowIndex].Cells["ExpenseId"];
                if (expenseIdCell.Value != null)
                {
                    if (int.TryParse(expenseIdCell.Value.ToString(), out int expenseId))
                    {
                        var result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            var deletedExpense = db.Expenses.FirstOrDefault(x => x.ExpenseId == expenseId);

                            if (deletedExpense != null)
                            {
                                db.Expenses.Remove(deletedExpense);
                                db.SaveChanges();
                                UcitajTabelu();
                                LoadChart();
                                LoadLabels();
                            }
                            else
                            {
                                MessageBox.Show("Expense with ID " + expenseId + " does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid expense ID: " + expenseIdCell.Value.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Expense ID is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            UcitajTabelu();
            LoadChart();
            LoadLabels();
        }

        private void UcitajTabelu()
        {
            var user = db.Users.Where(x => x.UserId == userId).First();
            var expense = db.Expenses.Where(x => x.UserId == user.UserId).ToList();

            var tabela = new DataTable();
            tabela.Columns.Add("ExpenseId");
            tabela.Columns.Add("Date");
            tabela.Columns.Add("Amount");
            tabela.Columns.Add("Description");
            tabela.Columns.Add("CategoryName");

            if (expense.Count > 0)
            {
                foreach (var ex in expense)
                {
                    var Red = tabela.NewRow();
                    var category = db.BudgetCategories.Where(x => x.CategoryId == ex.CategoryId).ToList();
                    Red["ExpenseId"] = ex.ExpenseId;
                    Red["Date"] = ex.Date;
                    Red["Amount"] = ex.Amount + " $";
                    Red["Description"] = ex.Description;
                    Red["CategoryName"] = category.FirstOrDefault()?.CategoryName;
                    tabela.Rows.Add(Red);
                }
            }

            dgvBudget.DataSource = null;
            dgvBudget.DataSource = tabela;

            ProvjeriTabelu();
        }

        private void ProvjeriTabelu()
        {
            if (dgvBudget.DataSource == null)
            {
                lblWarning.Text = "UPOZORENJE, Expenses nisu dodani!";
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var frm = new frmCategory();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                LoadChart();
                LoadLabels();
                UcitajTabelu();
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            var frm = new frmExpense(userId);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UcitajTabelu();
                LoadChart();
                LoadLabels();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var frm = new frmDelete();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                UcitajTabelu();
                LoadChart();
                LoadLabels();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var pass = txtPassword.Text;

            // Check if either email or password is provided
            if (!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(pass))
            {
                // Find the user by userId
                var user = db.Users.FirstOrDefault(x => x.UserId == userId);

                // Update the user's email if provided
                if (!string.IsNullOrEmpty(email))
                {
                    user.Email = email;
                }

                // Update the user's password if provided
                if (!string.IsNullOrEmpty(pass))
                {
                    user.Password = pass;
                }

                try
                {
                    // Save changes to the database
                    db.SaveChanges();

                    // Show a success message
                    MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the table, chart, and labels
                    UcitajTabelu();
                    LoadChart();
                    LoadLabels();
                }
                catch (Exception ex)
                {
                    // Show an error message if something goes wrong
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Show a warning message if both email and password are empty
                MessageBox.Show("Please enter either email or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
