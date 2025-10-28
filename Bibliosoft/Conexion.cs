using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliosoft
{
    public class Conexion
    {
        private static string ConexionBD = "Server=(localdb)\\MSSQLLocalDB;Database=BibliosoftV3;Trusted_Connection=True;";
        public static SqlConnection GetConnection() => new SqlConnection(ConexionBD);
    }
}
