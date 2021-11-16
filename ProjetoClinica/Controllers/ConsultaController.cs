using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly DataContext dataContext;

        public ConsultaController(DataContext dc)
        {
            dataContext = dc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MConsulta consulta)
        {
            if (ModelState.IsValid == false)
            {

                ViewBag.TipoMensagem = "Erro";
                ViewBag.Mensagem = "Dados incorretos";
            }
            else
            {
                dataContext.TBConsulta.Add(consulta);
                dataContext.SaveChanges();

                TempData["TipoMensagem"] = "SUCESSO";
                TempData["Mensagem"] = "Usuário cadastrado com sucesso";


            }

            return RedirectToAction("Index");


        }
    }
}
