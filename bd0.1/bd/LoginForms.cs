using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


            //Получение данных от пользователя
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Команда SQL
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", db.getConnection());
            // Указание переменных вместо заглушек
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            // Выбор нужной команды и ее выполнение
            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка данных пользователя
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm= new MainForm();
                mainForm.Show();
                
            }
            else
            {
                MessageBox.Show("Не Куку");
            }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
