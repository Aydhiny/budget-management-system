namespace BUDGET.WinForms.Forms
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            dgvBudget = new DataGridView();
            CategoryName = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            btnExpense = new Button();
            btnCategory = new Button();
            lblWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            SuspendLayout();
            // 
            // dgvBudget
            // 
            dgvBudget.AllowUserToAddRows = false;
            dgvBudget.AllowUserToDeleteRows = false;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Columns.AddRange(new DataGridViewColumn[] { CategoryName, Amount, Description, Date, Delete });
            dgvBudget.Location = new Point(12, 82);
            dgvBudget.Name = "dgvBudget";
            dgvBudget.ReadOnly = true;
            dgvBudget.RowHeadersWidth = 51;
            dgvBudget.RowTemplate.Height = 29;
            dgvBudget.Size = new Size(852, 374);
            dgvBudget.TabIndex = 0;
            dgvBudget.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DataPropertyName = "CategoryName";
            CategoryName.HeaderText = "Category";
            CategoryName.MinimumWidth = 6;
            CategoryName.Name = "CategoryName";
            CategoryName.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "Your Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 2;
            label2.Text = "Your budget information is available on this table:";
            // 
            // btnExpense
            // 
            btnExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExpense.ForeColor = Color.FromArgb(56, 124, 188);
            btnExpense.Location = new Point(574, 31);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(141, 39);
            btnExpense.TabIndex = 3;
            btnExpense.Text = "Add expense";
            btnExpense.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(56, 124, 188);
            btnCategory.ForeColor = SystemColors.ButtonFace;
            btnCategory.Location = new Point(721, 31);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(143, 39);
            btnCategory.TabIndex = 4;
            btnCategory.Text = "Add category";
            btnCategory.UseVisualStyleBackColor = false;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(12, 469);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 20);
            lblWarning.TabIndex = 5;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 558);
            Controls.Add(lblWarning);
            Controls.Add(btnCategory);
            Controls.Add(btnExpense);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvBudget);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDashboard";
            Text = "Budget Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBudget;
        private Label label1;
        private Label label2;
        private Button btnExpense;
        private Button btnCategory;
        private Label lblWarning;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewButtonColumn Delete;
    }
}