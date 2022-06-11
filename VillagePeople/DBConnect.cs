using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VillagePeople
{
    //Sisältää tietokannan käsittelyyn tarvittavia funktioita
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Initialize();
        }

        //Alustaa tiedot
        private void Initialize()
        {
            //Ohjelman voi suorittaa näillä tunnuksilla, kyseessä on oma palvelin
            server = "removed";
            port = "3306";
            database = "villagepeople";
            uid = "villagepeople";
            password = "removed";
            string connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Avaa tietokantayhteyden
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
                return false;
            }
        }

        //Sulkee tietokantayhteyden
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Virhe");
                return false;
            }
        }

        //Suorittaa SQL-lauseen
        public void Suorita(string query)
        {
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        //Hakee tiedot syötetyllä SQL-lauseella ja palauttaa niistä DataTablen
        public DataTable HaeTiedot(string query)
        {
            DataTable dt = new DataTable();

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            return dt;
        }

        //Laskee määrän syötetyllä SQL-lauseella ja palauttaa sen
        public int LaskeMaara(string query)
        {
            int Count = -1;

            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    Count = int.Parse(cmd.ExecuteScalar().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Virhe");
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            return Count;
        }
    }
}
