using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ProjetoClinica.Data;
using ProjetoClinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext context;

        public LoginController(DataContext dc)
        {
            context = dc;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroController()
        {
            return View("~/Views/Cadastro/Index.cshtml");
        }

        public IActionResult Novo() 
        {
            return View("~/Views/Cadastro/Create.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MLogin login)
        {
            if (ModelState.IsValid)
            {
                Hash hs = new Hash(SHA256.Create());
                string senhacripto = hs.CriptografarSenha(login.Senha);
                bool fazerLogin = context.TBLogin.Any(x => x.Email == login.Email && x.Senha == login.Senha);

                if (fazerLogin == true)
                {
                    MLogin usuarioBanco = context.TBLogin.FirstOrDefault(x => x.Email == login.Email);

                    List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Sid, usuarioBanco.ID.ToString()),
                new Claim(ClaimTypes.Name, usuarioBanco.Email),
                new Claim(ClaimTypes.Role, "A"),
            };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        IsPersistent = true,
                    };

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return RedirectToAction("Index", "Home");
                }
            }

            ViewBag.Erro = "Usuário e/ou senha inválidos";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Salvar(MLogin login)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Hash hs = new Hash(SHA256.Create());
                    login.Senha = hs.CriptografarSenha(login.Senha);
                    context.TBLogin.Add(login);
                    await context.SaveChangesAsync();

                    return View();
                }
                catch
                {
                    return BadRequest("Erro ao salvar o Usuário");
                }
            }

            return BadRequest("Dados inválidos");
        }

        
    }

    public class Hash
    {
        private HashAlgorithm _algoritmo;

        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var sb = new StringBuilder();
            foreach (var caractere in encryptedPassword)
            {
                sb.Append(caractere.ToString("X2"));
            }

            return sb.ToString() == senhaCadastrada;
        }
    }
}