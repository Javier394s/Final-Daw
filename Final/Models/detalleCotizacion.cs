using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{

    [Table("DetalleCotizacion")]
    public class detalleCotizacion
    {
        [Key]
        public int IdCotizacion { get; set; }
        //[ForeignKey("IdTour")]
        public int IdTour { get; set; }
    }
}