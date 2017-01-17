using AlexWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlexWebApp.Controllers
{
    public class PointsOfInterestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PointsOfInterestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() =>
            _context.PointsOfInterests != null ? View(_context.PointsOfInterests.Include(c => c.Cities)) : View();
    }
}