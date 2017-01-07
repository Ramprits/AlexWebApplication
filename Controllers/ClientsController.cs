using AlexWebApp.Data;
using AlexWebApp.Models;
using AlexWebApp.Models.ClientViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlexWebApp.Controllers
{
    public class ClientsController :Controller
    {
        private readonly ApplicationDbContext _context;
        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public IActionResult NewClient()
        {
            return View();
        }
        [HttpPost]
         public IActionResult NewClient(Client newClient)
        {
            // Save New Client here
            if (!ModelState.IsValid) return View();
            _context.Clients.Add(newClient);
            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }


    }
}