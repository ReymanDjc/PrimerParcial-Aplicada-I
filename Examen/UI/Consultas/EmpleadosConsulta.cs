using Examen.BLL;
using Examen.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen.UI.Consultas
{
    public partial class EmpleadosConsulta : Form
    {
        public EmpleadosConsulta()
        {
            InitializeComponent();
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FiltrarTextboxbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                int id = 0; ;
                int.TryParse(FiltrartextBox.Text, out id);

                if (id == 0)
                {
                    MessageBox.Show("Ingrese un Id");
                }
                else
                {
                    List<Empleados> lista = new List<Empleados>();
                    lista.Add(EmpleadosBLL.Buscar(Utilidades.TOINT(FiltrartextBox.Text)));
                    ListadataGridView.DataSource = lista;
                }
            }
        }
    }
}
