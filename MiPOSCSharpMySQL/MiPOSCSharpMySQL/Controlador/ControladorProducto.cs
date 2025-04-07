using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPOSCSharpMySQL.Controlador
{
    class ControladorProducto
    {
        public void MostrarProductos(DataGridView tablaTotalProductos)
        {
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();
            Modelos.ModeloProducto objetoProducto = new Modelos.ModeloProducto();

            DataTable modelo = new DataTable();

            //Añadir columnas del formulario (Toma el nombre del campo y el tipo de dato)
            modelo.Columns.Add("id", typeof(int));
            modelo.Columns.Add("NombreP", typeof(string));
            modelo.Columns.Add("Precio", typeof(double));
            modelo.Columns.Add("Stock", typeof(double));

            //DataSource - Contenido
            tablaTotalProductos.DataSource = modelo;

            string sql = "SELECT idproducto,nombre,precioProducto,stock FROM producto;";

            try
            {
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                MySqlCommand comando = new MySqlCommand(sql, conexion);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataSet ds = new DataSet();

                //Mostrar todos los registros
                adaptador.Fill(ds);

                DataTable dt = ds.Tables[0];

                //Recorrer los datos del arreglo
                foreach (DataRow row in dt.Rows)
                {
                    objetoProducto.IdProduto = Convert.ToInt32(row["idproducto"]);
                    objetoProducto.NombreProducto = row["nombre"].ToString();
                    objetoProducto.PrecioProducto = Convert.ToDouble(row["precioProducto"].ToString());
                    objetoProducto.StockProducto = Convert.ToInt32(row["stock"].ToString());

                    modelo.Rows.Add(objetoProducto.IdProduto, objetoProducto.NombreProducto, objetoProducto.PrecioProducto, objetoProducto.StockProducto);
                }
                tablaTotalProductos.DataSource = modelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar Datos" + ex.ToString());
            }
            finally
            {
                objetoConexion.CerrarConexion();
            }
        }
    }
}
