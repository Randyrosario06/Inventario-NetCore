using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Services;
using WebApplication4.ViewModel;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class PersonasController : Controller
    {
        
        private IMenuData _menuData;
        

        public PersonasController(IMenuData menuData)
        {
            _menuData = menuData;
        }

       
        [HttpGet]
        public IActionResult Login()
        {
           
                return View();
            
               
        }

        [HttpPost]
        public IActionResult Login(Personas u)
        {
          
            var us = u.Usuario;
            var pas = u.Pass;
            if (us != null && pas != null)
            {
                if (_menuData.GetU(u) != null)
                {
                    if(_menuData.GetT(u) != null)
                    {
                        
                        return RedirectToAction("Menu", "Menu");
                    }
                    else
                    {
                        return RedirectToAction(nameof(Registrarse));
                    }
  
                }
                else
                {
                    return RedirectToAction(nameof(Login));
                }
            }
            else
            {
                return RedirectToAction(nameof(Login));
            }
        }
       
       
        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrarse(PersonaEdit model)
        {
            if (ModelState.IsValid)
            {
                var newPersona = new Personas();
                newPersona.Nombre = model.Nombre;
                newPersona.Apellido = model.Apellido;
                newPersona.Usuario = model.Usuario;
                newPersona.Pass = model.Pass;
                _menuData.AddP(newPersona);

                return RedirectToAction("Menu", "Menu");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult NuevoC()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevoC(ClientesEdit model)
        {
            var newC = new Clientes();
            newC.Cedula = model.Cedula;
            newC.Nombre = model.Nombre;
            newC.Apellido = model.Apellido;
            _menuData.AddC(newC);
           return RedirectToAction(nameof(Clientes));
        }

        public IActionResult Clientes()
        {
            var model = new InicioViewClientes();
            model.clientes = _menuData.GetC();
            return View(model);
        }
    }
}
