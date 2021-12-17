using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreventWebMVC.Models.ViewModels
{
    public class PrevFormViewModel
    {
        public Prev  Prev { get; set; }
        public ICollection<Computer>Computers { get; set; }
    }
}
