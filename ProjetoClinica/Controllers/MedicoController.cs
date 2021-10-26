using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;

namespace ProjetoClinica.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DataContext context;

        public MedicoController(DataContext dc)
        {
            context = dc;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
