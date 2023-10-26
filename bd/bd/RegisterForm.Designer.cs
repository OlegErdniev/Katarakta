namespace bd
{
    partial class RegisterForm
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
            label1 = new Label();
            MainPanel = new Panel();
            loginLabel = new Label();
            userSurnameField = new TextBox();
            userNameField = new TextBox();
            buttonRegister = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(586, 100);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(64, 0, 0);
            MainPanel.Controls.Add(loginLabel);
            MainPanel.Controls.Add(userSurnameField);
            MainPanel.Controls.Add(userNameField);
            MainPanel.Controls.Add(buttonRegister);
            MainPanel.Controls.Add(passField);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(loginField);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(panel2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(586, 635);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Cursor = Cursors.Hand;
            loginLabel.ForeColor = SystemColors.Control;
            loginLabel.Location = new Point(254, 542);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(105, 15);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Уже есть аккаунт?";
            loginLabel.Click += loginLabel_Click;
            // 
            // userSurnameField
            // 
            userSurnameField.Cursor = Cursors.IBeam;
            userSurnameField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            userSurnameField.Location = new Point(152, 199);
            userSurnameField.Multiline = true;
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(300, 64);
            userSurnameField.TabIndex = 7;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Cursor = Cursors.IBeam;
            userNameField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            userNameField.Location = new Point(152, 129);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(300, 64);
            userNameField.TabIndex = 6;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.Green;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            buttonRegister.FlatAppearance.MouseOverBackColor = Color.Olive;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.ForeColor = SystemColors.ControlLightLight;
            buttonRegister.Location = new Point(200, 499);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(220, 40);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Cursor = Cursors.IBeam;
            passField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(152, 339);
            passField.Name = "passField";
            passField.Size = new Size(300, 48);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(82, 339);
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
            loginField.Location = new Point(152, 269);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(300, 64);
            loginField.TabIndex = 2;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(82, 269);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 100);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(550, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "Х";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 635);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel MainPanel;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private Button buttonRegister;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label closeButton;
        private Label loginLabel;
    }
}