namespace bd
{
    partial class LoginForms
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
            MainPanel = new Panel();
            registerLabel = new Label();
            buttonLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            closeButton = new Label();
            panel2 = new Panel();
            label1 = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(64, 0, 0);
            MainPanel.Controls.Add(registerLabel);
            MainPanel.Controls.Add(buttonLogin);
            MainPanel.Controls.Add(passField);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(loginField);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(390, 421);
            MainPanel.TabIndex = 0;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerLabel.ForeColor = SystemColors.Control;
            registerLabel.Location = new Point(157, 373);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(86, 15);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "Нет аккаунта?";
            registerLabel.Click += registerLabel_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Green;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonLogin.FlatAppearance.MouseOverBackColor = Color.Olive;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(125, 330);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(149, 40);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Cursor = Cursors.IBeam;
            passField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(91, 187);
            passField.Name = "passField";
            passField.Size = new Size(243, 48);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.TextChanged += passField_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(21, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Cursor = Cursors.IBeam;
            loginField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(91, 117);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(243, 64);
            loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(21, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(360, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "Х";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 100);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 421);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForms";
            Text = "LoginForms";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private PictureBox pictureBox1;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button buttonLogin;
        private Label registerLabel;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
    }
}