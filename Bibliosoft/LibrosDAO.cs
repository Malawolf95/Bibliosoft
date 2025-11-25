using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public class LibrosDAO
    {
        private SqlConnection con;
        private Libros[] libros;

        public LibrosDAO(int size)
        {

            libros = new Libros[size];
        }

        public LibrosDAO()
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
        public void AddBook(Libros book)
        {
            using (SqlConnection conn = Conexion.GetConnection())
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
            using (SqlConnection conn = Conexion.GetConnection())
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
        public Libros GetBookById(int idLibro)
        {
            Libros libro = null;

            using (SqlConnection conn = Conexion.GetConnection())
            {
                string query = "SELECT * FROM Libros WHERE IdLibro = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idLibro);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    libro = new Libros
                    {
                        idbook = (int)reader["IdLibro"],
                        title = reader["Titulo"].ToString(),
                        available = Convert.ToInt32(reader["Disponibilidad"])
                    };
                }
            }

            return libro;
        }
        public List<Libros> GetBooks()
        {
            // Declarar la lista que se devolverá
            List<Libros> books = new List<Libros>();
            // Abrir la conexión a la base de datos con using
            using (SqlConnection conn = Conexion.GetConnection())
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
        // Metodo para actualizar un libro, indicando el idbook
        public void updateBook(string idbookOld, Libros book)
        {
            using (SqlConnection conn = Conexion.GetConnection())
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
            using (SqlConnection conn = Conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Libro WHERE id_libro = @id", conn);
                cmd.Parameters.AddWithValue("@id", idbook);
                cmd.ExecuteNonQuery();
            }
        }
        
    }
}
