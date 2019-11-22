using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.OrderViewModels
{
    public class OrderViewModel
    {
        public string PickUpAddress { get; set; }
        public string DropOffAddress { get; set; }
        public List<Cargo> Cargos { get; set; }
    }
}
