using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class PersonaEdit
    {
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoPersona Tipo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pass { get; set; }
    }
}
