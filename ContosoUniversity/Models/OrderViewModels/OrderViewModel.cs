﻿using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.OrderViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string PickUpAddress { get; set; }
        public string DropOffAddress { get; set; }
        public int CargoCount { get; set; }
        public List<CargoViewModel> Cargos { get; set; }
    }
}
