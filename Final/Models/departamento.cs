using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Final.Models
{
    [Table("Departamento")]
    public class departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string Departamento { get; set; }
    }
}