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
        PrestamosDAO db = new PrestamosDAO();
        
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";



        public FormPrestamos()
        {
            InitializeComponent();
            LoadComboBox();
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

       
        private void LoadComboBox()
        {
            // Limpiamos antes de cargar
            comboBoxUsers.Items.Clear();
            comboBoxBooks.Items.Clear();

            // 🔹 Cargar usuarios
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                string queryUsers = "SELECT nombreCompleto FROM Usuario";
                SqlCommand cmdUsers = new SqlCommand(queryUsers, conn);
                SqlDataReader readerUsers = cmdUsers.ExecuteReader();

                while (readerUsers.Read())
                {
                    comboBoxUsers.Items.Add(readerUsers["nombreCompleto"].ToString());
                }

                readerUsers.Close();

                // 🔹 Cargar libros disponibles
                string queryBooks = "SELECT titulo FROM Libro WHERE disponibilidad > 0";
                SqlCommand cmdBooks = new SqlCommand(queryBooks, conn);
                SqlDataReader readerBooks = cmdBooks.ExecuteReader();

                while (readerBooks.Read())
                {
                    comboBoxBooks.Items.Add(readerBooks["titulo"].ToString());
                }

                readerBooks.Close();
            }
        }
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
            string nombreUsuario = comboBoxUsers.Text;
            string nombreLibro = comboBoxBooks.Text;

            var libro = db.GetBookById(idLibro);
            if (libro.available == 0)
            {
                message.ForeColor = Color.OrangeRed;
                message.Text = $"❌ El libro '{nombreLibro}' no está disponible.";
                return;
            }

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
                db.ActualizarDisponibilidadLibro(idLibro, 0);
                LoadPrestamos();
                LoadComboBox();
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
            if (comboBoxUsers.SelectedValue == null)
            {
                message.ForeColor = Color.Red;
                message.Text = "⚠️ Selecciona un usuario para buscar su préstamo.";
                return;
            }

            int idUsuario = Convert.ToInt32(comboBoxUsers.SelectedValue);
            var prestamos = db.GetPrestamos(idUsuario);

            if (prestamos.Count > 0)
            {
                dataGridView2.DataSource = prestamos;
                message.ForeColor = Color.Green;
                message.Text = $"📚 Se encontraron {prestamos.Count} préstamos de {comboBoxUsers.Text}.";
            }
            else
            {
                message.ForeColor = Color.OrangeRed;
                message.Text = $"⚠️ {comboBoxUsers.Text} no tiene préstamos registrados.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadPrestamos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedValue == null)
            {
                message.ForeColor = Color.Red;
                message.Text = "⚠️ Selecciona un usuario para eliminar su préstamo.";
                return;
            }

            int idUsuario = Convert.ToInt32(comboBoxUsers.SelectedValue);
            string nombreUsuario = comboBoxUsers.Text;

            var prestamos = db.GetPrestamos(idUsuario);

            if (prestamos.Count > 0)
            {
                db.DeletePrestamo(idUsuario.ToString());
                message.ForeColor = Color.Green;
                message.Text = $"✅ Se eliminaron los préstamos del usuario {nombreUsuario}.";
                LoadPrestamos();
            }
            else
            {
                message.ForeColor = Color.OrangeRed;
                message.Text = $"⚠️ {nombreUsuario} no tiene préstamos para eliminar.";
            }
        }
    }
}
