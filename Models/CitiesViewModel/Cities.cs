using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AlexWebApp.Data.Migrations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AlexWebApp.Models.CitiesViewModel
{
    public class Cities
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Name must be less then {0}"),
         MinLength(4, ErrorMessage = "Name must be {0} or above "), Display(Name = "Name"),
         Required(ErrorMessage = "You must enter name")]
        public string Name { get; set; }

        [Display(Name = "City Description"), Required(ErrorMessage = "You must enter City Descriptions"), MinLength(10),
         MaxLength(200)]
        public string Description { get; set; }

        public ICollection<PointsOfInterest> PointsOfInterest { get; set; }
    }


}