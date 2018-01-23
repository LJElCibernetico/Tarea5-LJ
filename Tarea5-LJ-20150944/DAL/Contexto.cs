using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Tarea5_LJ_20150944.Entidades;

namespace Tarea5_LJ_20150944.DAL
{
        public class Contexto : DbContext
        {
            public DbSet<Estudiantes> Estudiante { get; set; }

            public Contexto() : base("ConStr")
            {

            }
        }
}
