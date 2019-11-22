using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models.OrderViewModels;
using ContosoUniversity.OrderViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Controllers
{
    public class OrderController : Controller
    {
        private readonly SchoolContext _context;

        public OrderController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var ordersViewModel = new OrdersViewModel();
            var orders = await _context.Order.Select(o => o).ToListAsync();

            foreach (var orderItem in orders)
            {
                var tmpOrderViewModel = new OrderViewModel
                {
                    OrderId = orderItem.OrderId,
                    PickUpAddress = orderItem.PickUpAddress,
                    DropOffAddress = orderItem.DropOffAddress
                };
                var cargos = await _context.Cargo
                    .Where(o => o.OrderId == orderItem.OrderId)
                    .Select(u =>
                    new CargoViewModel
                    {
                        OrderId = u.OrderId,
                        Amount = u.Amount,
                        CargoType = u.CargoType
                    }).ToListAsync();

                tmpOrderViewModel.Cargos = cargos;

                ordersViewModel.Orders.Add(tmpOrderViewModel);
            }

            return View(ordersViewModel);
        }

    }
}