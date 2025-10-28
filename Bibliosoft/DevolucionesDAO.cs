using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class DevolucionesDAO
    {
        private SqlConnection con;
        private Devoluciones[] devoluciones;

        public DevolucionesDAO(int size)
        {
  
            devoluciones = new Devoluciones[size];
        }

        public DevolucionesDAO()
        {
            con = Conexion.GetConnection();
        }

        // Ejemplo de método para cerrar la conexión
        public void CloseConnection()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }


    }

    
    
}
