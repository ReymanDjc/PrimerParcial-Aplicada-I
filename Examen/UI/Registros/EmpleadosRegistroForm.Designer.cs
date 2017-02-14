namespace Examen.UI.Registros
{
    partial class EmpleadosRegistroForm
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
            System.Windows.Forms.Label empleadodLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label sueldoLabel;
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.empleadoIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            empleadodLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(204, 147);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(112, 147);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 19;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 148);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(204, 24);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 17;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // empleadodLabel
            // 
            empleadodLabel.AutoSize = true;
            empleadodLabel.Location = new System.Drawing.Point(12, 30);
            empleadodLabel.Name = "empleadodLabel";
            empleadodLabel.Size = new System.Drawing.Size(69, 13);
            empleadodLabel.TabIndex = 11;
            empleadodLabel.Text = "Empleado Id:";
            // 
            // empleadoIdTextBox
            // 
            this.empleadoIdTextBox.Location = new System.Drawing.Point(83, 27);
            this.empleadoIdTextBox.Name = "empleadoIdTextBox";
            this.empleadoIdTextBox.Size = new System.Drawing.Size(108, 20);
            this.empleadoIdTextBox.TabIndex = 12;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 56);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(52, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombres:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(79, 53);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 14;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(12, 83);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(93, 13);
            fechaLabel.TabIndex = 15;
            fechaLabel.Text = "FechaNacimiento:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(112, 79);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.fechaDateTimePicker.TabIndex = 16;
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(12, 109);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 21;
            sueldoLabel.Text = "Sueldo:";
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.Location = new System.Drawing.Point(61, 105);
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(146, 20);
            this.sueldoTextBox.TabIndex = 22;
            // 
            // EmpleadosRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 186);
            this.Controls.Add(this.sueldoTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(empleadodLabel);
            this.Controls.Add(this.empleadoIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "EmpleadosRegistroForm";
            this.Text = "EmpleadosRegistroForm";
            this.Load += new System.EventHandler(this.EmpleadosRegistroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox empleadoIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox sueldoTextBox;
    }
}