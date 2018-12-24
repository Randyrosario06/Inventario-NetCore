using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("Clientes")]
        public Personas ClienteFk { get; set; }
        [ForeignKey("Comidas")]
        public Comidas ComidaFk { get; set; }
    }
}
