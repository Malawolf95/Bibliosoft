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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace Bibliosoft
{
    public partial class FormLoginUser : Form
    {
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";
        public FormLoginUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string hashPassword = HashPassword(textBox2.Text);

            using (SqlConnection con = new SqlConnection(ConexionBD))
            {
                con.Open();
                string query = "SELECT nombreCompleto, FotoPerfil FROM Usuario WHERE LOWER(RTRIM(Correo)) = LOWER(RTRIM(@Correo)) AND RTRIM(Contrasena) = RTRIM(@Contrasena)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Correo", textBox1.Text);
                cmd.Parameters.AddWithValue("@Contrasena", hashPassword);

                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string nombre = reader["nombreCompleto"].ToString();
                    string rutaFoto = reader["FotoPerfil"].ToString();

                    MessageBox.Show($"Bienvenido {nombre}");
                    // Aquí podrías mostrar la foto en otro formulario principal
                    Form formusuariosapp = new FormUsuariosApp(nombre, rutaFoto);
                    formusuariosapp.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                con.Close();

            }
        }
        private void EnviarCorreoRecuperacion(string correoDestino, string enlace)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tu_correo@gmail.com");
            mail.To.Add(correoDestino);
            mail.Subject = "Recuperación de contraseña";
            mail.Body = $"Haz clic aquí para restablecer tu contraseña: {enlace}";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("tu_correo@gmail.com", "tu_contraseña_de_aplicación");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
        private void FormLoginUser_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarContrasena frm = new FormRecuperarContrasena();
            frm.Show();
            this.Hide();
        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormRegistrocs();


            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }
    }
}
