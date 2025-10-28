using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bibliosoft
{
    public partial class FormUsuarios : Form
    {
              
        List<Usuarios> usuarios = new List<Usuarios>();  // lista para guardar los resultados de búsqueda
        string idUserFound = "";
        private UsuariosDAO db = new UsuariosDAO();

        public FormUsuarios()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            dgvBook.DataBindingComplete += dgvBook_DataBindingComplete;
            db = new UsuariosDAO();
            //MessageBox.Show("Conexión a la base de datos, EXITOSA");
            LoadUsers();
        }
        private void LoadUsers()
        {
            usuarios = db.GetUsers();
            dgvBook.DataSource = usuarios;
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            
            // Cambiar los nombres de columnas predeterminadas por unas personalizadas
            dgvBook.Columns["id_usuario"].HeaderText = "Id de usuario";
            dgvBook.Columns["nombreCompleto"].HeaderText = "nombre";
            dgvBook.Columns["telefono"].HeaderText = "telefono";
            // Enviar el foco (punto de inserción) al txtIdBook
            textIdUser.Focus();
        }
        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBook.Columns["id_usuario"].HeaderText = "Id de usuario";
            dgvBook.Columns["nombreCompleto"].HeaderText = "Nombre";
            dgvBook.Columns["telefono"].HeaderText = "Teléfono";
        }
        


        private void buttonVolver1_Click(object sender, EventArgs e)
        {
            Animaciones.SlideOut(this, "right");
            Form volver = new FormInicio();

            
            volver.Show();
            Animaciones.SlideIn(volver, "left");
            this.Close();
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messageNameUser.ForeColor = Color.Red;
                messageNameUser.Text = $"⚠️ Debe ingresar solo letras ⚠️";
                
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messageIdUser.ForeColor = Color.Red;
                messageIdUser.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messagePhone.ForeColor = Color.Red;
                messagePhone.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textIdUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textIdUser.Text) ||
                string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textPhone.Text))

            {
                
                MessageBox.Show("⚠️ Por favor, complete todos los campos antes de agregar el usuario. ⚠️",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string iduser = textIdUser.Text;
            string nombre = textName.Text;
            string telefono = textPhone.Text;
            bool EstaMultado = false;
            // Crear objeto de la clase Book con el método constructor que tiene todos los atributos
            Usuarios newUser = new Usuarios(int.Parse(iduser), nombre, (telefono),Convert.ToBoolean(EstaMultado));
            // Mandar a guardar a través del metodo AddBook de la clase dbCrud
            db.AddUsers(newUser);
            message.ForeColor = Color.Green;
            message.Text = "Usuario agregado CORRECTAMENTE...✅";
            LoadUsers();
        }

        private void buttonActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (textIdUser.Text != "" && textName.Text != "" && textPhone.Text !="")
            {
                Usuarios upUser = new Usuarios(int.Parse(textIdUser.Text), textName.Text, (textPhone.Text));
                // Verificar que los idbooks (buscado y el actual son o no iguales)
                if (idUserFound == textIdUser.Text)
                {
                    db.updateUser(idUserFound, upUser);
                    message.ForeColor = Color.Green;
                    message.Text = $"Usuario con id {idUserFound}, actualizado correctamente✅";
                    LoadUsers();

                }
                else
                {
                    // Buscar el idnuevo txtidbook.Text
                    usuarios = db.getUserxId(int.Parse(textIdUser.Text));
                    if (usuarios.Count == 0)
                    {
                        db.updateUser(idUserFound, upUser);
                        message.ForeColor = Color.Green;
                        message.Text = $"Usuario con id {textIdUser.Text}, actualizado correctamente✅";
                        LoadUsers();

                    }
                    else
                    {
                        message.ForeColor = Color.Red;
                        message.Text = $"⚠️ Usuario con id {textIdUser.Text}, Existe! Inténtelo con otro ⚠️";

                    }

                }
            }
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (textIdUser.Text != "")
            {
                
                // Buscar primero el usuario con el id ingresado
                usuarios = db.getUserxId(int.Parse(textIdUser.Text));


                if (usuarios.Count > 0) // Si existe el usuario
                {
                    int idUserToDelete = int.Parse(textIdUser.Text);
                    DialogResult result = MessageBox.Show(
                    $"¿Seguro que deseas eliminar el usuario con ID {idUserToDelete}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        
                            db.DeleteUser(idUserToDelete);
                            message.ForeColor = Color.Green;
                            message.Text = $"Usuario con ID {idUserToDelete} eliminado correctamente.";
                            LoadUsers(); // refresca el DataGridView
                            textIdUser.Clear();
                            textName.Clear();
                            textPhone.Clear();
                        }
                        
                    }
                    else
                    {
                    message.ForeColor = Color.Red;
                    message.Text = "⚠️ Por favor ingrese o un ID de usuario. ⚠️";
                    }
            }
            else
            {
                MessageBox.Show("⚠️ Debe ingresar el id del usuario a eliminar ⚠️");
            }
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textIdUser.Text != "")
            {
                // Buscar usuario por ID
                usuarios = db.getUserxId(int.Parse(textIdUser.Text));

                // Verificar si el objeto users tiene al menos un registro
                if (usuarios.Count > 0)
                {
                    idUserFound = textIdUser.Text;
                    // Asignar los datos del usuario a sus respectivos TextBox
                    textName.Text = usuarios[0].nombreCompleto;
                    textPhone.Text = usuarios[0].telefono;

                    message.ForeColor = Color.Green;
                    message.Text = $"Usuario con id {textIdUser.Text} encontrado correctamente ✅";
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = $"El id {textIdUser.Text} NO existe. Inténtelo con otro.";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el id del usuario a buscar.");
            }
        }

        private void labelGestionarL_Click(object sender, EventArgs e)
        {

        }
    }
}
