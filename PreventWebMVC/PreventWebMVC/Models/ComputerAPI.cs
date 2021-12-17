using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace PreventWebMVC.Models
{
    public class ComputerAPI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ipaddr { get; set; }
        public string Processort { get; set; }
        public string UserId { get; set; }
        public string OsName { get; set; }
        public string Workgroup { get; set; }
        public string Tag { get; set; }
        public ICollection<Prev> Prevs { get; set; } = new List<Prev>();

        //Construtor sem Argumentos
        public ComputerAPI()
        {

        }
        //Construtor com Argumentos
        public ComputerAPI(int id, string name, string ip, string processor, string user, string opSystem, string domain, string tag)
        {
            Id = id;
            Name = name;
            Ipaddr = ip;
            Processort = processor;
            UserId = user;
            OsName = opSystem;
            Workgroup = domain;
            Tag = tag;
        }


   




    }
}
