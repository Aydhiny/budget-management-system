namespace BUDGET.WinForms.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnLogin = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-15, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 459);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(56, 124, 188);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 1;
            label1.Text = "Login to your account";
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.BackColor = Color.FromArgb(56, 124, 188);
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuBar;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(6, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "  Username...";
            txtUsername.Size = new Size(457, 16);
            txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(56, 124, 188);
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 178);
            label2.Name = "label2";
            label2.Size = new Size(237, 93);
            label2.TabIndex = 4;
            label2.Text = "Welcome to the \r\nBudget Management \r\nSystem";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Location = new Point(280, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 285);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Budget : v1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.HighlightText;
            label3.Font = new Font("Segoe UI", 9F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 82);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Your Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 147);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  example123...";
            textBox1.Size = new Size(457, 16);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 129);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HighlightText;
            label5.Font = new Font("Segoe UI", 9F);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(313, 411);
            label5.Name = "label5";
            label5.Size = new Size(316, 30);
            label5.TabIndex = 9;
            label5.Text = "To obtain access to this App or have any questions about it\r\nsubmit your email message to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLightLight;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label6.ForeColor = Color.FromArgb(56, 124, 188);
            label6.Location = new Point(484, 426);
            label6.Name = "label6";
            label6.Size = new Size(201, 15);
            label6.TabIndex = 10;
            label6.Text = "ajdinmehmedovic18875@gmail.com";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(56, 124, 188);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(33, 232);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(104, 37);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(56, 124, 188);
            button1.Location = new Point(153, 232);
            button1.Name = "button1";
            button1.Size = new Size(134, 37);
            button1.TabIndex = 12;
            button1.Text = "Forgot password ?";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(761, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            Text = "Budget Manager :: Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnLogin;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}