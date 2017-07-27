using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CalculadoraPrestamos.Models;

namespace CalculadoraPrestamos.DAL
{
    public class GeneralContext : DbContext
    {

        public GeneralContext() : base("CalculadoraPrestamos") { }

        public DbSet<Cliente> Clientes{ get; set; }

        public DbSet<Prestamos> Prestamos { get; set; }
    }
}