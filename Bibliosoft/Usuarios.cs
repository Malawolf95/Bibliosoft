using System;
using System.Collections.Generic;
// Bibliotecas para conexion a SQL SERVER
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombreCompleto { get; set; }

        public string telefono { get; set; }

        public bool EstaMultado { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(int id_usuario, string nombreCompleto, string telefono, bool estaMultado=false)
        {
            this.id_usuario = id_usuario;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.EstaMultado = estaMultado;
        }
    }
}
