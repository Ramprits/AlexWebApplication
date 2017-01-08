using System.Linq;
using AlexWebApp.Data;
using AlexWebApp.Data.Migrations;
using Microsoft.AspNetCore.Mvc;
using Employee = AlexWebApp.Models.EmployeeViewModels.Employee;

namespace AlexWebApp.Controllers
{
     public class EmployeesController : Controller
     {
          private readonly ApplicationDbContext _context;

          public EmployeesController(ApplicationDbContext context)
          {
               _context = context;
          }

          public IActionResult Index()
              => _context.Employees != null ? View(_context.Employees.ToList()) : View();

          public IActionResult GetEmployee() =>
          _context.Employees != null ? View(_context.Employees.ToList()) : View();
          public IActionResult GetEmployees() =>
              _context.Employees != null ? View(_context.Employees.ToList()) : View();

          public IActionResult Index1() =>
              _context.Employees != null ? View(_context.Employees.ToList()) : View();

          [HttpGet]
          public IActionResult Create()
          {
               return View();
          }
          [HttpPost]
          public IActionResult Create(Employee item)
          {
               {
                    if (ModelState == null || !ModelState.IsValid) return View();
                    _context.Employees.Add(item);
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Employees");
               }
          }
     }
}