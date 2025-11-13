using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Bibliosoft
{
    public partial class FormRecuperarContrasena : Form
    {
        string ConexionBD = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BibliosoftV3;Integrated Security=True";
        private string codigoGenerado;
        private string correoDestino;
        public FormRecuperarContrasena()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormRecuperarContrasena_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormRegistrocs();


            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            correoDestino = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(correoDestino))
            {
                message.ForeColor = Color.Orange;
                message.Text = "⚠️ Por favor ingrese su correo. ⚠️";
                
                return;
            }

            // Verificar que el correo exista en la base de datos
            using (SqlConnection con = new SqlConnection(ConexionBD))
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Correo = @Correo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Correo", correoDestino);
                con.Open();
                int existe = (int)cmd.ExecuteScalar();

                if (existe == 0)
                {
                    message.ForeColor = Color.Orange;
                    message.Text = "⚠️ El correo no está registrado. ⚠️";
                    return;
                }
            }

            // Generar código aleatorio de 6 dígitos
            Random rnd = new Random();
            codigoGenerado = rnd.Next(100000, 999999).ToString();

            // Enviar el correo
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("miguelangelhenaotorres05@gmail.com");
                mail.To.Add(correoDestino);
                mail.Subject = "Recuperación de contraseña - Bibliosoft";
                mail.Body = $"Tu código de verificación es: {codigoGenerado}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("miguelangelhenaotorres05@gmail.com", "vnht hwzk dhde eujk");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Código enviado. Revisa tu correo.✅");

                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                buttonResistrarse.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private void buttonResistrarse_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != codigoGenerado)
            {
                MessageBox.Show("Código incorrecto.");
                return;
            }

            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            string nuevaHash = HashPassword(textBox3.Text);

            using (SqlConnection con = new SqlConnection(ConexionBD))
            {
                string query = "UPDATE Usuario SET Contraseña = @Contraseña WHERE Correo = @Correo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Contrasena", nuevaHash);
                cmd.Parameters.AddWithValue("@Correo", correoDestino);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Contraseña actualizada correctamente.");
            this.Close();
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
