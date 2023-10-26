using MySqlConnector;

namespace bd
{
    class DB
    {
       // подключение к бд
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=itproger");
        
        // Открытие соединения с БД
        public void openConnection()
        {
             if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Закрытие соединения с БД
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Возвращение соединения
        public MySqlConnection getConnection()
        {
            return connection;
        }

    }

}
