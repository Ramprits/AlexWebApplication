using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace AlexWebApp.Models.ClientViewModels
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [EmailAddress]
        //[Remote("VerifyEmail", "Client")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Display(Name = "Contact Date")]
        public DateTime? ContactDate { get; set; }
            = DateTime.UtcNow;

        [Display(Name = "Client Type")]
        public string ClientType { get; set; }

        [Required]
        [MaxLength(25)]
        public string Notes { get; set; }

        [Display(Name = "Email Promos")]
        public List<EmailPromo> EmailPromos { get; set; }

        [Display(Name = "Billing Address")]
        public Address BillingAddress { get; set; }

        [Display(Name = "Mailing Address")]
        public Address MailingAddress { get; set; }
    }
}