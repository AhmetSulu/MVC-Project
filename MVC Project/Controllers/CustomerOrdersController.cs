using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Collections.Generic;

namespace MVC_Project.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Sulu",
                Email = "ahmet.sulu1993@gmail.com"
            };

            var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1500.00m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 25.00m, Quantity = 1 },
            new Order { Id = 3, ProductName = "Mouse Pad", Price = 10.00M, Quantity = 1 },
            new Order { Id = 3, ProductName = "Klavye", Price = 50.00M, Quantity = 1 },
            new Order { Id = 3, ProductName = "Kulaklık", Price = 35.00M, Quantity = 1 },
            new Order { Id = 3, ProductName = "Monitör", Price = 900.00M, Quantity = 1 },
            new Order { Id = 3, ProductName = "Game Pad", Price = 13.00M, Quantity = 1 }
        };

            
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            
            return View(viewModel);
        }
    }

}
