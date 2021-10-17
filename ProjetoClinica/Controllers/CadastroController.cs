using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class CadastroController : Controller
    {
        private readonly DataContext dataContext;

        public CadastroController(DataContext dc)
        {
            dataContext = dc;
        }

        //Requisição para exibir a página
        public IActionResult Create()
        {
            return View();
        }

        //Requisição do botão "submit"
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MLogin login)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.TipoMensagem = "ERRO";
                ViewBag.Mensagem = "Os dados preenchidos estão incorretos";

                return View();
            }
            else
            {
                dataContext.TBLogin.Add(login);
                dataContext.SaveChanges();

                TempData["TipoMensagem"] = "SUCESSO";
                TempData["Mensagem"] = "Usuário cadastrado com sucesso";

                return RedirectToAction("Index");
            }
        }

        public IActionResult Index()
        {
            List<MLogin> lista = dataContext.TBLogin.ToList();
            return View(lista);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MLogin login)
        {
            if (login == null)
                return RedirectToAction("Index");
            else
            {
                if (login.Email == null)
                    login.Email = "";

                List<MLogin> lista = dataContext.TBLogin.Where(x => x.Email.ToUpper().Contains(login.Email.ToUpper())).ToList();

                return View(lista);

                //var lista2 =
                //    from Livro l in dataContext.Livros
                //    where l.Titulo.ToUpper().Contains(livro.Titulo.ToUpper())
                //    select l;

                //return View(lista2.ToList());
            }
        }
    }
}
