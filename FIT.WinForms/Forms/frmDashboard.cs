using BUDGET.Data;
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
        private Func<User> first;

        public frmDashboard()
        {
            InitializeComponent();
        }

        public frmDashboard(Func<User> first)
        {
            this.first = first;
        }
    }
}
