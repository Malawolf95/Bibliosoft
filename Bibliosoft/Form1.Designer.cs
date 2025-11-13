namespace Bibliosoft
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLibros = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPrestamos = new System.Windows.Forms.Button();
            this.buttonDevoluciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonMultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(539, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIBLIOSOFT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLibros
            // 
            this.buttonLibros.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibros.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLibros.Image = global::Bibliosoft.Properties.Resources.icons8_literatura_21;
            this.buttonLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibros.Location = new System.Drawing.Point(509, 290);
            this.buttonLibros.Name = "buttonLibros";
            this.buttonLibros.Padding = new System.Windows.Forms.Padding(12, 8, 8, 8);
            this.buttonLibros.Size = new System.Drawing.Size(310, 60);
            this.buttonLibros.TabIndex = 2;
            this.buttonLibros.Text = "LIBROS";
            this.buttonLibros.UseVisualStyleBackColor = false;
            this.buttonLibros.Click += new System.EventHandler(this.buttonLibros_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Bibliosoft.Properties.Resources.icons8_usuario_21;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(509, 369);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12);
            this.button2.Size = new System.Drawing.Size(310, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "USUARIOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPrestamos
            // 
            this.buttonPrestamos.BackColor = System.Drawing.Color.Peru;
            this.buttonPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrestamos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrestamos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrestamos.Image = global::Bibliosoft.Properties.Resources.icons8_lista_de_ingredientes_21;
            this.buttonPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrestamos.Location = new System.Drawing.Point(509, 445);
            this.buttonPrestamos.Name = "buttonPrestamos";
            this.buttonPrestamos.Padding = new System.Windows.Forms.Padding(12);
            this.buttonPrestamos.Size = new System.Drawing.Size(310, 60);
            this.buttonPrestamos.TabIndex = 4;
            this.buttonPrestamos.Text = "PRESTAMOS";
            this.buttonPrestamos.UseVisualStyleBackColor = false;
            this.buttonPrestamos.Click += new System.EventHandler(this.buttonPrestamos_Click);
            // 
            // buttonDevoluciones
            // 
            this.buttonDevoluciones.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevoluciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevoluciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDevoluciones.Image = global::Bibliosoft.Properties.Resources.icons8_sincronización_de_conexión_21;
            this.buttonDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevoluciones.Location = new System.Drawing.Point(509, 520);
            this.buttonDevoluciones.Name = "buttonDevoluciones";
            this.buttonDevoluciones.Padding = new System.Windows.Forms.Padding(12);
            this.buttonDevoluciones.Size = new System.Drawing.Size(310, 60);
            this.buttonDevoluciones.TabIndex = 5;
            this.buttonDevoluciones.Text = "DEVOLUCIONES";
            this.buttonDevoluciones.UseVisualStyleBackColor = false;
            this.buttonDevoluciones.Click += new System.EventHandler(this.buttonDevoluciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 876);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miguel Ángel Henao, Catalina Carrasquilla  - Bibliosoft | Todos los derechos rese" +
    "ervados 2025©.";
            // 
            // botonMultas
            // 
            this.botonMultas.BackColor = System.Drawing.Color.Purple;
            this.botonMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMultas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonMultas.Image = global::Bibliosoft.Properties.Resources.icons8_error_21;
            this.botonMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMultas.Location = new System.Drawing.Point(509, 594);
            this.botonMultas.Name = "botonMultas";
            this.botonMultas.Padding = new System.Windows.Forms.Padding(12);
            this.botonMultas.Size = new System.Drawing.Size(310, 60);
            this.botonMultas.TabIndex = 7;
            this.botonMultas.Text = "MULTAS";
            this.botonMultas.UseVisualStyleBackColor = false;
            this.botonMultas.Click += new System.EventHandler(this.botonMultas_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Bibliosoft.Properties.Resources.fondo_bibliosoft_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 901);
            this.Controls.Add(this.botonMultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDevoluciones);
            this.Controls.Add(this.buttonPrestamos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLibros);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormInicio";
            this.Text = "📖 BIBLIOSOFT 📖";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLibros;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPrestamos;
        private System.Windows.Forms.Button buttonDevoluciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonMultas;
    }
}

