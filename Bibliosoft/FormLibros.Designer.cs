namespace Bibliosoft
{
    partial class FormLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonVolverLibros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.messageIdBook = new System.Windows.Forms.Label();
            this.messageTitleBook = new System.Windows.Forms.Label();
            this.radiobutton = new System.Windows.Forms.Label();
            this.labelListado = new System.Windows.Forms.Label();
            this.labelGestionarL = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelAño = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxAño = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverLibros
            // 
            this.buttonVolverLibros.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverLibros.FlatAppearance.BorderSize = 0;
            this.buttonVolverLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverLibros.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverLibros.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonVolverLibros.Location = new System.Drawing.Point(256, 628);
            this.buttonVolverLibros.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVolverLibros.Name = "buttonVolverLibros";
            this.buttonVolverLibros.Size = new System.Drawing.Size(176, 34);
            this.buttonVolverLibros.TabIndex = 2;
            this.buttonVolverLibros.Text = "< Volver al menú";
            this.buttonVolverLibros.UseVisualStyleBackColor = false;
            this.buttonVolverLibros.Click += new System.EventHandler(this.buttonVolverLibros_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(932, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(969, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Título ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(908, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disponibilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(271, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 62);
            this.label4.TabIndex = 6;
            this.label4.Text = "BIBLIOSOFT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbYes.Location = new System.Drawing.Point(1166, 451);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(44, 23);
            this.rbYes.TabIndex = 7;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "SI";
            this.rbYes.UseVisualStyleBackColor = false;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbNo.Location = new System.Drawing.Point(1223, 451);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(55, 23);
            this.rbNo.TabIndex = 8;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // txtIdBook
            // 
            this.txtIdBook.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdBook.Location = new System.Drawing.Point(1040, 239);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(236, 22);
            this.txtIdBook.TabIndex = 9;
            this.txtIdBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdBook_KeyPress);
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.Location = new System.Drawing.Point(1040, 278);
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(236, 22);
            this.txtTitleBook.TabIndex = 10;
            this.txtTitleBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitleBook_KeyPress);
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvBook.Location = new System.Drawing.Point(282, 288);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(525, 333);
            this.dgvBook.TabIndex = 11;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Bibliosoft.Properties.Resources.icons8_símbolo_más_18;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1072, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar Libro";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdate.Image = global::Bibliosoft.Properties.Resources.icons8_aprobar_y_actualizar_18__1_;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(1072, 530);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(204, 43);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Actualizar Libro";
            this.buttonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Image = global::Bibliosoft.Properties.Resources.icons8_búsqueda_18;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(1072, 579);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(204, 43);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Buscar Libro";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(894, 133);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::Bibliosoft.Properties.Resources.icons8_basura_18;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1072, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Eliminar Libro";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // messageIdBook
            // 
            this.messageIdBook.AutoSize = true;
            this.messageIdBook.Location = new System.Drawing.Point(1096, 178);
            this.messageIdBook.Name = "messageIdBook";
            this.messageIdBook.Size = new System.Drawing.Size(0, 16);
            this.messageIdBook.TabIndex = 17;
            // 
            // messageTitleBook
            // 
            this.messageTitleBook.AutoSize = true;
            this.messageTitleBook.Location = new System.Drawing.Point(1143, 264);
            this.messageTitleBook.Name = "messageTitleBook";
            this.messageTitleBook.Size = new System.Drawing.Size(0, 16);
            this.messageTitleBook.TabIndex = 18;
            // 
            // radiobutton
            // 
            this.radiobutton.AutoSize = true;
            this.radiobutton.BackColor = System.Drawing.Color.Transparent;
            this.radiobutton.Location = new System.Drawing.Point(1049, 539);
            this.radiobutton.Name = "radiobutton";
            this.radiobutton.Size = new System.Drawing.Size(0, 16);
            this.radiobutton.TabIndex = 19;
            // 
            // labelListado
            // 
            this.labelListado.AutoSize = true;
            this.labelListado.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListado.Location = new System.Drawing.Point(276, 244);
            this.labelListado.Name = "labelListado";
            this.labelListado.Size = new System.Drawing.Size(248, 31);
            this.labelListado.TabIndex = 20;
            this.labelListado.Text = "LISTADO DE LIBROS";
            this.labelListado.Click += new System.EventHandler(this.labelListado_Click);
            // 
            // labelGestionarL
            // 
            this.labelGestionarL.AutoSize = true;
            this.labelGestionarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGestionarL.Location = new System.Drawing.Point(998, 180);
            this.labelGestionarL.Name = "labelGestionarL";
            this.labelGestionarL.Size = new System.Drawing.Size(232, 31);
            this.labelGestionarL.TabIndex = 21;
            this.labelGestionarL.Text = "GESTIONAR LIBRO";
            this.labelGestionarL.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.Silver;
            this.labelAutor.Location = new System.Drawing.Point(969, 322);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(52, 19);
            this.labelAutor.TabIndex = 22;
            this.labelAutor.Text = "Autor";
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.ForeColor = System.Drawing.Color.Silver;
            this.labelAño.Location = new System.Drawing.Point(980, 364);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(40, 19);
            this.labelAño.TabIndex = 23;
            this.labelAño.Text = "Año";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.ForeColor = System.Drawing.Color.Silver;
            this.labelGenero.Location = new System.Drawing.Point(961, 406);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(64, 19);
            this.labelGenero.TabIndex = 24;
            this.labelGenero.Text = "Género";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAutor.Location = new System.Drawing.Point(1040, 322);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(236, 22);
            this.textBoxAutor.TabIndex = 25;
            // 
            // textBoxAño
            // 
            this.textBoxAño.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAño.Location = new System.Drawing.Point(1040, 364);
            this.textBoxAño.Name = "textBoxAño";
            this.textBoxAño.Size = new System.Drawing.Size(236, 22);
            this.textBoxAño.TabIndex = 26;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGenero.Location = new System.Drawing.Point(1040, 406);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(236, 22);
            this.textBoxGenero.TabIndex = 27;
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bibliosoft.Properties.Resources.fondo_bibliosoft_1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1571, 1019);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxAño);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelGestionarL);
            this.Controls.Add(this.labelListado);
            this.Controls.Add(this.radiobutton);
            this.Controls.Add(this.messageTitleBook);
            this.Controls.Add(this.messageIdBook);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.message);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVolverLibros);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBROS📗";
            this.Load += new System.EventHandler(this.FormLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label messageIdBook;
        private System.Windows.Forms.Label messageTitleBook;
        private System.Windows.Forms.Label radiobutton;
        private System.Windows.Forms.Label labelListado;
        private System.Windows.Forms.Label labelGestionarL;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxAño;
        private System.Windows.Forms.TextBox textBoxGenero;
    }
}