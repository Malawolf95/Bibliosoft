using System;
using System.Collections.Generic;
// Bibliotecas para conexion a SQL SERVER
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bibliosoft.Prestamo;

namespace Bibliosoft
{
    public class Dbcrud
    {
        private Libros[] libros; // 👈 este es el arreglo donde guardas los libros
        private Usuarios[] usuarios;
        private Prestamo[] prestamos;
        private Devoluciones[] devoluciones;

        public Dbcrud(int size)
        {

            libros = new Libros[size]; // inicializar arreglos
            usuarios = new Usuarios[size];
            prestamos = new Prestamo[size];
            devoluciones = new Devoluciones[size];
        }

        public Dbcrud()
        {
        }

        private string ConexionBD = "Server=(localdb)\\MSSQLLocalDB;Database=BibliosoftV3;Trusted_Connection=True;";

        // Metodo para recuperar todos los books
        public List<Libros> GetBooks()
        {
            // Declarar la lista que se devolverá
            List<Libros> books = new List<Libros>();
            // Abrir la conexión a la base de datos con using
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                // abrir la conexión 
                conn.Open();
                // Generar un objeto para realizar comandos de sql
                SqlCommand cmd = new SqlCommand("Select id_libro, titulo, disponibilidad From Libro", conn);
                // Ejecutar la instrucción contenida en el objeto cmd
                SqlDataReader rdr = cmd.ExecuteReader();
                // Recorrer el contenido de la vble rdr
                // para agregar cada libro en lista
                while (rdr.Read())
                {
                    books.Add(new Libros(
                    Convert.ToInt32(rdr["id_libro"]),         // ✔ ToString() en vez de (string)
                    rdr["titulo"].ToString(),
                    Convert.ToInt32(rdr["disponibilidad"])
                ));
                }
            }
            return books;

        }
        public List<Prestamo> BuscarPrestamoPorUsuario(int idUsuario)
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            using (SqlConnection conn = new SqlConnection(ConexionBD))
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
        public List<Prestamo> GetPrestamos(int id)
        {
            List<Prestamo> lista = new List<Prestamo>();

            using (SqlConnection conn = new SqlConnection(ConexionBD))
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
        public void DeletePrestamo(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE id_usuario FROM Usuario WHERE id_usuario = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                
            }
        }
        

        //usuarios
        public List<Usuarios> GetUsers()
        {
            // Declarar la lista que se devolverá
            List<Usuarios> users = new List<Usuarios>();
            // Abrir la conexión a la base de datos con using
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                // abrir la conexión 
                conn.Open();
                // Generar un objeto para realizar comandos de sql
                SqlCommand cmd = new SqlCommand("Select id_usuario, nombreCompleto, telefono From Usuario", conn);
                // Ejecutar la instrucción contenida en el objeto cmd
                SqlDataReader rdr = cmd.ExecuteReader();
                // Recorrer el contenido de la vble rdr
                // para agregar cada usuario en lista
                while (rdr.Read())
                {
                    users.Add(new Usuarios(
                    Convert.ToInt32(rdr["id_usuario"]),         
                    rdr["nombreCompleto"].ToString(),
                    rdr["telefono"].ToString()
                ));
                }
            }
            return users;

        }
        public void AddUsers(Usuarios user)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
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
            using (SqlConnection conn = new SqlConnection(ConexionBD))
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

    using (SqlConnection conn = new SqlConnection(ConexionBD))
    {
        SqlCommand cmd = new SqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@id", iduser);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Usuarios u = new Usuarios(
                Convert.ToInt32(dr["id_usuario"]),
                dr["NombreCompleto"].ToString(),
                dr["telefono"].ToString()
            );
            lista.Add(u);
        }
        conn.Close();
    }

    return lista;
        }
        public void updateUser(string iduserOld, Usuarios user)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
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
        public void DeleteUser(string iduser)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id_usuario = @id", conn);
                cmd.Parameters.AddWithValue("@id", iduser);
                cmd.ExecuteNonQuery();
                
            }
        }

        // Método para agregar un libro a la BDs
        public void AddBook(Libros book)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand InsertBook = new SqlCommand("Insert Into Libro (id_libro, titulo, disponibilidad) Values (@id_libro,@titulo,@disponibilidad)", conn);
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Libro WHERE id_libro = @id_libro", conn);
                checkCmd.Parameters.AddWithValue("@id_libro", book.idbook);

                int count = (int)checkCmd.ExecuteScalar(); // Devuelve el número de registros con ese id
                if (count > 0)
                {
                    
                    MessageBox.Show("⚠️ Ya existe un libro con ese ID. Ingrese un ID diferente.⚠️",
                                    "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Cancelar la inserción
                }
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un libro con ese ID. Ingrese un ID diferente.",
                                    "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Cancelar la inserción
                }
                // Especificar el contenido de las variables con @
                InsertBook.Parameters.AddWithValue("@id_libro", book.idbook);
                InsertBook.Parameters.AddWithValue("@titulo", book.title);
                InsertBook.Parameters.AddWithValue("@disponibilidad", book.available);
                // Ejecutar la instrucción del sqlcommand que se llama InsertBook
                InsertBook.ExecuteNonQuery();
            }
        }

        // Metodo para buscar un idBook y recuperar toda su informacion
        public List<Libros> getBookxId(int idbook)
        {
            List<Libros> book = new List<Libros>();
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Libro Where id_libro = @id", conn);
                cmd.Parameters.AddWithValue("@id", idbook);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    book.Add(new Libros(
                    Convert.ToInt32(rdr["id_libro"]),
                    rdr["titulo"].ToString(),               
                    Convert.ToInt32(rdr["disponibilidad"])
                    ));
                }

            }
            return book;
        }
        // Metodo para actualizar un libro, indicando el idbook
        public void updateBook(string idbookOld, Libros book)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update libro Set id_libro = @id_libro, titulo = @titulo , disponibilidad = @disponibilidad Where id_libro = @idbookOld", conn);
                cmd.Parameters.AddWithValue("@id_libro", book.idbook);
                cmd.Parameters.AddWithValue("@titulo", book.title);
                cmd.Parameters.AddWithValue("@disponibilidad", book.available);
                cmd.Parameters.AddWithValue("@idbookOLd", idbookOld);
                // Ejecutar la instrucción del sqlcommand que se llama cmd
                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteBook(string idbook)
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Libro WHERE id_libro = @id", conn);
                cmd.Parameters.AddWithValue("@id", idbook);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
