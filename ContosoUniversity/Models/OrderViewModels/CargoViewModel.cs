using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.OrderViewModels
{
    public class CargoViewModel
    {
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public string CargoType { get; set; }
    }
}
