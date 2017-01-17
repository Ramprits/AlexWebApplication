using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.DepartmentViewModels
{
  public class EmployeeDetail
  {
    // Scalar Properties
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Salary { get; set; }

    // Navigation Property
    public DepartmentDetail DepartmentDetails { get; set; }
  }
}