using Newtonsoft.Json;
using PreventWebMVC.Data;
using PreventWebMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PreventWebMVC.Services
{
    //Injeção de Dependencia para o metodo Context
    public class ComputerService
    {
        public static PreventWebMVCContext _context;

        public ComputerService(PreventWebMVCContext context)
        {
            _context = context;
        }

        //metodo que faz insert no banco
        public void Insert(Computer obj)
        {
            _context.Add(obj);
            _context.SaveChanges();

        }

        // metodo para pegar todos os computadores da API e retornar em uma lista
        public static List<Computer> GetPC()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost/computadores");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            object objresponse = reader.ReadToEnd();
            List<Computer> list2 = new List<Computer>();
            if (objresponse.ToString() != "")
            {
                var list = JsonConvert.DeserializeObject<List<ComputerAPI>>(objresponse.ToString());
                //    list2 = list;
                foreach (ComputerAPI item in list)
                {
                    var teste = new Computer()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Ip = item.Ipaddr,
                        Processor = item.Processort,
                        User = item.UserId,
                        OpSystem = item.OsName,
                        Domain = item.Workgroup,
                        Tag = item.Tag
                    };
                    list2.Add(teste);

                    //   var pc2 = _context.Computer.Where(s => s.Id == 1000).FirstOrDefault().ToString();
                    //  Console.WriteLine(pc2);

                }//fim do foreach

            }//fim do if
            return list2;
        }

        //metodo que retorna o numero total de computadores da Lista
        public static int GetPCCount()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost/computadores");
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            object objresponse = reader.ReadToEnd();
            List<Computer> list2 = new List<Computer>();
            if (objresponse.ToString() != "")
            {
                var list = JsonConvert.DeserializeObject<List<ComputerAPI>>(objresponse.ToString());

                foreach (ComputerAPI item in list)
                {
                    var teste = new Computer()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Ip = item.Ipaddr,
                        Processor = item.Processort,
                        User = item.UserId,
                        OpSystem = item.OsName,
                        Domain = item.Workgroup,
                        Tag = item.Tag
                    };
                    list2.Add(teste);

                }//fim do foreach

            }//fim do if

            return list2.Count();
        }

        //método rotina de verificação se o ID da API existe no meu banco, se não existir , da INSERT.
        public static List<Computer> TestPC()
        {

            List<Computer> pc = new List<Computer>();
            foreach (var x in Services.ComputerService.GetPC())
            {
                var pc2 = new Computer();
                if (pc2.Id == 1000)
                {
                    // pc2 = _context.Computer.Where(s => s.Id == 1000).FirstOrDefault();
                    pc.Add(pc2);
                    Console.WriteLine(pc.ToString());
                }
            }
            return pc;
        }

        public List<Computer> FindAll()
        {
            return _context.Computer.OrderBy(x => x.Id).ToList();
        }
    }
}
