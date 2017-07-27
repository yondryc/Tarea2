using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraPrestamos.Models
{
    public class Prestamos
    {
        public int Id { get; set; }
        public long Capital { get; set; }
        public decimal Intereses { get; set; }
        public decimal Periodo { get; set; }
        public int ClientesId { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}