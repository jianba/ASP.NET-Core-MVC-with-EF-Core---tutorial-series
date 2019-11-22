using ContosoUniversity.OrderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.OrderViewModels
{
    public class OrdersViewModel
    {
        public List<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
