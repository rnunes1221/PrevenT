using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreventWebMVC.Data;
using PreventWebMVC.Models;
using PreventWebMVC.Services;
using PreventWebMVC.Controllers;
using PreventWebMVC.Models.ViewModels;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using PreventWebMVC.Services.Exceptions;


namespace PreventWebMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly PreventWebMVCContext _context;

        public LoginController(PreventWebMVCContext context)
        {
            _context = context;


        }
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
               return Redirect("/computers"); ;
            }
            return View();
        }


      



        //Metodo Create in Tela
        public IActionResult Create()
        {

            return View();
           
        }


        //Metodo Create Post

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Username,Senha")] Login login)
        {
            if (ModelState.IsValid)
            {
                _context.Add(login);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(login);
        }

        //Rotina para verificar os parametros de login/validar retorna mensagem com o status da validação
        [HttpPost]
        public async Task<IActionResult> Logar(string username, string senha, bool manterlogado)
        {
           
             
            Console.WriteLine(username);
            Console.WriteLine(senha);
            Console.WriteLine(manterlogado);
            MySqlConnection mySqlConnection = new MySqlConnection("server=localhost; database=preventwebmvcdb;uid=developer;password=rmhuuadm");
           await mySqlConnection.OpenAsync();
            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = $"SELECT * FROM login WHERE Username='{username}' AND senha='{senha}'";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
           
            
                if(await reader.ReadAsync())
                {
                    int usuarioId = reader.GetInt32(0);
                    string nome = reader.GetString(1);

                    List<Claim> direitosAcesso = new List<Claim>
                    {
                    new Claim(ClaimTypes.NameIdentifier,usuarioId.ToString()),
                    new Claim(ClaimTypes.Name,nome)
                    };

                    var identity = new ClaimsIdentity(direitosAcesso, "Identity.Login");
                    var userPrincipal = new ClaimsPrincipal(new[] { identity });
                    await HttpContext.SignInAsync(userPrincipal,
                    new AuthenticationProperties
                    {
                        IsPersistent = manterlogado,
                        //mantem logado por 1 hora
                        ExpiresUtc=DateTime.Now.AddHours(1)
                    });

             
                    return Redirect("/computers");
            }
                
            
            return Json(new { Msg = "Usuario Não Encontrado Verifique suas credenciais" });
        }

        //rotina para fazer o Logout
        public async Task<IActionResult> Logout()
        {
            if(User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
