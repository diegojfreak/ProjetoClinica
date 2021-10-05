using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MLogin login)
        {
            if (ModelState.IsValid)
                return Ok($"Tentou fazer login com o e-mail {login.Email} e a senha {login.Senha}");
            else
                return View();

        }
    }
}
