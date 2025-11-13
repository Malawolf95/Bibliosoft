namespace Bibliosoft
{
    partial class FormUsuarios
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
            this.buttonVolver1 = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.labelUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdUser = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.buttonBuscarUsuario = new System.Windows.Forms.Button();
            this.buttonActualizarUsuario = new System.Windows.Forms.Button();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.messageIdUser = new System.Windows.Forms.Label();
            this.messageNameUser = new System.Windows.Forms.Label();
            this.messagePhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGestionarL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver1
            // 
            this.buttonVolver1.BackColor = System.Drawing.Color.Transparent;
            this.buttonVolver1.FlatAppearance.BorderSize = 0;
            this.buttonVolver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonVolver1.Location = new System.Drawing.Point(218, 664);
            this.buttonVolver1.Name = "buttonVolver1";
            this.buttonVolver1.Size = new System.Drawing.Size(202, 45);
            this.buttonVolver1.TabIndex = 0;
            this.buttonVolver1.Text = "< Volver al menú";
            this.buttonVolver1.UseVisualStyleBackColor = false;
            this.buttonVolver1.Click += new System.EventHandler(this.buttonVolver1_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(280, 333);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(525, 333);
            this.dgvBook.TabIndex = 12;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelUsers.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUsers.Location = new System.Drawing.Point(274, 289);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(130, 30);
            this.labelUsers.TabIndex = 13;
            this.labelUsers.Text = "USUARIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(860, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(860, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(860, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono";
            // 
            // textIdUser
            // 
            this.textIdUser.Location = new System.Drawing.Point(991, 283);
            this.textIdUser.Name = "textIdUser";
            this.textIdUser.Size = new System.Drawing.Size(259, 22);
            this.textIdUser.TabIndex = 17;
            this.textIdUser.TextChanged += new System.EventHandler(this.textIdUser_TextChanged);
            this.textIdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(991, 323);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(259, 22);
            this.textName.TabIndex = 18;
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(991, 368);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(259, 22);
            this.textPhone.TabIndex = 19;
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(630, 34);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 20;
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAgregarUsuario.Image = global::Bibliosoft.Properties.Resources.icons8_símbolo_más_18;
            this.buttonAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(1046, 434);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(204, 43);
            this.buttonAgregarUsuario.TabIndex = 21;
            this.buttonAgregarUsuario.Text = "Agregar Usuario";
            this.buttonAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregarUsuario.UseVisualStyleBackColor = false;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // buttonBuscarUsuario
            // 
            this.buttonBuscarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscarUsuario.Image = global::Bibliosoft.Properties.Resources.icons8_búsqueda_18;
            this.buttonBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscarUsuario.Location = new System.Drawing.Point(1046, 488);
            this.buttonBuscarUsuario.Name = "buttonBuscarUsuario";
            this.buttonBuscarUsuario.Size = new System.Drawing.Size(204, 43);
            this.buttonBuscarUsuario.TabIndex = 22;
            this.buttonBuscarUsuario.Text = "Buscar Usuario";
            this.buttonBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscarUsuario.UseVisualStyleBackColor = false;
            this.buttonBuscarUsuario.Click += new System.EventHandler(this.buttonBuscarUsuario_Click);
            // 
            // buttonActualizarUsuario
            // 
            this.buttonActualizarUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonActualizarUsuario.Image = global::Bibliosoft.Properties.Resources.icons8_aprobar_y_actualizar_18__1_;
            this.buttonActualizarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActualizarUsuario.Location = new System.Drawing.Point(1046, 543);
            this.buttonActualizarUsuario.Name = "buttonActualizarUsuario";
            this.buttonActualizarUsuario.Size = new System.Drawing.Size(204, 43);
            this.buttonActualizarUsuario.TabIndex = 23;
            this.buttonActualizarUsuario.Text = "Actualizar Usuario";
            this.buttonActualizarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonActualizarUsuario.UseVisualStyleBackColor = false;
            this.buttonActualizarUsuario.Click += new System.EventHandler(this.buttonActualizarUsuario_Click);
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEliminarUsuario.Image = global::Bibliosoft.Properties.Resources.icons8_basura_18;
            this.buttonEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(1046, 593);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(204, 43);
            this.buttonEliminarUsuario.TabIndex = 24;
            this.buttonEliminarUsuario.Text = "Eliminar Usuario";
            this.buttonEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // messageIdUser
            // 
            this.messageIdUser.AutoSize = true;
            this.messageIdUser.BackColor = System.Drawing.Color.Transparent;
            this.messageIdUser.Location = new System.Drawing.Point(1061, 250);
            this.messageIdUser.Name = "messageIdUser";
            this.messageIdUser.Size = new System.Drawing.Size(0, 16);
            this.messageIdUser.TabIndex = 25;
            // 
            // messageNameUser
            // 
            this.messageNameUser.AutoSize = true;
            this.messageNameUser.BackColor = System.Drawing.Color.Transparent;
            this.messageNameUser.Location = new System.Drawing.Point(1025, 329);
            this.messageNameUser.Name = "messageNameUser";
            this.messageNameUser.Size = new System.Drawing.Size(0, 16);
            this.messageNameUser.TabIndex = 26;
            // 
            // messagePhone
            // 
            this.messagePhone.AutoSize = true;
            this.messagePhone.BackColor = System.Drawing.Color.Transparent;
            this.messagePhone.Location = new System.Drawing.Point(1025, 354);
            this.messagePhone.Name = "messagePhone";
            this.messagePhone.Size = new System.Drawing.Size(0, 16);
            this.messagePhone.TabIndex = 27;
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
            this.label5.TabIndex = 28;
            this.label5.Text = "BIBLIOSOFT";
            // 
            // labelGestionarL
            // 
            this.labelGestionarL.AutoSize = true;
            this.labelGestionarL.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionarL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelGestionarL.Location = new System.Drawing.Point(930, 219);
            this.labelGestionarL.Name = "labelGestionarL";
            this.labelGestionarL.Size = new System.Drawing.Size(284, 31);
            this.labelGestionarL.TabIndex = 29;
            this.labelGestionarL.Text = "GESTIONAR USUARIOS";
            this.labelGestionarL.Click += new System.EventHandler(this.labelGestionarL_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bibliosoft.Properties.Resources.fondo_bibliosoft_1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 977);
            this.Controls.Add(this.labelGestionarL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messagePhone);
            this.Controls.Add(this.messageNameUser);
            this.Controls.Add(this.messageIdUser);
            this.Controls.Add(this.buttonEliminarUsuario);
            this.Controls.Add(this.buttonActualizarUsuario);
            this.Controls.Add(this.buttonBuscarUsuario);
            this.Controls.Add(this.buttonAgregarUsuario);
            this.Controls.Add(this.message);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textIdUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.buttonVolver1);
            this.DoubleBuffered = true;
            this.Name = "FormUsuarios";
            this.Text = "USUARIOS👤";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdUser;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.Button buttonBuscarUsuario;
        private System.Windows.Forms.Button buttonActualizarUsuario;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.Label messageIdUser;
        private System.Windows.Forms.Label messageNameUser;
        private System.Windows.Forms.Label messagePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGestionarL;
    }
}