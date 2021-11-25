using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{
    [Table("Reservacion")]
    public class reservaciones
    {
        [Key]
        public int IdReservacion { get; set; }
        //[ForeignKey("IdUsuario")]
        public int Idusuario { get; set; }
        //[ForeignKey("IdTipoPago")]
        public int IdTipoPago { get; set; }
        public DateTime FechaReservacion { get; set;  }
        public DateTime FechaFinalizacion { get; set;  }
        public int CantidadAdultos { get; set; }
        public int CantidadNiños { get; set; }
        public string Estado { get; set;  }
    }
}