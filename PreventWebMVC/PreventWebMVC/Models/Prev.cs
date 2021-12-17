﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PreventWebMVC.Controllers;
using PreventWebMVC.Models;

namespace PreventWebMVC.Models
{
    public class Prev
    {
        [Display(Name = "Id Preventiva")]
        public int Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }
        [Display(Name = "Descrição")]
        public string Obs { get; set; }
        public Computer Computer { get; set; }
        [Display(Name = "Id Computador")]
        public int ComputerId { get; set; }
        public Prev()
        {

        }

        public Prev(int id ,DateTime date, string obs, int computerid)
        {
            Id = id;
            Date = date;
            Obs = obs;
            ComputerId = computerid;
    }
    }
}
