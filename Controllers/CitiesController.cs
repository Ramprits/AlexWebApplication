using System.Linq;
using AlexWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace AlexWebApp.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() =>
            _context.Citieses != null ? View(_context.Citieses.Include(c => c.PointsOfInterest).ToList()) : View();
    }
}