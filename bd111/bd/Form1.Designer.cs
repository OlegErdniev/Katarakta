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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.labelCoin = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelLose = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(-13, -637);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 667);
            this.bg2.TabIndex = 5;
            this.bg2.TabStop = false;
            // 
            // labelCoin
            // 
            this.labelCoin.AutoSize = true;
            this.labelCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCoin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCoin.Location = new System.Drawing.Point(0, 9);
            this.labelCoin.Name = "labelCoin";
            this.labelCoin.Size = new System.Drawing.Size(118, 25);
            this.labelCoin.TabIndex = 16;
            this.labelCoin.Text = "Монеты: 0";
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(389, -343);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(64, 64);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 15;
            this.coin.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Maroon;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRestart.Location = new System.Drawing.Point(332, 237);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(177, 54);
            this.buttonRestart.TabIndex = 14;
            this.buttonRestart.Text = "Перезапуск";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Red;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLose.Location = new System.Drawing.Point(311, 190);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(211, 32);
            this.labelLose.TabIndex = 13;
            this.labelLose.Text = "Вы проиграли";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(409, 494);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            // 
            // bg1
            // 
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(-13, 12);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 650);
            this.bg1.TabIndex = 11;
            this.bg1.TabStop = false;
            this.bg1.Click += new System.EventHandler(this.bg1_Click);
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(543, -336);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(100, 100);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.enemy2.TabIndex = 18;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(182, -175);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(100, 100);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 17;
            this.enemy1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.labelCoin);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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