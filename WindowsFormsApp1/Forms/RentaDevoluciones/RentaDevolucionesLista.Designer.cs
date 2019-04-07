namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    partial class RentaDevolucionesLista
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rentaDevolucionesTableAdapter = new WindowsFormsApp1.AUDIOVISUALDataSet7TableAdapters.RentaDevolucionesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aUDIOVISUALDataSet7 = new WindowsFormsApp1.AUDIOVISUALDataSet7();
            this.rentaDevolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOVISUALDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(78, 25);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear renta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rentaDevolucionesTableAdapter
            // 
            this.rentaDevolucionesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.empleadoIdDataGridViewTextBoxColumn,
            this.equipoIdDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.rentaDevolucionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 244);
            this.dataGridView1.TabIndex = 3;
            // 
            // aUDIOVISUALDataSet7
            // 
            this.aUDIOVISUALDataSet7.DataSetName = "AUDIOVISUALDataSet7";
            this.aUDIOVISUALDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentaDevolucionesBindingSource
            // 
            this.rentaDevolucionesBindingSource.DataMember = "RentaDevoluciones";
            this.rentaDevolucionesBindingSource.DataSource = this.aUDIOVISUALDataSet7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            this.empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Id";
            this.empleadoIdDataGridViewTextBoxColumn.HeaderText = "Empleado_Id";
            this.empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            // 
            // equipoIdDataGridViewTextBoxColumn
            // 
            this.equipoIdDataGridViewTextBoxColumn.DataPropertyName = "Equipo_Id";
            this.equipoIdDataGridViewTextBoxColumn.HeaderText = "Equipo_Id";
            this.equipoIdDataGridViewTextBoxColumn.Name = "equipoIdDataGridViewTextBoxColumn";
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            // 
            // RentaDevolucionesLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTipo);
            this.Name = "RentaDevolucionesLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentaDevolucionesLista";
            this.Load += new System.EventHandler(this.RentaDevolucionesLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOVISUALDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDevolucionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button button1;
        private AUDIOVISUALDataSet7TableAdapters.RentaDevolucionesTableAdapter rentaDevolucionesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AUDIOVISUALDataSet7 aUDIOVISUALDataSet7;
        private System.Windows.Forms.BindingSource rentaDevolucionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}