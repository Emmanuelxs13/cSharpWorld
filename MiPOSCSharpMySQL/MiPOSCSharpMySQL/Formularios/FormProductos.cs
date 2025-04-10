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
    public partial class FormProductos: Form
    {
        public FormProductos()
        {
            InitializeComponent();
            Controlador.ControladorProducto objetoProducto = new Controlador.ControladorProducto();
            objetoProducto.MostrarProductos(dgvproductos);
            txtid.ReadOnly = true;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorProducto objetoProducto = new Controlador.ControladorProducto();
            objetoProducto.AgregarProducto(txtnombreproducto,txtprecioproducto,txtstockproducto);
            objetoProducto.MostrarProductos(dgvproductos);
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controlador.ControladorProducto objetoProducto = new Controlador.ControladorProducto();
            objetoProducto.Seleccionar(dgvproductos,txtid,txtnombreproducto,txtprecioproducto,txtstockproducto);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Controlador.ControladorProducto objetoProducto = new Controlador.ControladorProducto();
            objetoProducto.ModificarProducto(txtid,txtnombreproducto, txtprecioproducto, txtstockproducto);
            objetoProducto.MostrarProductos(dgvproductos);
        }
    }
}
