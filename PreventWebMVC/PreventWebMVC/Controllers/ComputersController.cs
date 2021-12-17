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
using System.Net;
using Newtonsoft.Json;
using System.IO;


namespace PreventWebMVC.Controllers
{
    public class ComputersController : Controller
    {
        public static PreventWebMVCContext _context;



        public ComputersController(PreventWebMVCContext context)
        {
            _context = context;


        }

        // GET: Computers
        public async Task<IActionResult> Index()
        {
            //rotina de verificação para validar que o usuario só tenha acesso a esse Index se tiver logado.
            if (User.Identity.IsAuthenticated)
            {
                var computer = Services.ComputerService.GetPC();
                return View(computer);
            }
            
                return Redirect("/login");



            
            // return View(await _context.Computer.ToListAsync());
        }
 

        // GET: Computers


        // GET: Computers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message = "id not provided" });
            }

            var computer = await _context.Computer
              .FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {

                return RedirectToAction(nameof(Error), new { message = "id not found" });
            }

            return View(computer);
        }

        // GET: Computers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Computers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Ip,Processor,User,OpSystem,Domain,Tag")] Computer computer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computer);
        }

        // GET: Computers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "id not found" });
            }
            var computer = await _context.Computer.FindAsync(id);
            if (computer == null)
            {
                return RedirectToAction(nameof(Error), new { message = "id not provided" });
            }
            return View(computer);
        }

        // POST: Computers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Ip,Processor,User,OpSystem,Domain,Tag")] Computer computer)
        {
            if (id != computer.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputerExists(computer.Id))
                    {
                        return RedirectToAction(nameof(Error), new { message = "id not found" });
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(computer);
        }

        // GET: Computers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computer = await _context.Computer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computer == null)
            {
                return NotFound();
            }

            return View(computer);
        }

        // POST: Computers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computer = await _context.Computer.FindAsync(id);
            _context.Computer.Remove(computer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputerExists(int id)
        {
            return _context.Computer.Any(e => e.Id == id);
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


    }


}
