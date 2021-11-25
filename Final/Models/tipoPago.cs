using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{

    [Table("TipoPago")]
    public class tipoPago
    {

        [Key]
        public int IdTipoPago { get; set; }
        public string TipoPago { get; set; }
    }
}