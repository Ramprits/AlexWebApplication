using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.EmployeeViewModels
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please Enter Department Name")]
        public string DepartmentName { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    }
}