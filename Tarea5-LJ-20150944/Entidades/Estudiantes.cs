using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea5_LJ_20150944.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int InscripcionID { get; set;}
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public int Monto { get; set; }
        public int Balance { get; set; }
        public string Observaciones { get; set; }

        public Estudiantes()
        {
            this.InscripcionID = 0;
            this.EstudianteID = 0;
            this.Nombre = String.Empty;
            this.Fecha = String.Empty;
            this.Monto = 0;
            this.Balance = 0;
            this.Observaciones = String.Empty;
        }

        public Estudiantes(int nInscripcionID, int nEstudianteID,string nNombre, string nFecha, int nMonto, int nBalance, string nObservaciones)
        {
            InscripcionID = nInscripcionID;
            EstudianteID = nEstudianteID;
            Nombre = nNombre;
            Fecha = nFecha;
            Monto = nMonto;
            Balance = nBalance;
            Observaciones = nObservaciones;
        }

    }
}
