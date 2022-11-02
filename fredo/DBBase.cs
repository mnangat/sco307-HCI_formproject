using Devart.Data.MySql;

namespace fredo
{
    internal class DBBase
    {
        string port = "3306";
        string server = "localhost";
        string userID= "root";
        //string password = "6042";
        string database = "mysqlfredo";


        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; userID=root; database=mysqlfredo");

        public void OpenConnection()
        {

            if (connection.State == System.Data.ConnectionState.Closed)


            {
                connection.Open();



            }

        }

        public void Openconnection()
        {

            if (connection.State == System.Data.ConnectionState.Open)


            {
                connection.Close();



            }

        }
    }
}