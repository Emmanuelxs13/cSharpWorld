using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPOSCSharpMySQL.Configuracion
{
    class CConexion
    {
        //Conexión con la DB MySql

        private MySqlConnection conectar = null;

        //Variables para la conexion
        private static string usuario = "root";
        private static string password = "LasJirafas27**";
        private static string bd = "bdpos";
        private static string ip = "localhost";
        private static string puerto = "3306";

        //Cadena de conexion
        private string cadena = $"Server={ip};Port={puerto};Database={bd};Uid={usuario};Pwd={password};";

        public MySqlConnection EstableceConexion() {
            try
            {
                conectar = new MySqlConnection(cadena);
                conectar.Open();
                //MessageBox.Show("Se conectó a la base de datos");
                
            }

            catch(Exception e)
            {
                MessageBox.Show("No se conectó a la base de datos");
            }

            return conectar;
        }

        public void CerrarConexion(){
            try {
                if (conectar != null && conectar.State == System.Data.ConnectionState.Open)

                    //Se cierra la conexión
                    conectar.Close();
                    //MessageBox.Show("Se cerró la conexion a la Base de Datos");
                
            }
            catch(Exception e) {

                MessageBox.Show("No se cerró la conexion a la Base de Datos" + e.ToString());

            }
        }
    }
}
