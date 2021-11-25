using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{

    [Table("Cotizacion")]
    public class cotizacion
    {
        [Key]
        public int IdCotizacion { get; set; }
        //[ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }
        public DateTime FechaCotizacion { get; set;  }
        public string Estado { get; set;  }
    }
}