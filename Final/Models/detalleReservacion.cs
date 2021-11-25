using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{

    [Table("DetalleReservacion")]
    public class detalleReservacion
    {

        [Key]
        public int IdReservacion { get; set; }
        //[ForeignKey("IdTour")]
        public int IdTour { get; set; }
    }
}