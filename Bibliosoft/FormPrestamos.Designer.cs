namespace Bibliosoft
{
    partial class FormPrestamos
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
            this.buttonVolverPrest = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonAgregarUsuarioPrestamo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.messageIdUser = new System.Windows.Forms.Label();
            this.messageIdBook = new System.Windows.Forms.Label();
            this.messagealert = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.messagee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGestionarL = new System.Windows.Forms.Label();
            this.buttonUpdatePrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverPrest
            // 
            this.buttonVolverPrest.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolverPrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonVolverPrest.FlatAppearance.BorderSize = 0;
            this.buttonVolverPrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolverPrest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolverPrest.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonVolverPrest.Location = new System.Drawing.Point(270, 745);
            this.buttonVolverPrest.Margin = new System.Windows.Forms.Padding(0);
            this.buttonVolverPrest.Name = "buttonVolverPrest";
            this.buttonVolverPrest.Size = new System.Drawing.Size(210, 34);
            this.buttonVolverPrest.TabIndex = 1;
            this.buttonVolverPrest.Text = "< Volver al menú";
            this.buttonVolverPrest.UseVisualStyleBackColor = false;
            this.buttonVolverPrest.Click += new System.EventHandler(this.buttonVolverPrest_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(280, 333);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(525, 333);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(274, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRÉSTAMOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(922, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(942, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(878, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dias a prestar";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(-275, 252);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(286, 22);
            this.txtIdUser.TabIndex = 8;
            this.txtIdUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtIdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtIdBook
            // 
            this.txtIdBook.Location = new System.Drawing.Point(-274, 280);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.Size = new System.Drawing.Size(285, 22);
            this.txtIdBook.TabIndex = 9;
            this.txtIdBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.Color.SlateGray;
            this.numericUpDown1.Location = new System.Drawing.Point(1004, 413);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(236, 22);
            this.numericUpDown1.TabIndex = 10;
            // 
            // buttonAgregarUsuarioPrestamo
            // 
            this.buttonAgregarUsuarioPrestamo.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAgregarUsuarioPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarUsuarioPrestamo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarUsuarioPrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarUsuarioPrestamo.Image = global::Bibliosoft.Properties.Resources.icons8_símbolo_más_18;
            this.buttonAgregarUsuarioPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarUsuarioPrestamo.Location = new System.Drawing.Point(1036, 501);
            this.buttonAgregarUsuarioPrestamo.Name = "buttonAgregarUsuarioPrestamo";
            this.buttonAgregarUsuarioPrestamo.Size = new System.Drawing.Size(204, 43);
            this.buttonAgregarUsuarioPrestamo.TabIndex = 11;
            this.buttonAgregarUsuarioPrestamo.Text = "         Agregar Usuario";
            this.buttonAgregarUsuarioPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarUsuarioPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgregarUsuarioPrestamo.UseVisualStyleBackColor = false;
            this.buttonAgregarUsuarioPrestamo.Click += new System.EventHandler(this.buttonAgregarUsuarioPrestamo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Bibliosoft.Properties.Resources.icons8_búsqueda_18;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1036, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar Préstamo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Image = global::Bibliosoft.Properties.Resources.icons8_basura_18;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1036, 653);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Eliminar Préstamo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(736, 144);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 14;
            // 
            // messageIdUser
            // 
            this.messageIdUser.AutoSize = true;
            this.messageIdUser.BackColor = System.Drawing.Color.Transparent;
            this.messageIdUser.Location = new System.Drawing.Point(1100, 209);
            this.messageIdUser.Name = "messageIdUser";
            this.messageIdUser.Size = new System.Drawing.Size(0, 16);
            this.messageIdUser.TabIndex = 15;
            // 
            // messageIdBook
            // 
            this.messageIdBook.AutoSize = true;
            this.messageIdBook.BackColor = System.Drawing.Color.Transparent;
            this.messageIdBook.Location = new System.Drawing.Point(1100, 337);
            this.messageIdBook.Name = "messageIdBook";
            this.messageIdBook.Size = new System.Drawing.Size(0, 16);
            this.messageIdBook.TabIndex = 16;
            // 
            // messagealert
            // 
            this.messagealert.AutoSize = true;
            this.messagealert.Location = new System.Drawing.Point(755, 145);
            this.messagealert.Name = "messagealert";
            this.messagealert.Size = new System.Drawing.Size(0, 16);
            this.messagealert.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(651, 682);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Mostrar todos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(1004, 333);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(236, 24);
            this.comboBoxUsers.TabIndex = 19;
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(1004, 372);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(236, 24);
            this.comboBoxBooks.TabIndex = 20;
            // 
            // messagee
            // 
            this.messagee.AutoSize = true;
            this.messagee.BackColor = System.Drawing.Color.Transparent;
            this.messagee.Location = new System.Drawing.Point(740, 142);
            this.messagee.Name = "messagee";
            this.messagee.Size = new System.Drawing.Size(0, 16);
            this.messagee.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(269, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 62);
            this.label5.TabIndex = 22;
            this.label5.Text = "BIBLIOSOFT";
            // 
            // labelGestionarL
            // 
            this.labelGestionarL.AutoSize = true;
            this.labelGestionarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGestionarL.Location = new System.Drawing.Point(940, 225);
            this.labelGestionarL.Name = "labelGestionarL";
            this.labelGestionarL.Size = new System.Drawing.Size(292, 31);
            this.labelGestionarL.TabIndex = 23;
            this.labelGestionarL.Text = "GESTIONAR PRÉSTAMO";
            // 
            // buttonUpdatePrestamo
            // 
            this.buttonUpdatePrestamo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUpdatePrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePrestamo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePrestamo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdatePrestamo.Image = global::Bibliosoft.Properties.Resources.icons8_aprobar_y_actualizar_18__1_;
            this.buttonUpdatePrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdatePrestamo.Location = new System.Drawing.Point(1036, 599);
            this.buttonUpdatePrestamo.Name = "buttonUpdatePrestamo";
            this.buttonUpdatePrestamo.Size = new System.Drawing.Size(204, 43);
            this.buttonUpdatePrestamo.TabIndex = 24;
            this.buttonUpdatePrestamo.Text = "    Actualizar Préstamo";
            this.buttonUpdatePrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdatePrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdatePrestamo.UseVisualStyleBackColor = false;
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bibliosoft.Properties.Resources.fondo_bibliosoft_1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 977);
            this.Controls.Add(this.buttonUpdatePrestamo);
            this.Controls.Add(this.labelGestionarL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messagee);
            this.Controls.Add(this.comboBoxBooks);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.messagealert);
            this.Controls.Add(this.messageIdBook);
            this.Controls.Add(this.messageIdUser);
            this.Controls.Add(this.message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAgregarUsuarioPrestamo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtIdBook);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonVolverPrest);
            this.DoubleBuffered = true;
            this.Name = "FormPrestamos";
            this.Text = "PRESTAMOS✍️";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverPrest;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonAgregarUsuarioPrestamo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label messageIdUser;
        private System.Windows.Forms.Label messageIdBook;
        private System.Windows.Forms.Label messagealert;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.Label messagee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGestionarL;
        private System.Windows.Forms.Button buttonUpdatePrestamo;
    }
}