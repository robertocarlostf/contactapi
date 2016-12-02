using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactForm.Models
{
    [Table("SOFTTEK_TICKETS")]
    public class ContactForm
    {
        [Column("ZTICKETID")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("CALLER_FIRST_NAME")]
        [Required, MaxLength(64)]
        public string FirstName { get; set; }

        [Column("CALLER_LAST_NAME")]
        [Required, MaxLength(64)]
        public string LastName { get; set; }

        [Column("CALLER_EMAIL_ADDRESS")]
        [Required, MaxLength(128)]
        public string Email { get; set; }

        [Column("CALLER_PHONE_NUMBER")]
        [Required, Phone, MaxLength(64)]
        public string Phone { get; set; }

        [Column("ZDOCUMENTTYPE")]
        [Required, MaxLength(64)]
        public string Issue { get; set; }

        [Column("ZDETAILSOFISSUE")]
        [Required]
        public string Detail { get; set; }

        [Column("BUYER_EMAIL_ADDRESS")]
        [EmailAddress, MaxLength(64)]
        public string BuyerEmail { get; set; }

        [Column("PO_NUMBER")]
        [MaxLength(64)]
        public string PoNum { get; set; }

        [Column("ZPRIORITY")]
        [MaxLength(64)]
        public string Criticality { get; set; }

        [Column("INVOICE_NUMBER")]
        [MaxLength(64)]
        public string InvoiceNum { get; set; }
    }
}