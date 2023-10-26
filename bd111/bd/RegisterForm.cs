using MySqlConnector;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;

            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;




        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }

        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;


            }

        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;





            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Ведите имя");
                return;
            }

            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Ведите фамилию");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Ведите пароль");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("Ведите логин");
                return;
            }

            if (isUserExist())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }

            db.closeConnection();

        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            // Команда SQL
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());
            // Указание переменных вместо заглушек
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;


            // Выбор нужной команды и ее выполнение
            adapter.SelectCommand = command;
            adapter.Fill(table);

            //Проверка данных пользователя
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForms loginForms = new LoginForms();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
