namespace bibliotecadb.vista
{
    partial class AdministrarModificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.idlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODIFICAR UN LIBRO";
            // 
            // dtgDatos
            // 
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
            this.autor});
            this.dtgDatos.Location = new System.Drawing.Point(81, 217);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(642, 230);
            this.dtgDatos.TabIndex = 3;
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
            // AdministrarModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.label1);
            this.Name = "AdministrarModificar";
            this.Text = "AdministrarModificar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
    }
}