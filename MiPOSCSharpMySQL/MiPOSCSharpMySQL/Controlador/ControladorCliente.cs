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
    internal class ControladorCliente
    {
        public void MostrarClientes(DataGridView tablaTotalClientes)
        {
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();
            Modelos.ModeloCliente objetoCliente = new Modelos.ModeloCliente();

            DataTable modelo = new DataTable();

            //Añadir columnas del formulario (Toma el nombre del campo y el tipo de dato)
            modelo.Columns.Add("id", typeof(int));
            modelo.Columns.Add("Nombres", typeof(string));
            modelo.Columns.Add("ApPaterno", typeof(string));
            modelo.Columns.Add("ApMaterno", typeof(string));

            //DataSource - Contenido
            tablaTotalClientes.DataSource = modelo;

            string sql = "select idcliente,nombres,appaterno, apmaterno from cliente;";

            try{
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                MySqlCommand comando = new MySqlCommand(sql,conexion);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                DataSet ds = new DataSet();

                //Mostrar todos los registros
                adaptador.Fill(ds);

                DataTable dt = ds.Tables[0];

                //Recorrer los datos del arreglo
                foreach (DataRow row in dt.Rows)
                {
                    objetoCliente.IdCliente = Convert.ToInt32(row["idCliente"]);
                    objetoCliente.Nombres = row["nombres"].ToString();
                    objetoCliente.ApPaterno = row["appaterno"].ToString();
                    objetoCliente.ApMaterno = row["apmaterno"].ToString();

                    modelo.Rows.Add(objetoCliente.IdCliente, objetoCliente.Nombres, objetoCliente.ApPaterno, objetoCliente.ApMaterno);
                }
                tablaTotalClientes.DataSource = modelo;
            }
            catch(Exception ex) {
                MessageBox.Show("Error al mostrar Datos" + ex.ToString());
            }
            finally{
                objetoConexion.CerrarConexion();
            }
        }

        // Método público que agrega un cliente a la base de datos.
        // Recibe tres TextBox como parámetros, que contienen los datos del cliente.
        public void AgregarCliente(TextBox nombre, TextBox appaterno, TextBox apmaterno)
        {
            // Se crea una instancia de la clase de conexión, que administra la conexión a la base de datos.
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();

            // Se crea una instancia del modelo de cliente, que representa un cliente con sus propiedades.
            Modelos.ModeloCliente objetoCliente = new Modelos.ModeloCliente();

            // Cadena de consulta SQL para insertar un nuevo cliente en la tabla "cliente".
            // Se usan parámetros (@nombre, @appaterno, @apmaterno) para evitar inyecciones SQL.
            string consulta = "insert into cliente(nombres, appaterno, apmaterno) values (@nombre, @appaterno, @apmaterno);";

            try
            {
                // Asigna los valores de los TextBox a las propiedades del objeto cliente.
                objetoCliente.Nombres = nombre.Text;
                objetoCliente.ApPaterno = appaterno.Text;
                objetoCliente.ApMaterno = apmaterno.Text;

                // Establece una conexión con la base de datos llamando al método definido en CConexion.
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                // Crea un comando MySQL con la consulta definida y la conexión activa.
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Asigna los valores del objeto cliente a los parámetros de la consulta SQL.
                comando.Parameters.AddWithValue("@nombre", objetoCliente.Nombres);
                comando.Parameters.AddWithValue("@appaterno", objetoCliente.ApPaterno);
                comando.Parameters.AddWithValue("@apmaterno", objetoCliente.ApMaterno);

                // Ejecuta el comando (INSERT) sin esperar resultados (por eso es ExecuteNonQuery).
                comando.ExecuteNonQuery();

                // Muestra un mensaje indicando que el cliente fue guardado exitosamente.
                MessageBox.Show("Se guardó correctamente");
            }
            catch (Exception ex)
            {
                // Si ocurre algún error durante el proceso, se muestra un mensaje con el error.
                MessageBox.Show("Error al guardar, error: " + ex.ToString());
            }
            finally
            {
                // Cierra la conexión a la base de datos, independientemente de si hubo error o no.
                objetoConexion.CerrarConexion();
            }
        }


        // Método público para seleccionar una fila de un DataGridView y mostrar sus datos en TextBoxes.
        public void Seleccionar(DataGridView totalClientes, TextBox id, TextBox nombres, TextBox appaterno, TextBox apmaterno)
        {
            // Obtiene el índice (posición) de la fila actualmente seleccionada en el DataGridView.
            int fila = totalClientes.CurrentRow.Index;

            try
            {
                // Verifica que el índice de la fila sea válido (es decir, que haya una fila seleccionada).
                if (fila >= 0)
                {
                    // Asigna el valor de la primera celda (ID) al TextBox correspondiente.
                    id.Text = totalClientes.Rows[fila].Cells[0].Value.ToString();

                    // Asigna el valor de la segunda celda (Nombres) al TextBox correspondiente.
                    nombres.Text = totalClientes.Rows[fila].Cells[1].Value.ToString();

                    // Asigna el valor de la tercera celda (Apellido Paterno) al TextBox correspondiente.
                    appaterno.Text = totalClientes.Rows[fila].Cells[2].Value.ToString();

                    // Asigna el valor de la cuarta celda (Apellido Materno) al TextBox correspondiente.
                    apmaterno.Text = totalClientes.Rows[fila].Cells[3].Value.ToString();
                }
            }
            catch (Exception e)
            {
                // En caso de error (por ejemplo, si la fila no tiene valores), muestra un mensaje con el error.
                MessageBox.Show("Error al seleccionar " + e.ToString());
            }
        }

        // Método público para modificar los datos de un cliente existente en la base de datos.
        // Recibe como parámetros cuatro TextBox que contienen el ID del cliente y sus nuevos datos.
        public void ModificarCliente(TextBox id, TextBox nombres, TextBox appaterno, TextBox apmaterno)
        {
            // Se crea una instancia del objeto de conexión para interactuar con la base de datos.
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();

            // Se crea una instancia del modelo de cliente para almacenar los datos del cliente a modificar.
            Modelos.ModeloCliente objetoCliente = new Modelos.ModeloCliente();

            // Consulta SQL para actualizar los datos de un cliente específico mediante su ID.
            // Se utilizan parámetros para evitar inyección SQL.
            string consulta = "UPDATE cliente SET cliente.nombres=@nombres, cliente.appaterno=@appaterno, cliente.apmaterno=@apmaterno WHERE cliente.idcliente=@id;";

            try
            {
                // Se obtiene y asigna el ID del cliente desde el TextBox, convirtiéndolo a entero.
                objetoCliente.IdCliente = int.Parse(id.Text);

                // Se asignan los nuevos valores del cliente desde los TextBox correspondientes.
                objetoCliente.Nombres = nombres.Text;
                objetoCliente.ApPaterno = appaterno.Text;
                objetoCliente.ApMaterno = apmaterno.Text;

                // Se establece la conexión a la base de datos.
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                // Se prepara el comando SQL con la consulta y la conexión abierta.
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Se asignan los valores a los parámetros definidos en la consulta SQL.
                comando.Parameters.AddWithValue("@id", objetoCliente.IdCliente);
                comando.Parameters.AddWithValue("@nombres", objetoCliente.Nombres);
                comando.Parameters.AddWithValue("@appaterno", objetoCliente.ApPaterno);
                comando.Parameters.AddWithValue("@apmaterno", objetoCliente.ApMaterno);

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

        //Método para limpiar los campos despues de guardar, actualizar y presionando el botoón de eliminar
        public void LimpiarCampos(TextBox id, TextBox nombres, TextBox appaterno, TextBox apmaterno) {

            id.Text = "";
            nombres.Text = "";
            appaterno.Text = "";
            apmaterno.Text = "";
        }

        public void EliminarCliente(TextBox id) {
            // Se crea una instancia del objeto de conexión para interactuar con la base de datos.
            Configuracion.CConexion objetoConexion = new Configuracion.CConexion();

            // Se crea una instancia del modelo de cliente para almacenar los datos del cliente a modificar.
            Modelos.ModeloCliente objetoCliente = new Modelos.ModeloCliente();


            string consulta = "DELETE FROM cliente WHERE cliente.idcliente=@id;";

            try {
                // Se obtiene y asigna el ID del cliente desde el TextBox, convirtiéndolo a entero.
                objetoCliente.IdCliente = int.Parse(id.Text);

                // Se establece la conexión a la base de datos.
                MySqlConnection conexion = objetoConexion.EstableceConexion();

                // Se prepara el comando SQL con la consulta y la conexión abierta.
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                // Se asignan los valores a los parámetros definidos en la consulta SQL.
                comando.Parameters.AddWithValue("@id", objetoCliente.IdCliente);

                // Se ejecuta la consulta UPDATE (no devuelve resultados, por eso se usa ExecuteNonQuery).
                comando.ExecuteNonQuery();

                // Se muestra un mensaje indicando que la modificación fue exitosa.
                MessageBox.Show("Se eliminó correctamente");
            }
            catch (Exception ex) {
                // En caso de error, se muestra un mensaje con la descripción del problema.
                MessageBox.Show("No se eliminó correctamente, error: " + ex.ToString());
            }
            finally {
                // Se cierra la conexión a la base de datos, independientemente del resultado.
                objetoConexion.CerrarConexion();
            }
        }
    }
}
