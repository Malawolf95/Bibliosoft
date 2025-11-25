using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public partial class FormUsuariosApp : Form
    {
        private string nombre;
        private string foto;
        public FormUsuariosApp(string nombreCompleto, string FotoPerfil)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            nombre = nombreCompleto;
            foto = FotoPerfil;
        }

        /*private void FormUsuariosApp_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;

            if (!string.IsNullOrEmpty(foto) && File.Exists(foto))
            {
                pictureBoxPerfil.Image = Image.FromFile(foto);
            }
            else
            {
                pictureBoxPerfil.Image = Properties.Resources.user_person_profile_avatar_icon_190943__1_; // imagen por defecto
            }
        }*/
        private void FormUsuariosApp_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombre;

            try
            {
                if (!string.IsNullOrEmpty(foto) && File.Exists(foto))
                {
                    pictureBoxPerfil.Image = Image.FromFile(foto);
                }
                else
                {
                    pictureBoxPerfil.Image = Properties.Resources.user_person_profile_avatar_icon_190943__1_;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                pictureBoxPerfil.Image = Properties.Resources.user_person_profile_avatar_icon_190943__1_;
            }
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {

            Form PrestarLibro = new FormMiPerfil();
            PrestarLibro.Show();
            this.Hide();
        }

        private void buttonDevoluciones_Click(object sender, EventArgs e)
        {
            Form reservar = new FormReservas();
            reservar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form historial = new FormHistorial();
            historial.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form misReservas = new FormMisReservas();
            misReservas.Show();
            this.Hide();
        }
    }
    }

