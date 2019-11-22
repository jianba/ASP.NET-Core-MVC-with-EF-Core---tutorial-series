using System.Collections.Generic;

namespace ContosoUniversity.Models.OrderViewModels
{
    public class OrdersViewModel
    {
        public List<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();
    }
}
