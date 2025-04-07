using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPOSCSharpMySQL.Modelos
{
    internal class ModeloCliente
    {   
        //Campos Privados
        int idCliente;
        String nombres;
        String apPaterno;
        String apMaterno;

        // Propiedades para acceder a los datos de manera controlada
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
    }
}
