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
        Dbcrud db = new Dbcrud();
        
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";



        public FormPrestamos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonVolverPrest_Click(object sender, EventArgs e)
        {
            
            Form volver = new FormInicio();
            

            volver.Show();
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
            // Cambiar los nombres de columnas predeterminadas por unas personalizadas
            dataGridView2.Columns["id_usuario"].HeaderText = "Id de Usuario";
            dataGridView2.Columns["id_libro"].HeaderText = "Id de Libro";
            dataGridView2.Columns["DiasPrestar"].HeaderText = "Dias Prestado";
            // Enviar el foco (punto de inserción) al txtIdBook
            txtIdUser.Focus();
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

        private void buttonAgregarUsuarioPrestamo_Click(object sender, EventArgs e)
        {
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

        }
    }
}
