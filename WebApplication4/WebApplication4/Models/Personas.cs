using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
    }
}
