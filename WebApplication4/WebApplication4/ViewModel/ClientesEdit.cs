using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewModel
{
    public class ClientesEdit
    {
        
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Required]
        public string Cedula { get; set; }

    }
}
