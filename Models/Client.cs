using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hanover.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        [EmailAddress]
        [Remote("VerifyEmail", "Client")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? ContactDate { get; set; }
        [Required]
        public string ClientType { get; set; }
        [Required]
        public string NearestLocation { get; set; }
        [Required]
        [MaxLength(500)]
        [DataType(DataType.MultilineText)]
        [UIHint("MultilineTextLarge")]
        public string Notes { get; set; }
        public List<EmailPromo> EmailPromos { get; set; }
        public Address BillingAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}
