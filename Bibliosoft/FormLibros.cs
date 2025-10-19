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
    public partial class FormLibros : Form
    {
        private Dbcrud db;
        // Lista para recibir los libros del método GetBooks
        private List<Libros> books;
        // Declarar vble para guardar el idbook del libro encontrado
        string idBookFound;// Almacena el idbook encontrado (Buscar)
        public FormLibros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            // instanciar la clase dbCrud
            db = new Dbcrud();

            LoadBooks();
        }

        private void LoadBooks()
        {
            books = db.GetBooks();
            dgvBook.DataSource = books;
        }

        private void buttonVolverLibros_Click(object sender, EventArgs e)
        {
            

            Form vover = new FormInicio();
            
            
            vover.Show();
            this.Close();
        }

        private void FormLibros_Load(object sender, EventArgs e)
        {
            
            // Cambiar los nombres de columnas predeterminadas por unas personalizadas
            dgvBook.Columns["idbook"].HeaderText = "Id del Libro";
            dgvBook.Columns["title"].HeaderText = "Título";
            dgvBook.Columns["available"].HeaderText = "Disponibilidad";
            // Enviar el foco (punto de inserción) al txtIdBook
            txtIdBook.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtIdBook.Text) ||
                string.IsNullOrWhiteSpace(txtTitleBook.Text))  
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el libro.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (!rbYes.Checked && !rbNo.Checked)
            {
                radiobutton.ForeColor = Color.Red;
                radiobutton.Text = $"⚠️ Debe llenar el campo de disponibilidad ⚠️";
                
                return;
            }
            string disponibilidad = rbYes.Checked ? "Si" : "No";

            // Tomar los datos de los controles para agregar el libro
            string idbook = txtIdBook.Text;
            string title = txtTitleBook.Text;
            int available = rbYes.Checked ? 1 : 0;
            // Crear objeto de la clase Book con el método constructor que tiene todos los atributos
            Libros newBook = new Libros(int.Parse(idbook), title, available);
            // Mandar a guardar a través del metodo AddBook de la clase dbCrud
            db.AddBook(newBook);
            message.ForeColor = Color.Green;
            message.Text = "Libro Guardado CORRECTAMENTE...✅";
            LoadBooks();
            txtIdBook.Clear();
            txtTitleBook.Clear();
            rbYes.Checked = false;
            rbNo.Checked = false;
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (txtIdBook.Text != "" && txtTitleBook.Text != "")
            {
                Libros upBook = new Libros(int.Parse(txtIdBook.Text), txtTitleBook.Text, rbYes.Checked ? 1 : 0);
                // Verificar que los idbooks (buscado y el actual son o no iguales)
                if (idBookFound == txtIdBook.Text)
                {
                    db.updateBook(idBookFound, upBook);
                    message.ForeColor = Color.Green;
                    message.Text = $"libro con id {idBookFound}, actualizado correctamente✅";
                    LoadBooks();

                }
                else
                {
                    // Buscar el idnuevo txtidbook.Text
                    books = db.getBookxId(int.Parse(txtIdBook.Text));
                    if (books.Count == 0)
                    {
                        db.updateBook(idBookFound, upBook);
                        message.ForeColor = Color.Green;
                        message.Text = $"libro con id {txtIdBook.Text}, actualizado correctamente✅";
                        LoadBooks();

                    }
                    else
                    {
                        message.ForeColor = Color.Red;
                        message.Text = $"⚠️ libro con id {txtIdBook.Text},Exite!! Inténtelo con otro ⚠️";

                    }

                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (txtIdBook.Text != "")
            {
                books = db.getBookxId(int.Parse(txtIdBook.Text));
                // Verificar si el objeto books tiene, al menos, un registro
                if (books.Count > 0)
                {
                    idBookFound = txtIdBook.Text;
                    // Encuentra el idBook
                    // asignar los datos del libro a sus respectivos textbox
                    txtTitleBook.Text = books[0].title;
                    rbYes.Checked = books[0].available == 1 ? true : false;
                    rbNo.Checked = books[0].available == 0 ? true : false;
                    message.ForeColor= Color.Green;
                    message.Text = "Libro Encontrado✅";
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = $"⚠️ El id del libro: {txtIdBook.Text} NO Existe. Inténtelo con otro ⚠️";
                }
            }
            else
            {
                MessageBox.Show($"⚠️ Debe Ingresar el id del libro a buscar ⚠️");
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtIdBook.Text != "")
            {
                // Buscar primero el libro con el id ingresado
                books = db.getBookxId(int.Parse(txtIdBook.Text));
                

                if (books.Count > 0) // Si existe el libro
                {
                    string idBookToDelete = txtIdBook.Text;

                    // Llamamos al método de la clase dbCrud para eliminarlo
                    db.DeleteBook(idBookToDelete);

                    message.ForeColor = Color.Green;
                    message.Text = $"Libro con id {idBookToDelete}, eliminado correctamente ✅";

                    // Recargamos la lista de libros en la vista
                    LoadBooks();

                    // Limpiamos los controles
                    txtIdBook.Clear();
                    txtTitleBook.Clear();
                    rbYes.Checked = false;
                    rbNo.Checked = false;
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = $"El id Book: {txtIdBook.Text} NO existe. Inténtelo con otro";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el id del libro a eliminar");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtIdBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                messageIdBook.ForeColor = Color.Red;
                messageIdBook.Text = $"⚠️ Debe ingresar solo números ⚠️";
                e.Handled = true;
            }
        }

        private void txtTitleBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
