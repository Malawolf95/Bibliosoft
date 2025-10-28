using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{

    public class PrestamosDAO
    {
        private SqlConnection con;
        private Prestamo[] prestamos;

        public PrestamosDAO(int size)
        {

            prestamos = new Prestamo[size];
        }

        public PrestamosDAO()
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
        public void DeletePrestamo(string iduser)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Prestamo WHERE id_usuario = @id", conn);
                cmd.Parameters.AddWithValue("@id", iduser);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddPrestamos(Prestamo prestamo)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Prestamo WHERE id_usuario = @id_usuario", conn);
                checkCmd.Parameters.AddWithValue("@id_usuario", prestamo.id_usuario);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("⚠️ Ya existe un préstamo con ese ID. Ingrese un ID diferente. ⚠️",
                                    "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Prestamo (id_usuario, id_libro, DiasPrestar) " +
                       "VALUES (@id_usuario, @id_libro, @DiasPrestar)", conn);
                // Especificar el contenido de las variables con @
                cmd.Parameters.AddWithValue("@id_usuario", prestamo.id_usuario);
                cmd.Parameters.AddWithValue("@id_libro", prestamo.id_libro);
                cmd.Parameters.AddWithValue("@DiasPrestar", prestamo.DiasPrestar);

                cmd.ExecuteNonQuery();

            }
        }

        public Libros GetBookById(int idLibro)
        {
            Libros libro = null;

            using (SqlConnection conn = Conexion.GetConnection())
            {
                string query = "SELECT * FROM Libro WHERE id_libro = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idLibro);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    libro = new Libros
                    {
                        idbook = (int)reader["id_libro"],
                        title = reader["titulo"].ToString(),
                        available = Convert.ToInt32(reader["disponibilidad"])
                    };
                }
            }

            return libro;
        }
        public List<Prestamo> GetPrestamos(int id)
        {
            List<Prestamo> lista = new List<Prestamo>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Prestamo WHERE id_usuario = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Prestamo p = new Prestamo
                    {
                        id_usuario = reader.GetInt32(0),
                        id_libro = reader.GetInt32(1),
                        DiasPrestar = reader.GetInt32(2)
                    };
                    lista.Add(p);
                }

                reader.Close();
            }

            return lista;
        }
        public List<Prestamo> BuscarPrestamoPorUsuario(int idUsuario)
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Prestamo WHERE id_usuario = @id_usuario", conn);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    prestamos.Add(new Prestamo(
                        Convert.ToInt32(rdr["id_usuario"]),
                        Convert.ToInt32(rdr["id_libro"]),
                        Convert.ToInt32(rdr["DiasPrestar"])
                    ));
                }
            }
            return prestamos;
        }
        public void ActualizarDisponibilidadLibro(int idLibro, int nuevaDisponibilidad)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                string query = "UPDATE Libro SET disponibilidad = @disponibilidad WHERE id_libro = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@disponibilidad", nuevaDisponibilidad);
                cmd.Parameters.AddWithValue("@id_libro", idLibro);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
