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
    public partial class FormInicio : Form
    {
        private Timer slideTimer;
        private bool isCollapsed = true;
        public FormInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Users = new FormUsuarios();
            Users.Show();
            this.Hide();
            
        }

        private void buttonDevoluciones_Click(object sender, EventArgs e)
        {
            Form Devoluciones = new FormDevoluciones();
            Devoluciones.Show();
            this.Hide();
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {

            Form Prestamos = new FormPrestamos();
            Prestamos.Show();
            this.Hide();
        }

        private void buttonLibros_Click(object sender, EventArgs e)
        {

            Form Libros = new FormLibros();
            Libros.Show();
            this.Hide();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonMultas_Click(object sender, EventArgs e)
        {
            Form Multas = new FormMultas();
            Multas.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
