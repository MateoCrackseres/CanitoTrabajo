namespace bibliotecadb.vista.Prestamos
{
    partial class modificarPrestamos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEjemplar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLector = new System.Windows.Forms.TextBox();
            this.dtgPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idprestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idejemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.txtBuscar2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscar2.Location = new System.Drawing.Point(63, 208);
            this.txtBuscar2.Multiline = true;
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(203, 80);
            this.txtBuscar2.TabIndex = 105;
            this.txtBuscar2.Text = "Ingrese el ID del Prestamo que quiere Modificar";
            this.txtBuscar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscar2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar2_MouseClick);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.Location = new System.Drawing.Point(63, 294);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(203, 94);
            this.btnBuscar2.TabIndex = 104;
            this.btnBuscar2.Text = "Buscar Prestamo";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 26);
            this.button2.TabIndex = 103;
            this.button2.Text = "REINICIAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(868, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 26);
            this.btnBuscar.TabIndex = 102;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.Location = new System.Drawing.Point(782, 133);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(80, 26);
            this.txtBuscar.TabIndex = 101;
            this.txtBuscar.Text = "Ingrese ID";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(322, 133);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 26);
            this.btnEliminar.TabIndex = 100;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(58, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 97;
            this.label5.Text = "Fecha Entrega";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.txtFechaEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrega.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFechaEntrega.Location = new System.Drawing.Point(63, 354);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(203, 27);
            this.txtFechaEntrega.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(58, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 95;
            this.label4.Text = "Fecha Prestamo";
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.txtFechaPrestamo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPrestamo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFechaPrestamo.Location = new System.Drawing.Point(63, 291);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(203, 27);
            this.txtFechaPrestamo.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(58, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 93;
            this.label3.Text = "ID Ejemplar";
            // 
            // txtIdEjemplar
            // 
            this.txtIdEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.txtIdEjemplar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEjemplar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdEjemplar.Location = new System.Drawing.Point(63, 228);
            this.txtIdEjemplar.Name = "txtIdEjemplar";
            this.txtIdEjemplar.Size = new System.Drawing.Size(203, 27);
            this.txtIdEjemplar.TabIndex = 92;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(63, 408);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(203, 94);
            this.btnModificar.TabIndex = 91;
            this.btnModificar.Text = "Modificar Prestamo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(58, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "ID Lector";
            // 
            // txtIdLector
            // 
            this.txtIdLector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(201)))), ((int)(((byte)(250)))));
            this.txtIdLector.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdLector.Location = new System.Drawing.Point(63, 165);
            this.txtIdLector.Name = "txtIdLector";
            this.txtIdLector.Size = new System.Drawing.Size(203, 27);
            this.txtIdLector.TabIndex = 89;
            // 
            // dtgPrestamos
            // 
            this.dtgPrestamos.AllowUserToAddRows = false;
            this.dtgPrestamos.AllowUserToDeleteRows = false;
            this.dtgPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dtgPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprestamo,
            this.idlector,
            this.idejemplar,
            this.fechaprestamo,
            this.fechaentrega});
            this.dtgPrestamos.Location = new System.Drawing.Point(322, 165);
            this.dtgPrestamos.Name = "dtgPrestamos";
            this.dtgPrestamos.ReadOnly = true;
            this.dtgPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPrestamos.Size = new System.Drawing.Size(642, 394);
            this.dtgPrestamos.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(840, 77);
            this.label1.TabIndex = 87;
            this.label1.Text = "MODIFICAR UN PRESTAMO";
            // 
            // idprestamo
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idprestamo.DefaultCellStyle = dataGridViewCellStyle21;
            this.idprestamo.HeaderText = "ID";
            this.idprestamo.Name = "idprestamo";
            this.idprestamo.ReadOnly = true;
            // 
            // idlector
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlector.DefaultCellStyle = dataGridViewCellStyle22;
            this.idlector.HeaderText = "ID Lector";
            this.idlector.Name = "idlector";
            this.idlector.ReadOnly = true;
            // 
            // idejemplar
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idejemplar.DefaultCellStyle = dataGridViewCellStyle23;
            this.idejemplar.HeaderText = "ID Ejemplar";
            this.idejemplar.Name = "idejemplar";
            this.idejemplar.ReadOnly = true;
            // 
            // fechaprestamo
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaprestamo.DefaultCellStyle = dataGridViewCellStyle24;
            this.fechaprestamo.HeaderText = "Fecha Prestamo";
            this.fechaprestamo.Name = "fechaprestamo";
            this.fechaprestamo.ReadOnly = true;
            this.fechaprestamo.Width = 150;
            // 
            // fechaentrega
            // 
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaentrega.DefaultCellStyle = dataGridViewCellStyle25;
            this.fechaentrega.HeaderText = "Fecha Entrega";
            this.fechaentrega.Name = "fechaentrega";
            this.fechaentrega.ReadOnly = true;
            this.fechaentrega.Width = 150;
            // 
            // modificarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.txtBuscar2);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdEjemplar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdLector);
            this.Controls.Add(this.dtgPrestamos);
            this.Controls.Add(this.label1);
            this.Name = "modificarPrestamos";
            this.Size = new System.Drawing.Size(1022, 576);
            this.Load += new System.EventHandler(this.modificarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEjemplar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdLector;
        private System.Windows.Forms.DataGridView dtgPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlector;
        private System.Windows.Forms.DataGridViewTextBoxColumn idejemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentrega;
        private System.Windows.Forms.Label label1;
    }
}
