using Devart.Data.MySql;

namespace fredo
{
    internal class DBBase1
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=6042; database=mysqlfredo");

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