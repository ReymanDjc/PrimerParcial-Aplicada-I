namespace Examen.UI.Consultas
{
    partial class EmpleadosConsulta
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
            this.FiltrarTextboxbutton = new System.Windows.Forms.Button();
            this.FiltrartextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarFechabutton = new System.Windows.Forms.Button();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ListadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrarTextboxbutton
            // 
            this.FiltrarTextboxbutton.Location = new System.Drawing.Point(314, 17);
            this.FiltrarTextboxbutton.Name = "FiltrarTextboxbutton";
            this.FiltrarTextboxbutton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarTextboxbutton.TabIndex = 16;
            this.FiltrarTextboxbutton.Text = "Filtrar";
            this.FiltrarTextboxbutton.UseVisualStyleBackColor = true;
            this.FiltrarTextboxbutton.Click += new System.EventHandler(this.FiltrarTextboxbutton_Click);
            // 
            // FiltrartextBox
            // 
            this.FiltrartextBox.Location = new System.Drawing.Point(139, 20);
            this.FiltrartextBox.Name = "FiltrartextBox";
            this.FiltrartextBox.Size = new System.Drawing.Size(100, 20);
            this.FiltrartextBox.TabIndex = 15;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre",
            "Fecha"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(12, 19);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrarcomboBox.TabIndex = 14;
            this.FiltrarcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrarcomboBox_SelectedIndexChanged);
            // 
            // FiltrarFechabutton
            // 
            this.FiltrarFechabutton.Location = new System.Drawing.Point(321, 59);
            this.FiltrarFechabutton.Name = "FiltrarFechabutton";
            this.FiltrarFechabutton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarFechabutton.TabIndex = 13;
            this.FiltrarFechabutton.Text = "Filtrar";
            this.FiltrarFechabutton.UseVisualStyleBackColor = true;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(214, 64);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.HastadateTimePicker.TabIndex = 12;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(63, 63);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.DesdedateTimePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta:";
            // 
            // ListadataGridView
            // 
            this.ListadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadataGridView.Location = new System.Drawing.Point(17, 103);
            this.ListadataGridView.Name = "ListadataGridView";
            this.ListadataGridView.Size = new System.Drawing.Size(379, 182);
            this.ListadataGridView.TabIndex = 9;
            // 
            // EmpleadosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 309);
            this.Controls.Add(this.FiltrarTextboxbutton);
            this.Controls.Add(this.FiltrartextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.FiltrarFechabutton);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListadataGridView);
            this.Name = "EmpleadosConsulta";
            this.Text = "EmpleadosConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.ListadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FiltrarTextboxbutton;
        private System.Windows.Forms.TextBox FiltrartextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button FiltrarFechabutton;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ListadataGridView;
    }
}