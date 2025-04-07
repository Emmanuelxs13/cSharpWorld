using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPOSCSharpMySQL.Modelos
{
    internal class ModeloProducto
    {
        //Campos Privados
        int idProduto;
        String nombreProducto;
        Double precioProducto;
        int stockProducto;

        // Propiedades para acceder a los datos de manera controlada
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }
    }
}
