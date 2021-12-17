using Microsoft.EntityFrameworkCore;
using PreventWebMVC.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PreventWebMVC.Models;
using PreventWebMVC.Data;

namespace PreventWebMVC.Services
{
    public class LoginService
    {
        private readonly PreventWebMVCContext _context;

        public LoginService(PreventWebMVCContext context)
        {
            _context = context;
        }

        //metodo para retornar todos os usuarios em uma lista
        public List<Login> FindAll()
        {
            return _context.Login.OrderBy(x => x.Username).ToList();
        }


        public void Insert(Login obj)
        {
      
            _context.Add(obj);
            _context.SaveChanges();
        }

        //Metodo para procurar no context os Id 
        public Login FindById(int id)
        {
            return _context.Login.Include(obj => obj.Id).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _context.Login.Find(id);
                _context.Login.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }

        }
        public void Update(Login obj)
        {
            if (!_context.Login.Any(x => x.Id == obj.Id))
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
