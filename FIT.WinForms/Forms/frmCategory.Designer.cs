namespace BUDGET.WinForms.Forms
{
    partial class frmCategory
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBudget = new TextBox();
            btnExpense = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Category Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 27);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(56, 124, 188);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(256, 32);
            label2.TabIndex = 2;
            label2.Text = "Create New Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 0;
            label3.Text = "Budget amount:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(12, 140);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(256, 27);
            txtBudget.TabIndex = 1;
            txtBudget.KeyPress += txtBudget_KeyPress;
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.FromArgb(56, 124, 188);
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExpense.ForeColor = Color.White;
            btnExpense.Location = new Point(12, 173);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(256, 39);
            btnExpense.TabIndex = 4;
            btnExpense.Text = "Add category";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 232);
            Controls.Add(btnExpense);
            Controls.Add(label2);
            Controls.Add(txtBudget);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "frmCategory";
            Text = "Category Creator";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtBudget;
        private Button btnExpense;
        private ErrorProvider err;
    }
}