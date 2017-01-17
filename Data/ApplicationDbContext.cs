using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AlexWebApp.Models;
using AlexWebApp.Models.CitiesViewModel;
using AlexWebApp.Models.CustomerViewModels;
using AlexWebApp.Models.EmployeeViewModels;

namespace AlexWebApp.Data
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

   public DbSet<Employee> Employees { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Department> Departments { get; set; }
      // CustomerViewModels

      public DbSet<Category> Categories { get; set; }
      public DbSet<ContactDetail> ContactDetails { get; set; }
      public DbSet<Customer> Customers { get; set; }
      public DbSet<LineItem> LineItems { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<Address> Addresses{ get; set; }
      /// <summary>
      /// Cities and PointsOfInterest City
      /// </summary>
      /// <param name="builder"></param>

      public DbSet<Cities> Citieses{ get; set; }

      public DbSet<PointsOfInterest> PointsOfInterests { get; set; }
      protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      // Customize the ASP.NET Identity model and override the defaults if needed.
      // For example, you can rename the ASP.NET Identity table names and more.
      // Add your customizations after calling base.OnModelCreating(builder);
    }
  }
}