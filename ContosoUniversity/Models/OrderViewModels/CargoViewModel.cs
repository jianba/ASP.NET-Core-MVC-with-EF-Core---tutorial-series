using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.OrderViewModels
{
    public class CargoViewModel
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string CargoType { get; set; }

        //Other use
        public int CargoCount { get; set; }
        public List<CargoViewModel> Cargos { get; set; }
    }
}
