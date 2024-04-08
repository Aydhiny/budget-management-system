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
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            barChart3d1 = new MindFusion.Charting.WinForms.BarChart3D();
            label4 = new Label();
            tabPage3 = new TabPage();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBudget
            // 
            dgvBudget.AllowUserToAddRows = false;
            dgvBudget.AllowUserToDeleteRows = false;
            dgvBudget.BackgroundColor = SystemColors.Highlight;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Columns.AddRange(new DataGridViewColumn[] { CategoryName, Amount, Description, Date, Delete });
            dgvBudget.Location = new Point(6, 68);
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
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 124, 188);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 1;
            label1.Text = "Your Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(339, 20);
            label2.TabIndex = 2;
            label2.Text = "Your budget information is available on this table:";
            // 
            // btnExpense
            // 
            btnExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExpense.ForeColor = Color.FromArgb(56, 124, 188);
            btnExpense.Location = new Point(568, 16);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(141, 39);
            btnExpense.TabIndex = 3;
            btnExpense.Text = "Add expense";
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.FromArgb(56, 124, 188);
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = SystemColors.ButtonFace;
            btnCategory.Location = new Point(715, 16);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(143, 39);
            btnCategory.TabIndex = 4;
            btnCategory.Text = "Add category";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = Color.Red;
            lblWarning.Location = new Point(551, 465);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 20);
            lblWarning.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 512);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 6;
            label3.Text = "Copyright @Ajdin Mehmedović";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 14);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(876, 486);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnCategory);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnExpense);
            tabPage1.Controls.Add(dgvBudget);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Your Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(barChart3d1);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 453);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Budget Charts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // barChart3d1
            // 
            barChart3d1.LegendTitle = "Legend";
            barChart3d1.Location = new Point(6, 60);
            barChart3d1.Name = "barChart3d1";
            barChart3d1.Padding = new Padding(5);
            barChart3d1.ShowLegend = true;
            barChart3d1.Size = new Size(856, 433);
            barChart3d1.SubtitleFontName = null;
            barChart3d1.SubtitleFontSize = null;
            barChart3d1.SubtitleFontStyle = null;
            barChart3d1.TabIndex = 2;
            barChart3d1.Text = "barChart3d1";
            barChart3d1.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
            barChart3d1.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
            barChart3d1.Theme.UniformSeriesStrokeThickness = 2D;
            barChart3d1.TitleFontName = null;
            barChart3d1.TitleFontSize = null;
            barChart3d1.TitleFontStyle = null;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(56, 124, 188);
            label4.Location = new Point(6, 15);
            label4.Name = "label4";
            label4.Size = new Size(178, 32);
            label4.TabIndex = 1;
            label4.Text = "Your expenses";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pictureBox1);
            tabPage3.Controls.Add(btnSave);
            tabPage3.Controls.Add(txtEmail);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtPassword);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(868, 453);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 65);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 0;
            label5.Text = "Change password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(56, 124, 188);
            label6.Location = new Point(6, 14);
            label6.Name = "label6";
            label6.Size = new Size(162, 32);
            label6.TabIndex = 2;
            label6.Text = "User settings";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 27);
            txtPassword.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 118);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 4;
            label7.Text = "Change email adress:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(6, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 27);
            txtEmail.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(56, 124, 188);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(6, 174);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(689, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(903, 543);
            Controls.Add(tabControl1);
            Controls.Add(label3);
            Controls.Add(lblWarning);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDashboard";
            Text = "Budget Dashboard";
            Load += frmDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private MindFusion.Charting.WinForms.BarChart3D barChart3d1;
        private TabPage tabPage3;
        private Button btnSave;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtPassword;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
    }
}