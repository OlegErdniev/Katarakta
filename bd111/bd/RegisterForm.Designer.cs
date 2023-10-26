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
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Controls.Add(this.userSurnameField);
            this.MainPanel.Controls.Add(this.userNameField);
            this.MainPanel.Controls.Add(this.buttonRegister);
            this.MainPanel.Controls.Add(this.passField);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.loginField);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(586, 635);
            this.MainPanel.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Location = new System.Drawing.Point(254, 542);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(105, 15);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Уже есть аккаунт?";
            // 
            // userSurnameField
            // 
            this.userSurnameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userSurnameField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSurnameField.Location = new System.Drawing.Point(152, 199);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(300, 64);
            this.userSurnameField.TabIndex = 7;
            // 
            // userNameField
            // 
            this.userNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameField.Location = new System.Drawing.Point(152, 129);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(300, 64);
            this.userNameField.TabIndex = 6;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Green;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegister.Location = new System.Drawing.Point(200, 499);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(220, 40);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            this.passField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.Location = new System.Drawing.Point(152, 339);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(300, 48);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bd.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(82, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginField.Location = new System.Drawing.Point(152, 269);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(300, 64);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bd.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(82, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(550, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Х";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 635);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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