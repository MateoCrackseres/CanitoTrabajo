namespace bibliotecadb.vista
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPuntito = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSugerencia = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPedir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.idlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPuntito
            // 
            this.lblPuntito.AutoSize = true;
            this.lblPuntito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntito.ForeColor = System.Drawing.Color.Red;
            this.lblPuntito.Location = new System.Drawing.Point(314, 73);
            this.lblPuntito.Name = "lblPuntito";
            this.lblPuntito.Size = new System.Drawing.Size(16, 20);
            this.lblPuntito.TabIndex = 40;
            this.lblPuntito.Text = "*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(469, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Volver al menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(182, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 20);
            this.button2.TabIndex = 38;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ingresa tu DNI antes de realizar la operacion";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(29, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCatalogo.Location = new System.Drawing.Point(470, 9);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(108, 39);
            this.lblCatalogo.TabIndex = 34;
            this.lblCatalogo.Text = "Catalogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID:";
            this.label4.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReload.Enabled = false;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(419, 169);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(72, 44);
            this.btnReload.TabIndex = 32;
            this.btnReload.Text = "Recargar libros";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBusqueda.Enabled = false;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusqueda.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(419, 123);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(72, 40);
            this.btnBusqueda.TabIndex = 31;
            this.btnBusqueda.Text = "Iniciar busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Visible = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Buscar libro por ID";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(437, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Visible = false;
            // 
            // lblSugerencia
            // 
            this.lblSugerencia.AutoSize = true;
            this.lblSugerencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugerencia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSugerencia.Location = new System.Drawing.Point(372, 312);
            this.lblSugerencia.Name = "lblSugerencia";
            this.lblSugerencia.Size = new System.Drawing.Size(172, 38);
            this.lblSugerencia.TabIndex = 28;
            this.lblSugerencia.Text = "Selecciona un libro en la tabla\r\npara poder pedirlo";
            this.lblSugerencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSugerencia.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(469, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 40);
            this.button4.TabIndex = 27;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPedir.Enabled = false;
            this.btnPedir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedir.Location = new System.Drawing.Point(419, 219);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(72, 44);
            this.btnPedir.TabIndex = 26;
            this.btnPedir.Text = "Pedir libro";
            this.btnPedir.UseVisualStyleBackColor = false;
            this.btnPedir.Visible = false;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "BIENVENIDO AL SISTEMA!";
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dtgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlibro,
            this.isbn,
            this.nombre,
            this.tipo,
            this.editorial,
            this.autor,
            this.cantidad});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatos.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgDatos.Enabled = false;
            this.dtgDatos.Location = new System.Drawing.Point(590, 0);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(740, 493);
            this.dtgDatos.TabIndex = 24;
            this.dtgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDatos_CellClick_1);
            // 
            // idlibro
            // 
            this.idlibro.HeaderText = "ID";
            this.idlibro.Name = "idlibro";
            this.idlibro.ReadOnly = true;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // editorial
            // 
            this.editorial.HeaderText = "Editorial";
            this.editorial.Name = "editorial";
            this.editorial.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Disponibles";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1330, 493);
            this.Controls.Add(this.lblPuntito);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCatalogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSugerencia);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPedir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPuntito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSugerencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}