using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.Models.OrderViewModels;
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

        public async Task<IActionResult> CreateOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderViewModel model)
        {
            //    var post = new Post
            //    {
            //        TopicId = model.TopicId,
            //        TimeStamp = model.TimeStamp,
            //        Poster = model.Poster,
            //        Body = model.Body
            //    };
            //    await _context.AddAsync(post);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));

            var order = new Order()
            {
                PickUpAddress = model.PickUpAddress,
                DropOffAddress = model.DropOffAddress
            };
            await _context.AddAsync(order);
            await _context.SaveChangesAsync();
            if (model.CargoCount != 0)
            {
                return RedirectToAction(nameof(CreateCargo), new { cargocount = model.CargoCount });
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> CreateCargo(int cargocount)
        {
            var cargoViewModel = new CargoViewModel
            {
                CargoCount = cargocount
            };
            return View(cargoViewModel);
        }

        [HttpPost]  
        public async Task<IActionResult> CreateCargo(CargoViewModel  model)
        {
            var orderId = await _context.Order.Select(o => o.OrderId).MaxAsync();
            var cargos = model.Cargos;
            foreach (var item in cargos)
            {
                var cargo = new Cargo
                {
                    OrderId = orderId,
                    Amount = item.Amount,
                    CargoType = item.CargoType
                };
                await _context.AddAsync(cargo);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }


    }
}