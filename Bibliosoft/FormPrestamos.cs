using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bibliosoft
{
    public partial class FormPrestamos : Form
    {
        List<Prestamo> prestamos = new List<Prestamo>();
        Dbcrud db = new Dbcrud();
        
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";



        public FormPrestamos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonVolverPrest_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormInicio();
            

            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }
        private void LoadPrestamos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_usuario, id_libro, DiasPrestar FROM Prestamo", conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    prestamos.Add(new Prestamo
                    {
                        id_usuario = Convert.ToInt32(rdr["id_usuario"]),
                        id_libro = Convert.ToInt32(rdr["id_libro"]),
                        DiasPrestar = Convert.ToInt32(rdr["DiasPrestar"])
                    });
                }
            }

            // Cargar la lista en el DataGridView
            dataGridView2.DataSource = prestamos;

        }


        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            
            LoadPrestamos();
            CargarUsuarios();
            CargarLibros();
            // Cambiar los nombres de columnas predeterminadas por unas personalizadas
            dataGridView2.Columns["id_usuario"].HeaderText = "Id de Usuario";
            dataGridView2.Columns["id_libro"].HeaderText = "Id de Libro";
            dataGridView2.Columns["DiasPrestar"].HeaderText = "Dias Prestado";
            // Enviar el foco (punto de inserción) al txtIdBook
            txtIdUser.Focus();
        }
        private void CargarUsuarios()
        {
   
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    string query = "SELECT id_usuario, nombreCompleto FROM Usuario WHERE estaMultado = 0";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxUsers.DataSource = dt;
                    comboBoxUsers.DisplayMember = "nombreCompleto"; // lo que el usuario ve
                    comboBoxUsers.ValueMember = "id_usuario";       // el valor real
                    comboBoxUsers.SelectedIndex = -1;               // que aparezca vacío al inicio
                }   
            
        }
        private void CargarLibros()
        {
            
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    string query = "SELECT id_libro, titulo FROM Libro WHERE disponibilidad = 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBoxBooks.DataSource = dt;
                    comboBoxBooks.DisplayMember = "titulo"; // lo que el usuario ve
                    comboBoxBooks.ValueMember = "id_libro"; // el valor real
                    comboBoxBooks.SelectedIndex = -1;
                }
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messageIdUser.ForeColor = Color.Red;
                messageIdUser.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messageIdBook.ForeColor = Color.Red;
                messageIdBook.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        /*private void buttonAgregarUsuarioPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = int.Parse(txtIdUser.Text);
                int idLibro = int.Parse(txtIdBook.Text);
                int diasprestar = (int)numericUpDown1.Value;

                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    // 1️⃣ Verificar si el usuario está multado
                    string queryCheck = "SELECT estaMultado FROM Usuario WHERE id_usuario = @id_usuario";
                    SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                    cmdCheck.Parameters.AddWithValue("@id_usuario", idUsuario);
                    bool estaMultado = Convert.ToBoolean(cmdCheck.ExecuteScalar());

                    if (estaMultado)
                    {
                        MessageBox.Show("⚠️ El usuario está multado y no puede realizar préstamos hasta ser habilitado.");
                        return;
                    }

                    // 2️⃣ Registrar el préstamo
                    string query = "INSERT INTO Prestamo (id_usuario, id_libro, DiasPrestar) VALUES (@id_usuario, @id_libro, @DiasPrestar)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@id_libro", idLibro);
                    cmd.Parameters.AddWithValue("@DiasPrestar", diasprestar);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Préstamo registrado correctamente.");
                }

                LoadPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar préstamo: {ex.Message}");
            }
            string idUser = txtIdUser.Text;
            string idBook = txtIdBook.Text;
            int diasPrestar = (int)numericUpDown1.Value;
            if (string.IsNullOrWhiteSpace(txtIdUser.Text) ||
                string.IsNullOrWhiteSpace(txtIdBook.Text) ||
                string.IsNullOrWhiteSpace(numericUpDown1.Text))
            {
                MessageBox.Show("⚠️ Por favor, complete todos los campos antes de agregar el préstamo. ⚠️",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Prestamo newPrestamo = new Prestamo(int.Parse(idUser), int.Parse(idBook), diasPrestar);

            db.AddPrestamos(newPrestamo);
            message.ForeColor = Color.Green;
            message.Text = "Prestamo agregado CORRECTAMENTE...✅";
            LoadPrestamos();
        }*/
        private void buttonAgregarUsuarioPrestamo_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedValue == null || comboBoxBooks.SelectedValue == null)
            {
                messagee.ForeColor= Color.Red;
                messagee.Text = "⚠️ Debe seleccionar un usuario y un libro.";
                
                return;
            }

            int idUsuario = Convert.ToInt32(comboBoxUsers.SelectedValue);
            int idLibro = Convert.ToInt32(comboBoxBooks.SelectedValue);
            int diasPrestar = Convert.ToInt32(numericUpDown1.Value); // si usas un NumericUpDown

            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    string query = "INSERT INTO Prestamo (id_usuario, id_libro, DiasPrestar) VALUES (@id_usuario, @id_libro, @DiasPrestar)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@id_libro", idLibro);
                    cmd.Parameters.AddWithValue("@DiasPrestar", diasPrestar);

                    cmd.ExecuteNonQuery();
                }
                messagee.ForeColor = Color.Green;
                messagee.Text = "✅ Préstamo registrado correctamente. ✅";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message);
            }
        }
        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView2.Columns["id_usuario"].HeaderText = "Id de usuario";
            dataGridView2.Columns["id_libro"].HeaderText = "Id de usuario";
            dataGridView2.Columns["DiasPrestar"].HeaderText = "Dias a Prestar";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtIdUser.Text))
            {
                MessageBox.Show("Por favor ingresa el ID del usuario.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el texto a número
            int idUsuario = int.Parse(txtIdUser.Text);

            // Crear instancia de la clase Dbcrud
            Dbcrud db = new Dbcrud();

            // Llamar al método que busca préstamos
            List<Prestamo> prestamosEncontrados = db.BuscarPrestamoPorUsuario(idUsuario);

            // Mostrar los resultados en el DataGridView
            if (prestamosEncontrados.Count > 0)
            {
                messagealert.ForeColor = Color.Green;
                message.Text = $"Préstamos encontrados para el usuario ID {idUsuario}.✅";
                dataGridView2.DataSource = prestamosEncontrados;
            }
            else
            {
                MessageBox.Show("No se encontraron préstamos para este usuario.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView2.DataSource = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadPrestamos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIdUser.Text != "")
            {
                // Buscar primero el libro con el id ingresado
                prestamos = db.GetPrestamos(int.Parse(txtIdUser.Text));


                if (prestamos.Count > 0) // Si existe el libro
                {
                    string idUserToDelete = txtIdUser.Text;

                    // Llamamos al método de la clase dbCrud para eliminarlo
                    db.DeletePrestamo(idUserToDelete);

                    message.ForeColor = Color.Green;
                    message.Text = $"Prestamo con id de usuario {idUserToDelete}, eliminado correctamente ✅";

                    // Recargamos la lista de libros en la vista
                    LoadPrestamos();

                    // Limpiamos los controles
                    txtIdUser.Clear();
                    txtIdBook.Clear();
                    numericUpDown1.Value=0;
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = $"⚠️ El id de usuario: {txtIdUser.Text} NO existe. Inténtelo con otro ⚠️";
                }
            }
            else
            {
                MessageBox.Show("⚠️Debe ingresar el id del usuario para eliminar prestamo ⚠️");
            }
        }
    }
}
