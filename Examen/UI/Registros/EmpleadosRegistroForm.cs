using Examen.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen.UI.Registros
{
    public partial class EmpleadosRegistroForm : Form
    {
        public EmpleadosRegistroForm()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var guardar = new Empleados();
            
            guardar.EmpleadoId = Utilidades.TOINT(empleadoIdTextBox.Text);
            guardar.Nombres = nombreTextBox.Text;
            guardar.FechaNacimiento = fechaDateTimePicker.Value.Date;
            guardar.Sueldo = Utilidades.TOINT(sueldoTextBox.Text);

           /*if (!Validar())
           {
                MessageBox.Show("Por favor llenar los campos vacios.");
           }
            else if (BLL.EmpleadosBLL.Guardar(guardar))
            {
                MessageBox.Show("Persona guardada con exito.");
            }*/

            BLL.EmpleadosBLL.Guardar(guardar);


            Limpiar();
        }

        private void EmpleadosRegistroForm_Load(object sender, EventArgs e)
        {
        }

        private void Limpiar()
        {
            empleadoIdTextBox.Clear();
            nombreTextBox.Clear();
            fechaDateTimePicker.Value = DateTime.Today;
            sueldoTextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var eliminar = BLL.EmpleadosBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));

            if (eliminar != null)
            {
                BLL.EmpleadosBLL.Eliminar(eliminar);
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la persona.");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var buscar = BLL.EmpleadosBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));

            if (buscar != null)
            {
                nombreTextBox.Text = buscar.Nombres;
                //fechaDateTimePicker.Text = buscar.FechaNacimiento.ToString();
            }
            else
            {
                MessageBox.Show("Empleado No Existente");
            }
        }

        /*private bool Validar()
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                ErrorProvider.SetError(nombreTextBox, "Por favor digitar su nombre.");
                return false;
            }

            return true;
        }*/

    }
}
    
    



