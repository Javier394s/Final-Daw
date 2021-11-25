using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final.Models
{
    public class portalTuristicoDbConexion :DbContext
    {
        public portalTuristicoDbConexion() : base("portalTuristicoDbConexion")
        {

        }

        public DbSet<usuarioModel> usuario { get; set; }
        public DbSet<tour> tour { get; set; }
        public DbSet<reservaciones> reservaciones { get; set; }
        public DbSet<cotizacion> cotizacion { get; set; }
        public DbSet<departamento> departamento { get; set; }
        public DbSet<categorias> categoria { get; set; }
        public DbSet<tipoPago> tipoPago { get; set;  }
        public DbSet<detalleReservacion> detalleReservacio { get; set; }
        public DbSet<detalleCotizacion> detalleCotizacion { get; set;  }
    }
}