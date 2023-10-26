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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelinstrucktion = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPanel.Controls.Add(this.labelinstrucktion);
            this.MainPanel.Controls.Add(this.registerLabel);
            this.MainPanel.Controls.Add(this.buttonLogin);
            this.MainPanel.Controls.Add(this.passField);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.loginField);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(390, 421);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.registerLabel.Location = new System.Drawing.Point(101, 373);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(86, 15);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "Нет аккаунта?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(125, 330);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(149, 40);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            this.passField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passField.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passField.Location = new System.Drawing.Point(91, 187);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(243, 48);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bd.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(21, 187);
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
            this.loginField.Location = new System.Drawing.Point(91, 117);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(243, 64);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bd.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(21, 117);
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
            this.panel2.Size = new System.Drawing.Size(390, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(360, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Х";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelinstrucktion
            // 
            this.labelinstrucktion.AutoSize = true;
            this.labelinstrucktion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelinstrucktion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelinstrucktion.Location = new System.Drawing.Point(218, 373);
            this.labelinstrucktion.Name = "labelinstrucktion";
            this.labelinstrucktion.Size = new System.Drawing.Size(77, 15);
            this.labelinstrucktion.TabIndex = 7;
            this.labelinstrucktion.Text = "Инструкция";
            this.labelinstrucktion.Click += new System.EventHandler(this.labelinstrucktion_Click);
            // 
            // LoginForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 421);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForms";
            this.Text = "LoginForms";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Label labelinstrucktion;
    }
}