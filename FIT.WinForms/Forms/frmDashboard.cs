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
    }
}
