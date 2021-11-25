using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{

    [Table("Categoria")]
    public class categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
    }
}