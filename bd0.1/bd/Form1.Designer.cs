namespace bd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg2 = new PictureBox();
            labelCoin = new Label();
            coin = new PictureBox();
            buttonRestart = new Button();
            labelLose = new Label();
            player = new PictureBox();
            bg1 = new PictureBox();
            enemy2 = new PictureBox();
            enemy1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            SuspendLayout();
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(-13, -637);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 5;
            bg2.TabStop = false;
            // 
            // labelCoin
            // 
            labelCoin.AutoSize = true;
            labelCoin.BackColor = Color.FromArgb(64, 64, 64);
            labelCoin.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            labelCoin.ForeColor = SystemColors.ControlLightLight;
            labelCoin.Location = new Point(-8, -10);
            labelCoin.Name = "labelCoin";
            labelCoin.Size = new Size(118, 25);
            labelCoin.TabIndex = 16;
            labelCoin.Text = "Монеты: 0";
            // 
            // coin
            // 
            coin.BackColor = Color.FromArgb(64, 64, 64);
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(253, 384);
            coin.Name = "coin";
            coin.Size = new Size(64, 64);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 15;
            coin.TabStop = false;
            // 
            // buttonRestart
            // 
            buttonRestart.BackColor = Color.Maroon;
            buttonRestart.FlatStyle = FlatStyle.Popup;
            buttonRestart.Font = new Font("Book Antiqua", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRestart.ForeColor = SystemColors.ControlLightLight;
            buttonRestart.Location = new Point(332, 237);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(177, 54);
            buttonRestart.TabIndex = 14;
            buttonRestart.Text = "Перезапуск";
            buttonRestart.UseVisualStyleBackColor = false;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Red;
            labelLose.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            labelLose.ForeColor = SystemColors.ControlLightLight;
            labelLose.Location = new Point(311, 190);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(211, 32);
            labelLose.TabIndex = 13;
            labelLose.Text = "Вы проиграли";
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(409, 494);
            player.Name = "player";
            player.Size = new Size(100, 100);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 12;
            player.TabStop = false;
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(-8, -20);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 11;
            bg1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.FromArgb(64, 64, 64);
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(543, -336);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(100, 100);
            enemy2.SizeMode = PictureBoxSizeMode.CenterImage;
            enemy2.TabIndex = 18;
            enemy2.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.FromArgb(64, 64, 64);
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(182, -175);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(100, 100);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 17;
            enemy1.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 611);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(labelCoin);
            Controls.Add(coin);
            Controls.Add(buttonRestart);
            Controls.Add(labelLose);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg2;
        private Label labelCoin;
        private PictureBox coin;
        private Button buttonRestart;
        private Label labelLose;
        private PictureBox player;
        private PictureBox bg1;
        private PictureBox enemy2;
        private PictureBox enemy1;
        private System.Windows.Forms.Timer timer;
    }
}