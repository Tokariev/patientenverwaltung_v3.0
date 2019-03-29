using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace Patientenverwaltung_v3._0
{
    class DBConnect
    {
        private static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "db_patientenverwaltung";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" +
            "Convert Zero Datetime = True;";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    case 1042:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    default:
                        MessageBox.Show("Unknown Error #" + Convert.ToString(ex.Number));
                        break;

                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public string Insert(string query)
        {
            
            
            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                    return "Daten wurden gespeichert";
                }
                catch (Exception ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return ex.Message;
                }
            } else
            {
                return "Es konnte keine Verbindung zur Datenbank hergestellt werden!";
            }
            
        }

        //Update statement
        public string Update(string query)
        {
            
            
            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                catch (Exception ex)
                {
                    this.CloseConnection();
                    return ex.Message;
                }
            }
            return "Updated";
        }

        //Delete statement
        public string Delete(string query)
        {
          

            if (this.OpenConnection() == true)
            {
                try {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();

                }
                catch (Exception ex)
                {
                    this.CloseConnection();
                    return ex.Message;
                }
            }
            return "Daten wurden gelöscht";
        }

        //Select statement
        public DataTable Select(string query)
        {
            DataTable table = new DataTable();

     
            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(table);

                    //close Connection
                    this.CloseConnection();

                    //return table to be displayed
                    return table;
                }
                catch (Exception ex)
                {
                    this.CloseConnection();
                    MessageBox.Show(ex.Message);
                    return table;
                }
            }
            else
            {
                return table;
            }
        }
    }
}
