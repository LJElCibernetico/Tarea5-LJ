using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Tarea5_LJ_20150944.DAL;
using Tarea5_LJ_20150944.Entidades;

namespace Tarea5_LJ_20150944.BLL
{
    class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Estudiante.Add(estudiante);
                contex.SaveChanges();

                paso = true;
            }

            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(estudiante).State = EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static bool Eliminar(int inscripcionesId)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var estudiante = contex.Estudiante.Find(inscripcionesId);

                contex.Estudiante.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Estudiantes Buscar(int inscripcionesId)
        {
            Estudiantes estudiante = new Estudiantes();

            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Estudiante.Find(inscripcionesId);
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterioBusqueda)
        {
            List<Estudiantes> estudiante = new List<Estudiantes>();
            try
            {
                Contexto contex = new Contexto();
                estudiante = contex.Estudiante.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }


    }
}
