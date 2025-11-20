namespace Bibliosoft
{
    partial class FormUsuariosApp
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBoxPerfil = new System.Windows.Forms.PictureBox();
            this.buttonPrestamos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDevoluciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(437, 298);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // pictureBoxPerfil
            // 
            this.pictureBoxPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPerfil.Location = new System.Drawing.Point(216, 209);
            this.pictureBoxPerfil.Name = "pictureBoxPerfil";
            this.pictureBoxPerfil.Size = new System.Drawing.Size(88, 105);
            this.pictureBoxPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPerfil.TabIndex = 1;
            this.pictureBoxPerfil.TabStop = false;
            // 
            // buttonPrestamos
            // 
            this.buttonPrestamos.BackColor = System.Drawing.Color.Peru;
            this.buttonPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrestamos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrestamos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrestamos.Image = global::Bibliosoft.Properties.Resources.icons8_lista_de_ingredientes_21;
            this.buttonPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrestamos.Location = new System.Drawing.Point(216, 353);
            this.buttonPrestamos.Name = "buttonPrestamos";
            this.buttonPrestamos.Padding = new System.Windows.Forms.Padding(12);
            this.buttonPrestamos.Size = new System.Drawing.Size(370, 60);
            this.buttonPrestamos.TabIndex = 11;
            this.buttonPrestamos.Text = "PRESTAR LIBROS";
            this.buttonPrestamos.UseVisualStyleBackColor = false;
            this.buttonPrestamos.Click += new System.EventHandler(this.buttonPrestamos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(344, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "BIBLIOSOFT";
            // 
            // buttonDevoluciones
            // 
            this.buttonDevoluciones.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevoluciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevoluciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDevoluciones.Image = global::Bibliosoft.Properties.Resources.icons8_sincronización_de_conexión_21;
            this.buttonDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevoluciones.Location = new System.Drawing.Point(216, 442);
            this.buttonDevoluciones.Name = "buttonDevoluciones";
            this.buttonDevoluciones.Padding = new System.Windows.Forms.Padding(12);
            this.buttonDevoluciones.Size = new System.Drawing.Size(370, 60);
            this.buttonDevoluciones.TabIndex = 9;
            this.buttonDevoluciones.Text = "DEVOLVER LIBROS";
            this.buttonDevoluciones.UseVisualStyleBackColor = false;
            this.buttonDevoluciones.Click += new System.EventHandler(this.buttonDevoluciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bienvenido, ";
            // 
            // FormUsuariosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bibliosoft.Properties.Resources.fondo_bibliosoft_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPrestamos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDevoluciones);
            this.Controls.Add(this.pictureBoxPerfil);
            this.Controls.Add(this.lblNombre);
            this.Name = "FormUsuariosApp";
            this.Text = "FormUsuariosApp";
            this.Load += new System.EventHandler(this.FormUsuariosApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBoxPerfil;
        private System.Windows.Forms.Button buttonPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDevoluciones;
        private System.Windows.Forms.Label label2;
    }
}