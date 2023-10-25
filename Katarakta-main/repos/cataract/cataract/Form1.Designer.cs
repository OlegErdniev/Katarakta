namespace cataract
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            player = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            bg2 = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            labelLose = new Label();
            buttonRestart = new Button();
            coin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(0, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            bg1.Click += pictureBox1_Click;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(417, 513);
            player.Name = "player";
            player.Size = new Size(100, 100);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 3;
            player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            timer.Tick += timer1_Tick;
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 4;
            bg2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.FromArgb(64, 64, 64);
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(178, -150);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(100, 100);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 5;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.FromArgb(64, 64, 64);
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(539, -311);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(100, 100);
            enemy2.SizeMode = PictureBoxSizeMode.CenterImage;
            enemy2.TabIndex = 6;
            enemy2.TabStop = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Red;
            labelLose.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            labelLose.ForeColor = SystemColors.ControlLightLight;
            labelLose.Location = new Point(319, 209);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(211, 32);
            labelLose.TabIndex = 7;
            labelLose.Text = "Вы проиграли";
            labelLose.Click += labelLose_Click;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.Maroon;
            buttonRestart.FlatStyle = FlatStyle.Popup;
            buttonRestart.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRestart.ForeColor = SystemColors.ControlLightLight;
            buttonRestart.Location = new Point(340, 256);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(177, 54);
            buttonRestart.TabIndex = 8;
            buttonRestart.Text = "Перезапуск";
            buttonRestart.UseVisualStyleBackColor = false;
            buttonRestart.Click += buttonRestart_Click;
            // 
            // coin
            // 
            coin.BackColor = Color.FromArgb(64, 64, 64);
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(391, -550);
            coin.Name = "coin";
            coin.Size = new Size(64, 64);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 9;
            coin.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(840, 650);
            Controls.Add(coin);
            Controls.Add(buttonRestart);
            Controls.Add(labelLose);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer;
        private PictureBox bg2;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private Label labelLose;
        private Button buttonRestart;
        private PictureBox coin;
    }
}