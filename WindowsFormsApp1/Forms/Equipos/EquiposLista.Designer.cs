namespace WindowsFormsApp1.Forms.Equipos
{
    partial class EquiposLista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEquipoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoConexionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aUDIOVISUALDataSet2 = new WindowsFormsApp1.AUDIOVISUALDataSet2();
            this.equiposTableAdapter = new WindowsFormsApp1.AUDIOVISUALDataSet2TableAdapters.EquiposTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOVISUALDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.noSerialDataGridViewTextBoxColumn,
            this.tipoEquipoIdDataGridViewTextBoxColumn,
            this.marcaIdDataGridViewTextBoxColumn,
            this.modeloIdDataGridViewTextBoxColumn,
            this.tipoConexionIdDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.equiposBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // noSerialDataGridViewTextBoxColumn
            // 
            this.noSerialDataGridViewTextBoxColumn.DataPropertyName = "NoSerial";
            this.noSerialDataGridViewTextBoxColumn.HeaderText = "NoSerial";
            this.noSerialDataGridViewTextBoxColumn.Name = "noSerialDataGridViewTextBoxColumn";
            // 
            // tipoEquipoIdDataGridViewTextBoxColumn
            // 
            this.tipoEquipoIdDataGridViewTextBoxColumn.DataPropertyName = "TipoEquipo_Id";
            this.tipoEquipoIdDataGridViewTextBoxColumn.HeaderText = "TipoEquipo_Id";
            this.tipoEquipoIdDataGridViewTextBoxColumn.Name = "tipoEquipoIdDataGridViewTextBoxColumn";
            // 
            // marcaIdDataGridViewTextBoxColumn
            // 
            this.marcaIdDataGridViewTextBoxColumn.DataPropertyName = "Marca_Id";
            this.marcaIdDataGridViewTextBoxColumn.HeaderText = "Marca_Id";
            this.marcaIdDataGridViewTextBoxColumn.Name = "marcaIdDataGridViewTextBoxColumn";
            // 
            // modeloIdDataGridViewTextBoxColumn
            // 
            this.modeloIdDataGridViewTextBoxColumn.DataPropertyName = "Modelo_Id";
            this.modeloIdDataGridViewTextBoxColumn.HeaderText = "Modelo_Id";
            this.modeloIdDataGridViewTextBoxColumn.Name = "modeloIdDataGridViewTextBoxColumn";
            // 
            // tipoConexionIdDataGridViewTextBoxColumn
            // 
            this.tipoConexionIdDataGridViewTextBoxColumn.DataPropertyName = "TipoConexion_Id";
            this.tipoConexionIdDataGridViewTextBoxColumn.HeaderText = "TipoConexion_Id";
            this.tipoConexionIdDataGridViewTextBoxColumn.Name = "tipoConexionIdDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.aUDIOVISUALDataSet2;
            // 
            // aUDIOVISUALDataSet2
            // 
            this.aUDIOVISUALDataSet2.DataSetName = "AUDIOVISUALDataSet2";
            this.aUDIOVISUALDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear equipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Volver a inicio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EquiposLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EquiposLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquiposLista";
            this.Load += new System.EventHandler(this.EquiposLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOVISUALDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AUDIOVISUALDataSet2 aUDIOVISUALDataSet2;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private AUDIOVISUALDataSet2TableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEquipoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoConexionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}