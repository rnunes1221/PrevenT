using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Localization;

namespace PreventWebMVC.Models
{
    public class Computer
    {
        [Required(ErrorMessage = "Id Obrigatório")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
       
        public string Ip { get; set; }
        [Display(Name = "Processador")]
        public string Processor { get; set; }

        [Display(Name = "Usuário")]
        public string User { get; set; }

        [Display(Name = "S.O")]
        public string OpSystem { get; set; }

        [Display(Name = "Domínio")]
        public string Domain { get; set; }

        [Display(Name = "Patrimônio")]
        public string Tag { get; set; }
        public ICollection<Prev> Prevs { get; set; } = new List<Prev>();

        //Construtor sem Argumentos
        public Computer()
        {

        }
        //Construtor com Argumentos
        public Computer(int id, string name, string ip, string processor, string user, string opSystem, string domain, string tag)
        {
            Id = id;
            Name = name;
            Ip = ip;
            Processor = processor;
            User = user;
            OpSystem = opSystem;
            Domain = domain;
            Tag = tag;
        }

      

        //metodo para adicionar preventiva 
        public void AddPrev(Prev p)
        {
            Prevs.Add(p);
        }

        //metodo para remover preventiva
        public void RemovePrev(Prev p)
        {
            Prevs.Remove(p);
        }

        


    }
}
