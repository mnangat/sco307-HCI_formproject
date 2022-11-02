using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Devart.Data.MySql;
using Microsoft.AspNet.SignalR.Infrastructure;

namespace fredo
{


    class DB
    {
        private readonly MySqlConnection connection = new MySqlConnection("server=localhost; port=3306;  password=6042; database=mysqlfredo");

        public void OpenConnection()
        {

            if (connection.State == System.Data.ConnectionState.Closed)


            {
                connection.Open();



            }

        }

        public void Closeconnection()
        {

            if (connection.State == System.Data.ConnectionState.Open)


            {
                connection.Close();



            }

        }

        public MySqlConnection getConnection()
        {
            return connection;
        }


    }
}









