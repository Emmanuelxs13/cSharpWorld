using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPOSCSharpMySQL
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            //Prueba de conexión a db
            //Configuracion.CConexion objetoConexion = new Configuracion.CConexion();
            //objetoConexion.EstableceConexion();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormVentas objetoFormVentas = new Formularios.FormVentas();
            objetoFormVentas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormClientes objetoFormVentas = new Formularios.FormClientes();
            objetoFormVentas.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormProductos objetoFormVentas = new Formularios.FormProductos();
            objetoFormVentas.Show();
        }

        private void buscarComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormBuscarComprobante objetoFormVentas = new Formularios.FormBuscarComprobante();
            objetoFormVentas.Show();
        }

        private void consultaPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormReportePorFechas objetoFormVentas = new Formularios.FormReportePorFechas();
            objetoFormVentas.Show();
        }
    }
}
