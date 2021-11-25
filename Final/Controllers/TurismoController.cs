using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class TurismoController : Controller
    {

        private portalTuristicoDbConexion _contexto = new portalTuristicoDbConexion();
        // GET: Turismo
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult usuario()
        {
            //var UsuarioList = from i in _contexto.usuario
            //                  select i;
            //if (UsuarioList.Count() > 0)
            //{
            //    return View("listadoUsuarios", UsuarioList);
            //}
            //return View("listadoUsuarios", UsuarioList);
            var usuarioLista = _contexto.usuario.ToList();
            return View(usuarioLista);
            //return View("listadousuarios", usuarioLista);
        }

        public ActionResult Create()
        {
            var UsuarioList = from i in _contexto.usuario
                              select i;
            return View("usuario", UsuarioList);
        }

        [HttpPost]
        public ActionResult Alta(usuarioModel usuarioCrear)
        {
            _contexto.usuario.Add(usuarioCrear);
            _contexto.SaveChanges();
            //return Content("Guardado");
            return RedirectToAction("usuario");
            //var usuarioLista = _contexto.usuario.ToList();
            //return View("listadoUsuarios", usuarioLista);
        }

        [HttpGet]
        public ActionResult Details (int id) 
        { 
            var usuario = _contexto.usuario.Find(id);

            return View(usuario);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var usuario = _contexto.usuario.Find(id);
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Edit(usuarioModel usuarioModificado)
        {
            var usuario = _contexto.usuario.Find(usuarioModificado.IdUsuario);

            usuario.Nombres = usuarioModificado.Nombres;
            usuario.Apellidos = usuarioModificado.Apellidos;
            usuario.Contraseña = usuarioModificado.Contraseña;
            usuario.Telefono = usuarioModificado.Telefono;
            usuario.Correo = usuarioModificado.Correo;

            _contexto.Entry(usuario).State = EntityState.Modified;
            _contexto.SaveChanges();

            var usuarioLista = _contexto.usuario.ToList();
            return View("listadoUsuarios", usuarioLista);
        }

        public ActionResult departamento()
        {
            var departamento = _contexto.departamento.ToList();
            return View(departamento);
        }

        [HttpGet]
        public ActionResult editdep(int id)
        {
            var departamento = _contexto.departamento.Find(id);
            return View(departamento);
        }

        [HttpGet]
        public ActionResult Detailsdep(int id)
        {
            var departamento = _contexto.departamento.Find(id);
            return View(departamento);
        }
        [HttpPost]
        public ActionResult editdep(departamento departamentoModificado)
        {
            var departamento = _contexto.departamento.Find(departamentoModificado.IdDepartamento);

            departamento.Departamento = departamentoModificado.Departamento;

            _contexto.Entry(departamento).State = EntityState.Modified;
            _contexto.SaveChanges();

            var departamentoLista = _contexto.departamento.ToList();
            return View("editdep", departamentoLista);
        }
        [HttpPost]
        public ActionResult Alta5(departamento departamentoCrear)
        {
            _contexto.departamento.Add(departamentoCrear);
            _contexto.SaveChanges();
            return RedirectToAction("departamento");
            //return View("Guardado");
        }

        public ActionResult categorias()
        {
            var categoriasLista = _contexto.categoria.ToList();
            return View(categoriasLista);
            //return View();
        }

        [HttpPost]
        public ActionResult Alta6(categorias categoriasCrear)
        {
            _contexto.categoria.Add(categoriasCrear);
            _contexto.SaveChanges();
            return RedirectToAction("categorias");
            //return View("Guardado");
        }

        [HttpGet]
        public ActionResult editcat(int id)
        {
            var categoria = _contexto.categoria.Find(id);
            return View(categoria);
        }

        [HttpGet]
        public ActionResult Detailscat(int id)
        {
            var categoria = _contexto.categoria.Find(id);
            return View(categoria);
        }
        [HttpPost]
        public ActionResult editcat(categorias categoriaModificado)
        {
            var categoria = _contexto.categoria.Find(categoriaModificado.IdCategoria);

            categoria.Categoria = categoriaModificado.Categoria;

            _contexto.Entry(categoria).State = EntityState.Modified;
            _contexto.SaveChanges();

            var categoriaLista = _contexto.categoria.ToList();
            return View("categoria", categoriaLista);
        }

        public ActionResult detalleReservacion()
        {
            return View();
        }

        public ActionResult tipoPago()
        {
            return View();
        }
        public ActionResult tour()
        {

            var tourLis = _contexto.tour.ToList();
            return View(tourLis);

            //var tourList = from i in _contexto.tour
            //               join d in _contexto.departamento on i.IdDepartamento equals d.IdDepartamento
            //               join c in _contexto.categoria on i.IdCategoria equals c.IdCategoria
            //               select new
            //               {
            //                   i.IdTour,
            //                   d.IdDepartamento,
            //                   c.IdCategoria,
            //                   i.NombreTour,
            //                   i.Descripcion,
            //                   i.Servicios,
            //                   i.PrecioAdultos,
            //                   i.PrecioNiños,
            //                   i.Estado
            //               };
            //if (tourList.Count() > 0)
            //{
            //    return View("listadoTour", tourList);
            //}
            //return View("listadoTour", tourLis);
            //return View();
        }

        public ActionResult Create2()
        {
            var tourList = from i in _contexto.tour
                          join d in _contexto.departamento on i.IdDepartamento equals d.IdDepartamento
                          join c in _contexto.categoria on i.IdCategoria equals c.IdCategoria
                          select new
                          {
                              i.IdTour,
                              d.IdDepartamento,
                              c.IdCategoria,
                              i.NombreTour,
                              i.Descripcion,
                              i.Servicios,
                              i.PrecioAdultos,
                              i.PrecioNiños,
                              i.Estado
                          };
            if (tourList.Count() > 0)
            {
                return View("tour", tourList);
            }
            return View("tour", tourList);
        }
        [HttpPost]
        public ActionResult Alta2(tour tourCrear)
        {
            _contexto.tour.Add(tourCrear);
            _contexto.SaveChanges();
            //return Content("Guardado");
            return RedirectToAction("tour");

        }

        [HttpGet]
        public ActionResult Details2 (int id)
        {
            var tour = _contexto.tour.Find(id);
            return View(tour);
        }

        [HttpGet]
        public ActionResult Edit2(int id)
        {
            var tour = _contexto.tour.Find(id);
            return View(tour);
        }

        [HttpPost]
        public ActionResult Edit2(tour tourModificado)
        {
            var tour = _contexto.tour.Find(tourModificado.IdTour);

            tour.Descripcion = tourModificado.Descripcion;
            tour.Servicios = tourModificado.Servicios;

            _contexto.Entry(tour).State = EntityState.Modified;
            _contexto.SaveChanges();

            var tourLista = _contexto.tour.ToList();
            return View("listadoTour", tourLista);
        }

        public ActionResult detalleCotizacion()
        {
            return View();
        }


        public ActionResult reservaciones()
        {
            var reservacionesLista = _contexto.reservaciones.ToList();
            return View(reservacionesLista);
        }

        [HttpPost]
        public ActionResult Alta3(reservaciones reservacionCrear)
        {
            _contexto.reservaciones.Add(reservacionCrear);
            _contexto.SaveChanges();
            return RedirectToAction("reservaciones");
            //return Content("Guardado");
        }

        [HttpGet]
        public ActionResult editreser(int id)
        {
            var reservacion = _contexto.reservaciones.Find(id);
            return View(reservacion);
        }

        [HttpGet]
        public ActionResult Detailsreser(int id)
        {
            var reservacion = _contexto.reservaciones.Find(id);
            return View(reservacion);
        }
        [HttpPost]
        public ActionResult editreser(reservaciones reservacionModificado)
        {
            var reservacion = _contexto.reservaciones.Find(reservacionModificado.IdReservacion);

            reservacion.FechaReservacion = reservacionModificado.FechaReservacion;
            reservacion.FechaFinalizacion = reservacionModificado.FechaFinalizacion;
            reservacion.CantidadAdultos = reservacion.CantidadAdultos;
            reservacion.CantidadNiños = reservacion.CantidadNiños;

            _contexto.Entry(reservacion).State = EntityState.Modified;
            _contexto.SaveChanges();

            var reservacionLista = _contexto.reservaciones.ToList();
            return View("editreser", reservacionLista);
        }

        public ActionResult cotizacion()
        {
            var cotizacionLista = _contexto.cotizacion.ToList();
            return View(cotizacionLista);
        }

        [HttpPost]
        public ActionResult Alta4(cotizacion cotizacionCrear)
        {
            _contexto.cotizacion.Add(cotizacionCrear);
            _contexto.SaveChanges();
            //return Content("Guardado Exitosamente");
            return RedirectToAction("cotizacion");
        }


    }
}