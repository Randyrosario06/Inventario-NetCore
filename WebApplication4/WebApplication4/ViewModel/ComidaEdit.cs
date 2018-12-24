using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class ComidaEdit
    {
        [Required, MinLength(3)]
        public String Nombre { get; set; }
        public int Precio { get; set; }
        public TiposPlatos Platos { get; set; }
        public string Descripcion { get; set; }
    }
}
