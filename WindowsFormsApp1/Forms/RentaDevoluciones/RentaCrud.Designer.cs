namespace WindowsFormsApp1.Forms.RentaDevoluciones
{
    partial class RentaCrud
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
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(105, 177);
            this.cmbEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(127, 21);
            this.cmbEquipos.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Equipo";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(105, 149);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(127, 21);
            this.cmbUsuarios.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Usuario";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 19);
            this.button4.TabIndex = 54;
            this.button4.Text = "Volver a inicio";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(105, 124);
            this.cmbEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(127, 21);
            this.cmbEmpleados.TabIndex = 53;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 19);
            this.button3.TabIndex = 52;
            this.button3.Text = "Cerrar sesión";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 19);
            this.button1.TabIndex = 50;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtFechaPrestamo
            // 
            this.dtFechaPrestamo.Location = new System.Drawing.Point(151, 216);
            this.dtFechaPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaPrestamo.Name = "dtFechaPrestamo";
            this.dtFechaPrestamo.Size = new System.Drawing.Size(151, 20);
            this.dtFechaPrestamo.TabIndex = 48;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(105, 100);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(127, 20);
            this.txtComentario.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Fecha de prestamo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Comentario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Crear";
            // 
            // RentaCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtFechaPrestamo);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentaCrud";
            this.Text = "RentaCrud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtFechaPrestamo;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}