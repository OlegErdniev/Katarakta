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
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
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
            player.Location = new Point(420, 510);
            player.Name = "player";
            player.Size = new Size(128, 128);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 3;
            player.TabStop = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(840, 650);
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
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bg1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer;
        private PictureBox bg2;
    }
}