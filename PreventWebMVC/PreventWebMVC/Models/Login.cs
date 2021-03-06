using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Localization;

namespace PreventWebMVC.Models
{
    public class Login
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }



        [Required]
        public string Username { get; set; }


        [Required]
        public string Senha { get; set; }

        public Login()
        {

        }

        public Login(int id, string name, string username, string senha)
        {
            Id = id;
            Name = name;
            Username = username;
            Senha = senha;
        }
    }
}

