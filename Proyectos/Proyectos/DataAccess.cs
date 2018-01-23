using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyectos
{
    class DataAccess
    {

        MySqlConnection connection;

        public bool CreateConnection()
        {
            string myConnectionString = "server=localhost;uid=root;" + "pwd=tortuga9632;database=usuarios";
            try
            {
                connection = new MySqlConnection(myConnectionString);
                connection.Open();
                return true;
            }
            catch (Exception exc)
            {
                Error = exc.Message;

                return false;
            }
        }
        public int Execute(string pQuery)
        {

            if (connection.State != ConnectionState.Open)
                CreateConnection();
            try
            {

                MySqlCommand myCommand = new MySqlCommand(pQuery, connection);
                myCommand.CommandType = CommandType.Text;
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Error = exc.Message;
                return -1;

            }

        }
        public DataTable FillTable(string pQuery)
        {
            DataTable dt = new DataTable();
            if (connection.State != ConnectionState.Open)
                CreateConnection();
            try
            {

                MySqlCommand myCommand = new MySqlCommand(pQuery, connection);
                myCommand.CommandType = CommandType.Text;
                //myCommand.ExecuteReader();
                MySqlDataAdapter objDA = new MySqlDataAdapter(myCommand);
                objDA.Fill(dt);

            }
            catch (Exception exc)
            {
                Error = exc.Message;

            }

            return dt;
        }
        public string Error { get; set; }
    }
}
