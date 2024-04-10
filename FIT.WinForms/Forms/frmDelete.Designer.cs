namespace BUDGET.WinForms.Forms
{
    partial class frmDelete
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
            btnDelete = new Button();
            cmbDelete = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.OrangeRed;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(11, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete category";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbDelete
            // 
            cmbDelete.FormattingEnabled = true;
            cmbDelete.Location = new Point(11, 87);
            cmbDelete.Name = "cmbDelete";
            cmbDelete.Size = new Size(225, 28);
            cmbDelete.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(56, 124, 188);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 32);
            label6.TabIndex = 9;
            label6.Text = "Delete category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 64);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 10;
            label5.Text = "Select category to delete:";
            // 
            // frmDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 173);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cmbDelete);
            Controls.Add(btnDelete);
            Name = "frmDelete";
            Text = "Delete Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private ComboBox cmbDelete;
        private Label label6;
        private Label label5;
    }
}