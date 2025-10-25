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
    public partial class FormDevoluciones : Form
    {
        private string ConexionBD = "Server=(localdb)\\MSSQLLocalDB;Database=BibliosoftV3;Trusted_Connection=True;";
        public FormDevoluciones()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormInicio();
            
            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messagealert.ForeColor = Color.Red;
                messagealert.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(comboBoxUser.SelectedValue);
            int idLibro = Convert.ToInt32(comboBoxBook.SelectedValue);
            int diasPrestados = Convert.ToInt32(numericUpDown1.Value);

            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Devoluciones (id_usuario, id_libro, DiasPrestado) " +
                    "VALUES (@id_usuario, @id_libro, @DiasPrestado)", conn);

                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@id_libro", idLibro);
                cmd.Parameters.AddWithValue("@DiasPrestado", diasPrestados);

                cmd.ExecuteNonQuery();
            }
            messagealert.ForeColor = Color.Green;
            messagealert.Text = "✅ Devolución registrada correctamente. ✅";
        }

        /*private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int idUsuario = int.Parse(textBox1.Text);
                int idLibro = int.Parse(textBox2.Text);
                int diasPrestados = (int)numericUpDown1.Value;
                int diasPermitidos = 0;

                // 🔹 Obtener los días permitidos del préstamo
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT DiasPrestar FROM Prestamo WHERE id_usuario = @idU AND id_libro = @idL",
                        conn);
                    cmd.Parameters.AddWithValue("@idU", idUsuario);
                    cmd.Parameters.AddWithValue("@idL", idLibro);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        diasPermitidos = Convert.ToInt32(result);
                }

                // 🔹 Comparar y aplicar multa si se pasó
                if (diasPrestados > diasPermitidos)
                {
                    using (SqlConnection conn = new SqlConnection(ConexionBD))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(
                            "UPDATE Usuario SET EstaMultado = 1 WHERE id_usuario = @id", conn);
                        cmd.Parameters.AddWithValue("@id", idUsuario);
                        cmd.ExecuteNonQuery();
                    }

                    messagealert.ForeColor = Color.Red;
                    messagealert.Text = "⚠️ El usuario fue multado por exceder los días de préstamo.";
                }
                else
                {
                    messagealert.ForeColor = Color.Green;
                    messagealert.Text = "✅ Devolución registrada sin multas.";
                }

                // 🔹 Registrar devolución
                using (SqlConnection conn = new SqlConnection(ConexionBD))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Devoluciones (id_usuario, id_libro, DiasPrestado) VALUES (@id_usuario, @id_libro, @DiasPrestado)",
                        conn);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@id_libro", idLibro);
                    cmd.Parameters.AddWithValue("@DiasPrestado", diasPrestados);
                    cmd.ExecuteNonQuery();

                    string queryEliminar = "DELETE FROM Prestamo WHERE id_usuario = @id_usuario AND id_libro = @id_libro";
                    SqlCommand cmdEliminar = new SqlCommand(queryEliminar, conn);
                    cmdEliminar.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmdEliminar.Parameters.AddWithValue("@id_libro", idLibro);
                    cmdEliminar.ExecuteNonQuery();

                    MessageBox.Show("✅ Devolución registrada y préstamo eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar devolución: " + ex.Message);
            }

        }*/

        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibros();
        }
        private void CargarUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_usuario, nombreCompleto FROM Usuario", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxUser.DataSource = dt;
                comboBoxUser.DisplayMember = "nombreCompleto";   // Lo que se muestra
                comboBoxUser.ValueMember = "id_usuario"; // Lo que se guarda internamente
            }
        }
        private void CargarLibros()
        {
            using (SqlConnection conn = new SqlConnection(ConexionBD))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_libro, titulo FROM Libro", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxBook.DataSource = dt;
                comboBoxBook.DisplayMember = "titulo";
                comboBoxBook.ValueMember = "id_libro";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messagealert.ForeColor = Color.Red;
                messagealert.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }
    }
}
