using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class AgendaController : Controller
    {
        private readonly DataContext dataContext;

        public AgendaController(DataContext dc) => dataContext = dc;


        public IActionResult Index()
        {
            return View();
        }
    }
}
