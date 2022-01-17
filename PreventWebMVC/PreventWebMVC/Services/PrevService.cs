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



        //metodo que calcula a data das preventivas e verifica se esta entre 5 e 6 meses de diferença com a data atual e salva em uma tabela
        public List<Tables> DateCalcAlert()
        {
            List<Prev> teste = new List<Prev>();
            List<Prev> prevalert = new List<Prev>();
            List<Prev> prevok = new List<Prev>();
            List<Prev> prevdelay = new List<Prev>();


            //consulta com LINQ para trazer a Preventiva mais recente de cada Preventiva 
            var db1= from c in _context.Prev
                                  group c by c.ComputerId into grp
                                  select grp.OrderByDescending(c => c.Date).FirstOrDefault();
            
            
          
            //foreach para percorrer cada preventiva na query e fazer retornar para cada condição
            foreach (Prev prev in db1)
            {
                //faz o calculo em meses de cada manutenção Preventiva
                var result = DateTime.Now.Subtract(prev.Date);
                var total = result.TotalDays / 30;
                
                //1 condição: se a ultima manutenção preventiva está entre 5 e 6 meses
                if (total >= 5 && total <= 6)
                {
                    prevalert.Add(prev);
                }

                //2 condição: se a ultima manutenção preventiva está entre 0 e 5 meses
                else if (total <= 5)
                {
                    prevok.Add(prev);
                }

                //3 condição: se a ultima manutenção preventiva passou de 6 meses
                else if (total >= 6)
                {
                    prevdelay.Add(prev);
                }


            }
            //Adiciona na Model Tables que possuem as três tabelas: prevdelay,prevalert e prevok
            List<Tables> tables = new List<Tables>();
            Tables table1 = new Tables();
            table1.prevdelay = prevdelay;
            table1.prevalert = prevalert;
            table1.prevok = prevok;
            tables.Add(table1);
            return tables;
        }

        //metodo que retorna os Id's em Ordem Crescente
        public List<Prev> FindAll()
        {
            return _context.Prev.OrderBy(x => x.Id).ToList();  
        }

        //metodo que Insere no banco a Preventiva
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

        //Metodo para Remover do banco a Preventiva
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

        //Metodo para dar Update na Preventiva
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


        //metodo que retornam as datas das preventivas em ordem descrescente por Data
        public async Task<List<Prev>> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Prev select obj;
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Id)
                .Include(x => x.ComputerId)
                .OrderByDescending(X => X.Date)
                .ToListAsync();
        }


    }
}
