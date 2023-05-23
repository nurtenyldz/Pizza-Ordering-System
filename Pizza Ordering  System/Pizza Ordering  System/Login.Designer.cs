namespace Pizza_Ordering__System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            UnameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 524);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(369, 31);
            label1.Name = "label1";
            label1.Size = new Size(250, 29);
            label1.TabIndex = 1;
            label1.Text = "Pizza Ordering System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(416, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 83);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UnameTb.Location = new Point(321, 218);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(271, 35);
            UnameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 183);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 4;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 258);
            label3.Name = "label3";
            label3.Size = new Size(94, 26);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.Location = new Point(321, 293);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(271, 35);
            PasswordTb.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.ActiveBorderThickness = 1;
            LoginBtn.ActiveCornerRadius = 20;
            LoginBtn.ActiveFillColor = Color.SeaGreen;
            LoginBtn.ActiveForecolor = Color.White;
            LoginBtn.ActiveLineColor = Color.SeaGreen;
            LoginBtn.BackColor = Color.White;
            LoginBtn.BackgroundImage = (Image)resources.GetObject("LoginBtn.BackgroundImage");
            LoginBtn.ButtonText = "Login";
            LoginBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.SeaGreen;
            LoginBtn.IdleBorderThickness = 1;
            LoginBtn.IdleCornerRadius = 20;
            LoginBtn.IdleFillColor = Color.OrangeRed;
            LoginBtn.IdleForecolor = Color.White;
            LoginBtn.IdleLineColor = Color.OrangeRed;
            LoginBtn.Location = new Point(369, 350);
            LoginBtn.Margin = new Padding(5);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(181, 41);
            LoginBtn.TabIndex = 7;
            LoginBtn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(663, 25);
            label4.Name = "label4";
            label4.Size = new Size(30, 35);
            label4.TabIndex = 10;
            label4.Text = "X";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(719, 524);
            Controls.Add(label4);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(UnameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label3;
        private TextBox PasswordTb;
        private Label label2;
        private TextBox UnameTb;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private Label label4;
    }
}