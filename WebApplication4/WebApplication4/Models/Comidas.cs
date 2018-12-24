using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Comidas
    {
        [Key]
        public int ComidaId { get; set; }

        [Display(Name = "Nombre del plato")]
        public String Nombre { get; set; }
        public int Precio { get; set; }
        [Display(Name = "Tipo de plato")]
        public TiposPlatos Platos { get; set; }
        public string Descripcion { get; set; }
    }
}
