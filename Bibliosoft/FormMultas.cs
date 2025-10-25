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
    public partial class FormMultas : Form
    {
        private string ConexionBD = "Server=(localdb)\\MSSQLLocalDB;Database=BibliosoftV3;Trusted_Connection=True;";
        public FormMultas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                message.ForeColor = Color.Red;
                message.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormInicio();


            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }

        private void FormMultas_Load(object sender, EventArgs e)
        {
            LoadUsuariosMultados();
        }
        private void LoadUsuariosMultados()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    // Consulta de usuarios multados
                    string query = @"SELECT id_usuario, nombreCompleto, telefono 
                                     FROM Usuario 
                                     WHERE EstaMultado = 1";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Mostrar en el DataGridView
                    dataGridView1.DataSource = dt;

                    // Cambiar encabezados si quieres
                    dataGridView1.Columns["id_usuario"].HeaderText = "ID Usuario";
                    dataGridView1.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
                    dataGridView1.Columns["telefono"].HeaderText = "Teléfono";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios multados: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idUsuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_usuario"].Value);

                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();

                    string query = "UPDATE Usuario SET EstaMultado = 0 WHERE id_usuario = @id_usuario";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Multa eliminada correctamente.");
                LoadUsuariosMultados();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario primero.");
            }
        }
    }
}
