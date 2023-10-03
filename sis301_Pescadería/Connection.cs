using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis301_Pescadería
{
    class Connection
    {
        public Connection()
        {

        }

        //private static string servidor = "localhost";
        //private static string bd = "tienda";
        //private static string usuario = "root";
        //private static string password = "MartinezNisse64";
        //private static string port = "3306";

        private static string servidor = "containers-us-west-209.railway.app";
        private static string bd = "railway";
        private static string usuario = "root";
        private static string password = "RWn95tLjpLkfUIg9uGSk";
        private static string port = "5706";

        private static string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "; Port=" + port + "";
        private static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        private MySqlDataReader execute_consult(string consult)
        {
            MySqlCommand comando;
            MySqlDataReader reader;
            comando = new MySqlCommand(consult);
            comando.Connection = conexionBD;
            conexionBD.Open();
            reader = comando.ExecuteReader();
            comando = null;
            return reader;
        }

        private MySqlDataReader consult(string comander)
        {
            MySqlDataReader read = null;
            try
            {
                read = execute_consult(comander);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            return read;
        }

        //devuelve el resultado de una consulta
        public MySqlDataReader dataconsult(string consulta)
        {
            return consult(consulta);
        }

        public void ConnectionClose()
        {
            conexionBD.Close();
        }
    }
}
