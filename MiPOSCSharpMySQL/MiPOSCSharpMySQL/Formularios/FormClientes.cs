using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPOSCSharpMySQL.Formularios
{
    public partial class FormClientes: Form
    {
        public FormClientes()
        {
            InitializeComponent();

            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            objetoClientes.MostrarClientes(dgvclientes);

            //Deshabilitar lka modificación del id
            txtid.ReadOnly = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
            
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            objetoClientes.AgregarCliente(txtnombres,txtappaterno,txtapmaterno);
            objetoClientes.MostrarClientes(dgvclientes);
            objetoClientes.LimpiarCampos(txtid, txtnombres, txtappaterno, txtapmaterno);

        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            //Se agrega el Data Grid View y se colocan los campos que se van a seleccionar 
            objetoClientes.Seleccionar(dgvclientes,txtid,txtnombres,txtappaterno,txtapmaterno);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            objetoClientes.ModificarCliente(txtid,txtnombres,txtappaterno,txtapmaterno);
            objetoClientes.MostrarClientes(dgvclientes);
            objetoClientes.LimpiarCampos(txtid, txtnombres, txtappaterno, txtapmaterno);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            objetoClientes.LimpiarCampos(txtid, txtnombres, txtappaterno, txtapmaterno);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorCliente objetoClientes = new Controlador.ControladorCliente();
            objetoClientes.EliminarCliente(txtid);
            objetoClientes.MostrarClientes(dgvclientes);
            objetoClientes.LimpiarCampos(txtid, txtnombres, txtappaterno, txtapmaterno);
        }
    }
}
