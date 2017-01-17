using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.DepartmentViewModels
{
  public class DepartmentDetail
  {
    // Scalar Properties
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    // Navigation Property
    public List<EmployeeDetail> EmployeeDetails { get; set; }
  }
}