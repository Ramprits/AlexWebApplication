using System;
using System.Collections.Generic;
using System.Linq;
using AlexWebApp.Data;
using AlexWebApp.Models.CustomerViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlexWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
//        public IActionResult Index()
//        {
//            var customer = _context.Customers.ToList();
//            if (customer == null) throw new ArgumentNullException(nameof(customer));
//            return View(customer);
//        }
        public IActionResult Address()
        {
            var add = _context.Addresses.
            Include(cus => cus.Customer).ToList();
            return View(add);
        }
        public IActionResult Index() =>
            _context.Customers != null ? View(_context.Customers.Include(ad =>ad.Addresses).ToList()) : View();
    }
}