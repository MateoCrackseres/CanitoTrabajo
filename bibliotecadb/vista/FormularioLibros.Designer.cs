namespace bibliotecadb.vista
{
    partial class FormularioLibros
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
            this.dataGridlibros = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridlibros
            // 
            this.dataGridlibros.AllowUserToAddRows = false;
            this.dataGridlibros.AllowUserToDeleteRows = false;
            this.dataGridlibros.AllowUserToOrderColumns = true;
            this.dataGridlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridlibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.ismn,
            this.nombre,
            this.tipo,
            this.editorial,
            this.autor});
            this.dataGridlibros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridlibros.Location = new System.Drawing.Point(0, 221);
            this.dataGridlibros.Name = "dataGridlibros";
            this.dataGridlibros.ReadOnly = true;
            this.dataGridlibros.Size = new System.Drawing.Size(800, 229);
            this.dataGridlibros.TabIndex = 0;
            // 
            // IdLibro
            // 
            this.IdLibro.HeaderText = "ID";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            // 
            // ismn
            // 
            this.ismn.HeaderText = "ISBN";
            this.ismn.Name = "ismn";
            this.ismn.ReadOnly = true;
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
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridlibros);
            this.Name = "FormularioLibros";
            this.Text = "FormularioLibros";
            this.Load += new System.EventHandler(this.FormularioLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridlibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridlibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
    }
}