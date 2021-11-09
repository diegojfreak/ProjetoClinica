using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using ProjetoClinica.Models;

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

		[HttpPost]
		public async Task<ActionResult> Salvar(MMedico medico)
		{
			if (ModelState.IsValid)
			{
				try
				{
					context.TBMedico.Add(medico);
					await context.SaveChangesAsync();

					return Ok(true);
				}
				catch
				{
					return BadRequest("Erro ao salvar o Médico");
				}
			}

			return BadRequest("Dados inválidos");
		}

	}
}
