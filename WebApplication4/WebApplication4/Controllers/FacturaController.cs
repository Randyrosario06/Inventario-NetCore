using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class FacturaController: Controller
    {
        private IMenuData _menuData;

        public FacturaController(IMenuData menuData)
        {
            _menuData = menuData;   
        }

        [HttpGet]
        public IActionResult Factura()
        {
            return View();
        } 
    }
}
