namespace bd
{
    public partial class LoginForms : Form
    {
        public LoginForms()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Width, 64);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        // Навел курсор на кнопку close  
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        // Убрал курсор с кнопки close
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        // Прикол для перемещения окна (Зажал и передвинул)
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // если зажата ЛКМ, то можно переместить окно в другое место
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        // Прикол для перемещения окна (Отжал)
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Нажатие на кнопку "Войти"
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
