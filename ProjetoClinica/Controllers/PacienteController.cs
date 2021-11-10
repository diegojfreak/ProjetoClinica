using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class PacienteController : Controller
    {
        private readonly DataContext context;

        public PacienteController(DataContext dc)
        {
            context = dc;
        }

        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public async Task<ActionResult> Salvar(MPaciente paciente)
		{
			if (ModelState.IsValid)
			{
				try
				{
					context.TBPaciente.Add(paciente);
					await context.SaveChangesAsync();

					return Ok(true);
				}
				catch
				{
					return BadRequest("Erro ao salvar o Paciente");
				}
			}

			return BadRequest("Dados inválidos");
		}
	}
}
