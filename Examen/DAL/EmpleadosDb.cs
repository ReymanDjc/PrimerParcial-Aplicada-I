using Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Examen.DAL
{
    public class EmpleadosDb : DbContext
    {

        public EmpleadosDb() : base("ConStr")
        {

        }

        public DbSet<Empleados> Empleado { get; set; }
    }
}
