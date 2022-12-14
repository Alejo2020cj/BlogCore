using BlogCore.AccesoDatos.Data.Repository;
using BlogCore.Models;
using BlogCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogCore.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                Slider = _contenedorTrabajo.Slider.GetAll(),
                ListaArticulos = _contenedorTrabajo.Articulo.GetAll()
            };
            return View(homeVm);
        }
        public IActionResult Details(int id)
        { 
          var articuloDedesDb = _contenedorTrabajo.Articulo.GetFirstOrDefault(a=> a.Id == id);
            return View(articuloDedesDb);

        }
    }
}
