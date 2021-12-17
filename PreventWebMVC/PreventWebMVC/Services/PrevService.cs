using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PreventWebMVC.Models;
using PreventWebMVC.Data;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PreventWebMVC.Services.Exceptions;
using Newtonsoft.Json;
using System.Net;


namespace PreventWebMVC.Services
{
    public class PrevService
    {
        private readonly PreventWebMVCContext _context;

        public PrevService(PreventWebMVCContext context)
        {
            _context = context;
        }



        //metodo que calcula a data das preventivas e verifica se esta entre 5 e 6 meses de diferença com a data atual

        public List<Prev> DateCalcAlert()
        {
            List<Prev> teste = new List<Prev>();
            List<Prev> prevalert = new List<Prev>();
            List<Prev> prevok = new List<Prev>();
            List<Prev> prevdelay = new List<Prev>();

            foreach (Prev prev in _context.Prev)
            {

                var result = DateTime.Now.Subtract(prev.Date);
                var total = result.TotalDays / 30;
                if (total >= 5 && total <= 6)
                {

                    teste.Add(prev);

                }
                else if (total <= 5)
                {

                    teste.Add(prev);

                }
                else if (total >= 6)
                {

                    teste.Add(prev);

                }

            }
            return teste;
        }



        //metodo que retorna os Id's em Ordem Crescente

        public List<Prev> FindAll()
        {
            return _context.Prev.OrderBy(x => x.Id).ToList();
        }
        public List<Computer> FindAllGetPC()
        {
            List<Computer> result = new List<Computer>();
            return result = ComputerService.GetPC().OrderBy(x => x.Id).ToList();
        }



        public void Insert(Prev obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }

        //Metodo para procurar no context os Id 
        public Prev FindById(int id)
        {
            return _context.Prev.Include(obj => obj.Computer).FirstOrDefault(obj => obj.Id == id);
        }



        public void Remove(int id)
        {
            try
            {
                var obj = _context.Prev.Find(id);
                _context.Prev.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }

        }
        public void Update(Prev obj)
        {
            if (!_context.Prev.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");

            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

    }
}
