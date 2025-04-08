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
        public void MostrarProductos(DataGridView tablaTotalProductos) {
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


        // Método público que agrega un producto a la base de datos.
        // Recibe tres objetos TextBox como parámetros, que contienen los datos del producto.
        public void AgregarProducto(TextBox nombres, TextBox precioProducto, TextBox stock)
        {
            // Se crea una instancia de la clase de conexión, que maneja la conexión a la base de datos.
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();

            // Se crea una instancia del modelo de producto, que representa un producto con sus propiedades.
            Modelos.ModeloProducto objetoProducto = new Modelos.ModeloProducto();

            // Cadena de consulta SQL para insertar un nuevo producto en la tabla "producto".
            // Se utilizan parámetros para evitar vulnerabilidades de inyección SQL.
            string consulta = "insert into producto(nombre,precioProducto,stock) values (@nombre,@precioProducto,@stock);";

            try
            {
                // Se asigna el valor del TextBox 'nombres' a la propiedad 'NombreProducto' del objeto modelo.
                objetoProducto.NombreProducto = nombres.Text;

                // Se convierte el texto del TextBox 'precioProducto' a tipo double y se asigna al modelo.
                objetoProducto.PrecioProducto = double.Parse(precioProducto.Text);

                // Se convierte el texto del TextBox 'stock' a tipo int y se asigna al modelo.
                objetoProducto.StockProducto = int.Parse(stock.Text);

                // Se establece una conexión con la base de datos usando el método de la clase de conexión.
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                // Se crea un comando MySQL con la consulta SQL y la conexión activa.
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Se agregan los valores a los parámetros de la consulta, usando los datos del modelo.
                comando.Parameters.AddWithValue("@nombre", objetoProducto.NombreProducto);
                comando.Parameters.AddWithValue("@precioProducto", objetoProducto.PrecioProducto);
                comando.Parameters.AddWithValue("@stock", objetoProducto.StockProducto);

                // Se ejecuta la consulta de inserción (INSERT) sin retornar resultados (ExecuteNonQuery).
                comando.ExecuteNonQuery();

                // Se muestra un mensaje al usuario indicando que la operación fue exitosa.
                MessageBox.Show("Se guardó correctamente");
            }
            catch (Exception ex)
            {
                // Si ocurre algún error en el proceso, se captura la excepción y se muestra un mensaje de error.
                MessageBox.Show("Error al guardar, error: " + ex.ToString());
            }
            finally
            {
                // Se cierra la conexión a la base de datos, se haya producido o no una excepción.
                objetoConexion.CerrarConexion();
            }
        }


    }
}
