using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormDevoluciones()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonVolverDev_Click(object sender, EventArgs e)
        {
            

            Form volver = new FormInicio();
            
            volver.Show();
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
            message.ForeColor = Color.Green;
            message.Text = $"Devolución realizada con éxito ✅";
        }

        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            
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
