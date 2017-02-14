using Examen.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosRegistroForm per = new EmpleadosRegistroForm();
            per.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Consultas.EmpleadosConsulta per = new UI.Consultas.EmpleadosConsulta();
            per.Show();
        }
    }
}
