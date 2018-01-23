using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea5_LJ_20150944.BLL;
using Tarea5_LJ_20150944.DAL;
using Tarea5_LJ_20150944.Entidades;

namespace Tarea5_LJ_20150944.Consultas
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            if (cbFiltrar.SelectedIndex == 0)
            {
                int id = 0;
                int.TryParse(txtCriterio.Text, out id);

                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.InscripcionID == id);
            }

            if (cbFiltrar.SelectedIndex == 1)
            {
                String s = txtCriterio.Text;

                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.Nombre == s);
            }

            if (cbFiltrar.SelectedIndex == 2)
            {
                //ponerlo en una funcion
                String s = txtCriterio.Text;
                
                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.Nombre == s);
            }

            if (cbFiltrar.SelectedIndex == 3)
            {
                //ponerlo en una funcion
                int monto = 0;
                int.TryParse(txtCriterio.Text, out monto);

                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.Monto == monto);
            }

            if (cbFiltrar.SelectedIndex == 4)
            {
                //ponerlo en una funcion
                int balance = 0;
                int.TryParse(txtCriterio.Text, out balance);

                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.Monto == balance);
            }

            if (cbFiltrar.SelectedIndex == 5)
            {
                //ponerlo en una funcion
                String s = txtCriterio.Text;

                dgvMostrar.DataSource = EstudiantesBLL.GetList(es => es.Observaciones == s);
            }

        }
    }
}
