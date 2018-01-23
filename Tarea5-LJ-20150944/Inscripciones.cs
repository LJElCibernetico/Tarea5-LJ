using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarea5_LJ_20150944.Consultas;
using Tarea5_LJ_20150944.Registros;

namespace Tarea5_LJ_20150944
{
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
        }
    }
}
