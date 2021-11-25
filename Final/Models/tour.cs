using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{
    [Table("Tour")]
    public class tour
    {
        [Key]
        public int IdTour { get; set; }
        //[ForeignKey("IdDepartamento")]
        public int IdDepartamento { get; set; }
        //[ForeignKey("IdCategoria")]
        public int IdCategoria { get; set; }
        public string NombreTour { get; set; }
        public string Descripcion { get; set; }
        public string Servicios { get; set; }
        public decimal PrecioAdultos { get; set; }
        public decimal PrecioNiños { get; set; }
        public string Estado { get; set; }
    }
}