using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public partial class FormMiPerfil : Form
    {
        private string nombre;
        private string foto;
        public FormMiPerfil(string nombreCompleto, string FotoPerfil)
        {
            InitializeComponent();
            nombre = nombreCompleto;
            foto = FotoPerfil;
        }

        private void PrestarLibroUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolverPrest_Click(object sender, EventArgs e)
        {
            Form volver = new FormUsuariosApp(nombre, foto);
            volver.Show();
            this.Hide();
        }
    }
}
