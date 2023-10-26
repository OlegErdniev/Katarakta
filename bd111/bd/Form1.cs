using System.Numerics;
using System.Security.AccessControl;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace bd
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, lose = false;

        private int countcoins = 0;


        public Form1()
        {
            InitializeComponent();

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            labelLose.Visible = false;
            buttonRestart.Visible = false;
            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int speed = 8;
            bg1.Top += speed;
            bg2.Top += speed;
            coin.Top += speed;

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }


            int carSpeed = 5;
            enemy1.Top += carSpeed;
            enemy2.Top += carSpeed;

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg1.Top = -650;
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -150;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);

            }
            if (enemy2.Top >= 650)
            {
                enemy2.Top = -311;
                Random rand = new Random();
                enemy2.Left = rand.Next(300, 560);
            }



            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                buttonRestart.Visible = true;
                lose = true;
            }

            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countcoins++;
                labelCoin.Text = "Монеты: " + countcoins.ToString();
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int speed = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 150)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
                player.Left += speed;
            if (lose == true)
            {
                return;
            }
        }

        private void labelLose_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            labelLose.Visible = false;
            buttonRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countcoins = 0;
            labelCoin.Text = "Монеты: 0";
            coin.Top = -500;

        }

        private void coin_Click(object sender, EventArgs e)
        {

        }

        private void bg2_Click(object sender, EventArgs e)
        {

        }

        private void labelCoin_Click(object sender, EventArgs e)
        {
        }

        private void player_Click(object sender, EventArgs e)
        {
        }

        private void bg2_Click_1(object sender, EventArgs e)
        {
        }

        private void player_Click_1(object sender, EventArgs e)
        {
        }

        private void bg1_Click(object sender, EventArgs e)
        {

        }

        private void labelCoin_Click_1(object sender, EventArgs e)
        {
        }
    }

}