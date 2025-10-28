using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public class UsuariosDAO
    {
        private SqlConnection con;
        private Usuarios[] usuarios;

        public UsuariosDAO(int size)
        {

            usuarios = new Usuarios[size];
        }

        public UsuariosDAO()
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
        public List<Usuarios> GetUsers()
        {
            // Declarar la lista que se devolverá
            List<Usuarios> users = new List<Usuarios>();
            // Abrir la conexión a la base de datos con using
            using (SqlConnection conn = Conexion.GetConnection())
            {
                // abrir la conexión 
                conn.Open();
                // Generar un objeto para realizar comandos de sql
                SqlCommand cmd = new SqlCommand("Select id_usuario, nombreCompleto, telefono, EstaMultado From Usuario", conn);
                // Ejecutar la instrucción contenida en el objeto cmd
                SqlDataReader rdr = cmd.ExecuteReader();
                // Recorrer el contenido de la vble rdr
                // para agregar cada usuario en lista
                while (rdr.Read())
                {
                    bool estaMultado = false; // valor por defecto
                    if (rdr["EstaMultado"] != DBNull.Value)
                    {
                        estaMultado = Convert.ToBoolean(rdr["EstaMultado"]);
                    }

                    users.Add(new Usuarios(
                    Convert.ToInt32(rdr["id_usuario"]),
                    rdr["nombreCompleto"].ToString(),
                    rdr["telefono"].ToString(),
                    estaMultado
                ));
                }
            }
            return users;

        }
        public void AddUsers(Usuarios user)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE id_usuario = @id_usuario", conn);
                checkCmd.Parameters.AddWithValue("@id_usuario", user.id_usuario);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("⚠️ Ya existe un usuario con ese ID. Ingrese un ID diferente. ⚠️",
                                    "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Cancelar inserción
                }
                SqlCommand InsertUser = new SqlCommand("Insert Into Usuario (id_usuario, nombreCompleto, telefono) Values (@id_usuario,@nombreCompleto,@telefono)", conn);
                // Especificar el contenido de las variables con @
                InsertUser.Parameters.AddWithValue("@id_usuario", user.id_usuario);
                InsertUser.Parameters.AddWithValue("@nombreCompleto", user.nombreCompleto);
                InsertUser.Parameters.AddWithValue("@telefono", user.telefono);
                // Ejecutar la instrucción del sqlcommand que se llama InsertBook
                InsertUser.ExecuteNonQuery();

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
        public List<Usuarios> getUserxId(int iduser)
        {
            List<Usuarios> lista = new List<Usuarios>();
            string sql = "SELECT * FROM Usuario WHERE id_usuario = @id";

            using (SqlConnection conn = Conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", iduser);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    bool EstaMultado = false;
                    if (dr["EstaMultado"] != DBNull.Value)
                    {
                        EstaMultado = Convert.ToBoolean(dr["EstaMultado"]);
                    }

                    Usuarios u = new Usuarios(
                    Convert.ToInt32(dr["id_usuario"]),
                    dr["nombreCompleto"].ToString(),
                    dr["telefono"].ToString(),
                    EstaMultado
                );
                    lista.Add(u);
                }
                conn.Close();
            }

            return lista;
        }
        public void updateUser(string iduserOld, Usuarios user)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Usuario Set id_usuario = @id_usuario, nombreCompleto = @nombreCompleto , telefono = @telefono Where id_usuario = @iduserOld", conn);
                cmd.Parameters.AddWithValue("@id_usuario", user.id_usuario);
                cmd.Parameters.AddWithValue("@nombreCompleto", user.nombreCompleto);
                cmd.Parameters.AddWithValue("@telefono", user.telefono);
                cmd.Parameters.AddWithValue("@iduserOLd", iduserOld);
                // Ejecutar la instrucción del sqlcommand que se llama cmd
                cmd.ExecuteNonQuery();

            }
        }
        public void DeleteUser(int iduser)
        {
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id_usuario = @id", conn);
                cmd.Parameters.AddWithValue("@id", iduser);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
