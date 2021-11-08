using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using gestion_financiera.Models;
using gestion_financiera.Data;
using Microsoft.AspNetCore.Http;



namespace gestion_financiera.Controllers
{
    public class LoginController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        public LoginController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(usuario o)
        {
            try
            {
                var usuario = (from c in _context.usuario where (c.email == o.email && c.password == o.password) select c.nombres).Single();
                Console.WriteLine("Los datos son correctos");
                HttpContext.Session.SetString("User", usuario);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, los datos son incorrectos");
                Console.WriteLine(e);
                return View("Login");
            }
        }

        
        public IActionResult Logout()
        {
              HttpContext.Session.Clear();
              return RedirectToAction("Index", "Home");

        }


    }
}