using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactForm.Models
{
    public class ContactFormDTO
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required, Phone, MaxLength(50)]
        public string Phone { get; set; }

        [Required, MaxLength(50)]
        public string Issue { get; set; }

        [Required]
        public string Detail { get; set; }

        [EmailAddress, MaxLength(50)]
        public string BuyerEmail { get; set; }

        [MaxLength(30)]
        public string PoNum { get; set; }

        [MaxLength(50)]
        public string Criticality { get; set; }

        [MaxLength(30)]
        public string InvoiceNum { get; set; }
    }

    public static class ContactFormExtensions
    {
        public static ContactForm Map(this ContactFormDTO from)
        {
            ContactForm _return = new ContactForm();
            _return.FirstName = from.FirstName;
            _return.LastName = from.LastName;
            _return.Email = from.Email;
            _return.Phone = from.Phone;
            _return.Criticality = from.Criticality;
            _return.Issue = from.Issue;
            _return.Detail = from.Detail;
            _return.BuyerEmail = from.BuyerEmail;
            _return.InvoiceNum = from.InvoiceNum;
            _return.PoNum = from.PoNum;

            return _return;
        }
    }
}