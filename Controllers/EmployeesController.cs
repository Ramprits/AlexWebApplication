using System;
using System.Linq;
using AlexWebApp.Data;
using AlexWebApp.Data.Migrations;
using AlexWebApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    [HttpGet]
    public IActionResult Edit(int employeeId)
    {
      var employee = _context.Employees.FirstOrDefault(emp => emp.EmployeeId == employeeId);
      if (employee == null) throw new ArgumentNullException(nameof(employee));
      return View(employee);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(Employees employee)
    {
      if (!ModelState.IsValid) return View(employee);
      _context.Entry(employee).State = EntityState.Modified;
      _context.SaveChanges();
      return RedirectToAction("Index", "Employees");
    }

    public IActionResult Index()
      => _context.Employees != null ? View(_context.Employees.Include(dep => dep.Departments)) : View();


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