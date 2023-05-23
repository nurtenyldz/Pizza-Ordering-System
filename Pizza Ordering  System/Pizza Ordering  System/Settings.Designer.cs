namespace Pizza_Ordering__System
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            PizzaCb = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            PriceTb = new TextBox();
            SubmitBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            BackLbl = new Label();
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
            panel1.Size = new Size(62, 623);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(205, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 2;
            label1.Text = "Pizza Ordering System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(264, 60);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 3;
            label2.Text = "Settings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(515, 9);
            label4.Name = "label4";
            label4.Size = new Size(24, 27);
            label4.TabIndex = 9;
            label4.Text = "X";
            // 
            // PizzaCb
            // 
            PizzaCb.FormattingEnabled = true;
            PizzaCb.Items.AddRange(new object[] { "Extra Large", "Large", "Medium", "Small" });
            PizzaCb.Location = new Point(148, 207);
            PizzaCb.Name = "PizzaCb";
            PizzaCb.Size = new Size(298, 30);
            PizzaCb.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(148, 171);
            label3.Name = "label3";
            label3.Size = new Size(149, 24);
            label3.TabIndex = 11;
            label3.Text = "Select The Pizza";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(148, 263);
            label5.Name = "label5";
            label5.Size = new Size(139, 24);
            label5.TabIndex = 12;
            label5.Text = "Enter The Price";
            // 
            // PriceTb
            // 
            PriceTb.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTb.Location = new Point(148, 299);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(298, 30);
            PriceTb.TabIndex = 13;
            // 
            // SubmitBtn
            // 
            SubmitBtn.ActiveBorderThickness = 1;
            SubmitBtn.ActiveCornerRadius = 20;
            SubmitBtn.ActiveFillColor = Color.SeaGreen;
            SubmitBtn.ActiveForecolor = Color.White;
            SubmitBtn.ActiveLineColor = Color.SeaGreen;
            SubmitBtn.BackColor = Color.White;
            SubmitBtn.BackgroundImage = (Image)resources.GetObject("SubmitBtn.BackgroundImage");
            SubmitBtn.ButtonText = "Submit";
            SubmitBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitBtn.ForeColor = Color.SeaGreen;
            SubmitBtn.IdleBorderThickness = 1;
            SubmitBtn.IdleCornerRadius = 20;
            SubmitBtn.IdleFillColor = Color.OrangeRed;
            SubmitBtn.IdleForecolor = Color.White;
            SubmitBtn.IdleLineColor = Color.OrangeRed;
            SubmitBtn.Location = new Point(205, 401);
            SubmitBtn.Margin = new Padding(5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(181, 41);
            SubmitBtn.TabIndex = 14;
            SubmitBtn.TextAlign = ContentAlignment.MiddleCenter;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // BackLbl
            // 
            BackLbl.AutoSize = true;
            BackLbl.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            BackLbl.ForeColor = Color.OrangeRed;
            BackLbl.Location = new Point(247, 540);
            BackLbl.Name = "BackLbl";
            BackLbl.Size = new Size(50, 24);
            BackLbl.TabIndex = 15;
            BackLbl.Text = "Back";
            BackLbl.Click += label6_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 623);
            Controls.Add(BackLbl);
            Controls.Add(SubmitBtn);
            Controls.Add(PriceTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(PizzaCb);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private ComboBox PizzaCb;
        private TextBox PriceTb;
        private Label BackLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 SubmitBtn;
    }
}