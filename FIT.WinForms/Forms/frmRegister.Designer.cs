namespace BUDGET.WinForms.Forms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            btnGenerate = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(56, 124, 188);
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.ForeColor = SystemColors.Desktop;
            txtName.Location = new Point(14, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Your username:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ButtonFace;
            txtEmail.ForeColor = SystemColors.Desktop;
            txtEmail.Location = new Point(14, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 27);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 111);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Your email:";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ButtonFace;
            txtPass.ForeColor = SystemColors.Desktop;
            txtPass.Location = new Point(14, 187);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(204, 27);
            txtPass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 164);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 2;
            label4.Text = "Your password:";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.White;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.FromArgb(56, 124, 188);
            btnGenerate.Location = new Point(224, 187);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(83, 27);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(56, 124, 188);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(14, 221);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 49);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 299);
            panel1.TabIndex = 15;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(718, 328);
            Controls.Add(panel1);
            Name = "frmRegister";
            Text = "Register :: Budget";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPass;
        private Label label4;
        private Button btnGenerate;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ErrorProvider err;
    }
}