using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public partial class FormRegistrocs : Form
    {
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";
        private string rutaFoto = "";
        bool mostrarContrasenas = false;

        public FormRegistrocs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutaFoto = openFile.FileName;
                pictureBox1.Image = Image.FromFile(rutaFoto);
            }
        }

        private void FormRegistrocs_Load(object sender, EventArgs e)
        {

        }

        private void buttonResistrarse_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            if (!textBox6.Text.Contains("@"))
            {
                MessageBox.Show("Correo no válido");
                return;
            }

            string hashPassword = HashPassword(textBox3.Text);

            string query = "INSERT INTO Usuario (nombreCompleto,id_usuario,telefono, Correo, Contrasena, FotoPerfil) " +
                           "VALUES (@nombreCompleto,@id_usuario,@telefono, @Correo, @Contrasena, @FotoPerfil)";

            using (SqlConnection con = new SqlConnection(ConexionBD))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombreCompleto", textBox1.Text);
                cmd.Parameters.AddWithValue("@id_usuario", textBox5.Text);
                cmd.Parameters.AddWithValue("@telefono", textBox2.Text);
                cmd.Parameters.AddWithValue("@Correo", textBox6.Text);
                cmd.Parameters.AddWithValue("@Contrasena", hashPassword);
                cmd.Parameters.AddWithValue("@FotoPerfil", rutaFoto);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Registro exitoso");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mostrarContrasenas = !mostrarContrasenas;

            if (mostrarContrasenas)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.see_eye_visible_icon_187826; // Imagen de ojo abierto
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.no_see_visible_hidde_icon_187886; // Imagen de ojo cerrado
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Login = new FormLoginUser();
            Login.Show();
            this.Hide();
        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormBienvenida();


            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }
    }
}
