using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CalculadoraPrestamos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [StringLength(60)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(60)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(100)]
        public string Direccion { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }
    }
}