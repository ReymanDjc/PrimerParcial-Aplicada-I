using Examen.DAL;
using Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Examen.BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Empleados e)
        {
            using (var db = new EmpleadosDb())
            {
                try
                {
                    if (Buscar(e.EmpleadoId) == null)
                    {
                        db.Empleado.Add(e);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        db.Entry(e).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }

                }
                catch (Exception)
                {

                    //throw;
                }

            }

            return false;
        }
         

        public static Empleados Buscar(int id)
        {
            var buscar = new Empleados();

            using (var db = new EmpleadosDb())
            {
                try
                {
                    buscar = db.Empleado.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return buscar;
        }


        public static bool Eliminar(Empleados persona)
        {
            using (var db = new EmpleadosDb())
            {
                try
                {
                    db.Entry(persona).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return false;
        }

    }
}
