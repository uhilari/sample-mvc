using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var lista = new Models.DetalleItem[]
            {
                new Models.DetalleItem {Codigo = "01", Descripcion = "Titulo 1", Tipo = 1},
                new Models.DetalleItem {Codigo = "A0001", Descripcion = "Detalle 1", Tipo = 2},
                new Models.DetalleItem {Codigo = "A0002", Descripcion = "Detalle 2", Tipo = 2},
                new Models.DetalleItem {Codigo = "A0003", Descripcion = "Detalle 3", Tipo = 2},
                new Models.DetalleItem {Codigo = "A0004", Descripcion = "Detalle 4", Tipo = 2},
                new Models.DetalleItem {Codigo = "02", Descripcion = "Titulo 2", Tipo = 1},
                new Models.DetalleItem {Codigo = "A0005", Descripcion = "Detalle 5", Tipo = 2},
                new Models.DetalleItem {Codigo = "A0006", Descripcion = "Detalle 6", Tipo = 2},
            };
            return View(lista);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}