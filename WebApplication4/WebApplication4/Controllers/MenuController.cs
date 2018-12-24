using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Services;
using WebApplication4.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    public class MenuController : Controller
    {
       
        private IMenuData _menudata;

        public MenuController(IMenuData menudata)
        {
            _menudata = menudata;
        }

        public IActionResult Detalles(int id)
        {
            var model = _menudata.Get(id);
            return View(model);
        }

       
        
        [HttpGet]
        public IActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nuevo(ComidaEdit model)
        {
           
            if (ModelState.IsValid)
            {
                var newComida = new Comidas();
                newComida.Nombre = model.Nombre;
                newComida.Precio = model.Precio;
                newComida.Platos = model.Platos;
                newComida.Descripcion = model.Descripcion;
                _menudata.Add(newComida);

                return RedirectToAction(nameof(Nuevo));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Menu()
        {
            if (_menudata.Logged()) {
                var model = new InicioViewModel();
                model.comidas = _menudata.GetAll();
                return View(model);
            }
            else
            {
                return RedirectToAction("Personas", "Login");
            }
            
        }

        public IActionResult Deleted(int id)
        {
            _menudata.DeleteO(id);
            return RedirectToAction("Delete");
        }

        
        public IActionResult Delete()
        {
            var model = new InicioViewModel();
           model.comidas = _menudata.GetAll();
            return View(model);
        }

        public IActionResult Arroz()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetArroz();
            return View(model);
        }

        public IActionResult Legumbre()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetLegumbre();
            return View(model);

        }
        public IActionResult Carne()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetCarne();
            return View(model);

        }
        public IActionResult Ensalada()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetEnsalada();
            return View(model);

        }
        public IActionResult ComidaFrita()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetFreida();
            return View(model);

        }
        public IActionResult Postre()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetPostre();
            return View(model);

        }
        public IActionResult Sopa()
        {
            var model = new InicioViewModel();
            model.comidas = _menudata.GetSopa();
            return View(model);

        }
    }
}
