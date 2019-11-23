using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.OrderViewModels
{
    public class OrderAndCargoViewModel
    {
        public int OrderId { get; set; }
        public string PickUpAddress { get; set; }
        public string DropOffAddress { get; set; }
        //public int CargoCount { get; set; }

        //// Cargo Model
        //public int Amount { get; set; }
        //public string CargoType { get; set; }

        // may be no use
        public List<CargoViewModel> Cargos { get; set; }
    }
}
