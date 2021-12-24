using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PreventWebMVC.Services;
using PreventWebMVC.Models.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PreventWebMVC.Data;
using PreventWebMVC.Models;
using PreventWebMVC.Services.Exceptions;
using System.Diagnostics;

namespace PreventWebMVC.Controllers
{
    public class PrevsController : Controller
    {
        //Criando Objetos do tipo Service
        private readonly PrevService _prevService;
        private readonly ComputerService _computerService;
        public PrevsController(ComputerService computerService, PrevService prevService)
        {
            _prevService = prevService;
            _computerService = computerService;
        }

        //metodo que verifica se o usuario esta logado. Se não estiver logado redireciona para a tela de login
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var list = _prevService.FindAll();
                return View(list);
            }
            return Redirect("/login");
            

            
        }

        //Metodo Create in Tela
        public IActionResult Create()
        {
            var computers = _computerService.FindAll();

            var viewModel = new PrevFormViewModel { Computers = computers };
            return View(viewModel);
        }


        //Metodo Create Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Prev prev)
        {
        
            _prevService.Insert(prev);
            return RedirectToAction(nameof(Index));
        }

        //Metodo Delete in Tela
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _prevService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        //metodo Delete POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                _prevService.Remove(id);
                return RedirectToAction(nameof(Index));

            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }
        //metodo Details In tela
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _prevService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        //metodo edit in tela
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _prevService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            List<Computer> computers = _computerService.FindAll();
            PrevFormViewModel viewModel = new PrevFormViewModel { Prev = obj, Computers = computers };
            return View(viewModel);
        }



        //metodo Edit POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Prev prev)
        {
            if (id != prev.Id)
            {
                return BadRequest();
            }
            try
            {
                _prevService.Update(prev);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }


        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier


            };
            return View(viewModel);
        }

     



        public IActionResult Monitor()
        {

            var prevs = _prevService.DateCalcAlert();
           

            return View(prevs);
           

        }
    }
}
