namespace BUDGET.WinForms.Forms
{
    partial class frmExpense
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
            components = new System.ComponentModel.Container();
            btnExpense = new Button();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            cmbCategories = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtAmount = new TextBox();
            err = new ErrorProvider(components);
            dtpDate = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.FromArgb(56, 124, 188);
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(12, 262);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(308, 39);
            btnExpense.TabIndex = 10;
            btnExpense.Text = "Add expense";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 124, 188);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 9;
            label2.Text = "Add expenses";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 140);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(308, 27);
            txtDesc.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(12, 86);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(151, 28);
            cmbCategories.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 64);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(169, 87);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 7;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(12, 216);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(308, 27);
            dtpDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 193);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 6;
            label6.Text = "Date added:";
            // 
            // frmExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 321);
            Controls.Add(dtpDate);
            Controls.Add(cmbCategories);
            Controls.Add(btnExpense);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(label5);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Name = "frmExpense";
            Text = "Add new expense";
            Load += frmExpense_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExpense;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private ComboBox cmbCategories;
        private Label label4;
        private Label label5;
        private TextBox txtAmount;
        private ErrorProvider err;
        private DateTimePicker dtpDate;
        private Label label6;
    }
}