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

        // Método público para seleccionar una fila de un DataGridView y mostrar sus datos en TextBoxes.
        public void Seleccionar(DataGridView totalProductos, TextBox id, TextBox nombre, TextBox precioProducto, TextBox stock)
        {
            // Obtiene el índice (posición) de la fila actualmente seleccionada en el DataGridView.
            int fila = totalProductos.CurrentRow.Index;

            try
            {
                // Verifica que el índice de la fila sea válido (es decir, que haya una fila seleccionada).
                if (fila >= 0)
                {
                    // Asigna el valor de la primera celda de la fila (generalmente el ID del producto) al TextBox 'id'.
                    id.Text = totalProductos.Rows[fila].Cells[0].Value.ToString();

                    // Asigna el valor de la segunda celda (nombre del producto) al TextBox 'nombre'.
                    nombre.Text = totalProductos.Rows[fila].Cells[1].Value.ToString();

                    // Asigna el valor de la tercera celda (precio del producto) al TextBox 'precioProducto'.
                    precioProducto.Text = totalProductos.Rows[fila].Cells[2].Value.ToString();

                    // Asigna el valor de la cuarta celda (stock del producto) al TextBox 'stock'.
                    stock.Text = totalProductos.Rows[fila].Cells[3].Value.ToString();
                }
            }
            catch (Exception e)
            {
                // Si ocurre un error (como que una celda tenga valor nulo o no exista), muestra un mensaje con el error.
                MessageBox.Show("Error al seleccionar " + e.ToString());
            }
        }


        // Método público para modificar los datos de un cliente existente en la base de datos.
        // Recibe como parámetros cuatro TextBox que contienen el ID del cliente y sus nuevos datos.
        public void ModificarProducto(TextBox id, TextBox nombre, TextBox precioProducto, TextBox stock)
        {
            // Se crea una instancia del objeto de conexión para interactuar con la base de datos.
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();

            // Se crea una instancia del modelo de cliente para almacenar los datos del cliente a modificar.
            Modelos.ModeloProducto objetoProducto = new Modelos.ModeloProducto();

            // Consulta SQL para actualizar los datos de un cliente específico mediante su ID.
            // Se utilizan parámetros para evitar inyección SQL.
            string consulta = "UPDATE producto SET producto.nombre=@nombre, producto.precioProducto=@precioProducto, producto.stock=@stock WHERE producto.idproducto=@id;";

            try
            {
                // Se obtiene y asigna el ID del cliente desde el TextBox, convirtiéndolo a entero.
                objetoProducto.IdProduto = int.Parse(id.Text);

                // Se asignan los nuevos valores del cliente desde los TextBox correspondientes.
                objetoProducto.NombreProducto = nombre.Text;
                objetoProducto.PrecioProducto = double.Parse(precioProducto.Text);
                objetoProducto.StockProducto = int.Parse(stock.Text);

                // Se establece la conexión a la base de datos.
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                // Se prepara el comando SQL con la consulta y la conexión abierta.
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Se asignan los valores a los parámetros definidos en la consulta SQL.
                comando.Parameters.AddWithValue("@id", objetoProducto.IdProduto);
                comando.Parameters.AddWithValue("@nombre", objetoProducto.NombreProducto);
                comando.Parameters.AddWithValue("@precioProducto", objetoProducto.PrecioProducto);
                comando.Parameters.AddWithValue("@stock", objetoProducto.StockProducto);

                // Se ejecuta la consulta UPDATE (no devuelve resultados, por eso se usa ExecuteNonQuery).
                comando.ExecuteNonQuery();

                // Se muestra un mensaje indicando que la modificación fue exitosa.
                MessageBox.Show("Se modificó correctamente");
            }
            catch (Exception ex)
            {
                // En caso de error, se muestra un mensaje con la descripción del problema.
                MessageBox.Show("No se modificó correctamente, error: " + ex.ToString());
            }
            finally
            {
                // Se cierra la conexión a la base de datos, independientemente del resultado.
                objetoConexion.CerrarConexion();
            }
        }


    }
}
