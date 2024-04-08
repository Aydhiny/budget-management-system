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
            LoadChart();
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
                        chart.Series.Add(new MindFusion.Charting.Series3D(new double[] { totalAmount }, new double[] { 0 }, new double[] { 0 }, new string[] { category.CategoryName }));
                    }
                }

                chart.XAxis.Title = "Categories";
                chart.YAxis.Title = "Total Expense Amount ($)";
                chart.ShowLegend = true;
                chart.LegendTitle = "Categories";

                // Add the chart to the barChart3d1 control
                barChart3d1.Controls.Clear();
                barChart3d1.Controls.Add(chart);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            UcitajTabelu();
        }

        private void UcitajTabelu()
        {
            var user = db.Users.Where(x => x.UserId == userId).First();
            var expense = db.Expenses.Where(x => x.UserId == user.UserId).ToList();

            var tabela = new DataTable();
            tabela.Columns.Add("Date");
            tabela.Columns.Add("Amount");
            tabela.Columns.Add("Description");
            tabela.Columns.Add("CategoryName");

            if (expense.Count > 0)
            {
                foreach (var ex in expense)
                {
                    var Red = tabela.NewRow();
                    var category = db.BudgetCategories.Where(x => x.CategoryId == ex.CategoryId).First();
                    Red["Date"] = ex.Date;
                    Red["Amount"] = ex.Amount + " $";
                    Red["Description"] = ex.Description;
                    Red["CategoryName"] = category.ToString();
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

        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
        }
    }
}
