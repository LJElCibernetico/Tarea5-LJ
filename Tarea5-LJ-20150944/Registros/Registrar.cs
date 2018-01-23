using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea5_LJ_20150944.BLL;
using Tarea5_LJ_20150944.Consultas;
using Tarea5_LJ_20150944.Entidades;

namespace Tarea5_LJ_20150944.Registros
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            if(txtNombre.Text == String.Empty)
            {
                errorProvider1.SetError(txtNombre, "MMG");
            }
            else
            {
                Estudiantes estudiante = LlenaClase();
                if (EstudiantesBLL.Guardar(estudiante))
                    MessageBox.Show("Guardooooooo!!!!!");
            }
           
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.InscripcionID = 0;
            estudiante.EstudianteID = 0;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Monto = int.Parse(txtMonto.Text);
            estudiante.Balance = int.Parse(txtBalance.Text);
            estudiante.Observaciones = txtObservaciones.Text;
            estudiante.Fecha = dtpFecha.Text;
            return estudiante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
        }
    }
}
