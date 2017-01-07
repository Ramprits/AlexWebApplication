using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlexWebApp.Models.ClientViewModels
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }


        [MaxLength(50,ErrorMessage = "{0} should be less then 50 ")]
        public string Street { get; set; }


        public string City { get; set; }


        public string State { get; set; }


        public string Zip { get; set; }
    }
}