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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si intenta cerrar el formulario sin haber iniciado sesión
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string claveAdmin = "admin2025"; // 🔐 Aquí defines la clave correcta
            string claveIngresada = textBox1.Text.Trim();

            if (claveIngresada == claveAdmin)
            {
                // Si la clave es correcta, abrir el formulario de menú
                Form inicio = new FormInicio();
                inicio.Show();

                // Ocultar este formulario
                this.Hide();
            }
            else
            {
                // Si la clave es incorrecta
                message.ForeColor = Color.Red;
                message.Text = "❌ Clave incorrecta. Intente de nuevo.";
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick(); 
            }
        }
    }
}
