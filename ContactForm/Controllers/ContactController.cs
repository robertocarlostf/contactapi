using ContactForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using log4net;

namespace ContactForm.Controllers
{
    public class ContactController : ApiController
    {

        public IHttpActionResult PostContact(ContactFormDTO model)
        {
            try
            {
                if (model == null)
                    return BadRequest("Contact form can't be empty");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                using (var _context = new ContactContext())
                {
                    //Because PK not exists on the model can't be added directly

                    var _sql = "INSERT INTO SOFTTEK_TICKETS " +
                        "(CALLER_FIRST_NAME, CALLER_LAST_NAME, CALLER_EMAIL_ADDRESS, CALLER_PHONE_NUMBER, " +
                        "BUYER_EMAIL_ADDRESS, PO_NUMBER, INVOICE_NUMBER, ZDETAILSOFISSUE, ZPRIORITY, ZDOCUMENTTYPE) " +
                        " VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

                    _context.Database.ExecuteSqlCommand(_sql, model.FirstName, model.LastName, model.Email, model.Phone, model.BuyerEmail, model.PoNum, model.InvoiceNum, model.Detail, model.Criticality, model.Issue);

                    string _url = Url.Route("DefaultApi", new { controller = "contact" });
                    return Created(_url, model);
                }
            }
            catch (Exception ex)
            {
                ILog _log = LogManager.GetLogger(this.GetType());
                _log.Error(ex.Message, ex);

                return InternalServerError(new Exception("Error processing contact form"));
            }
        }
            
    }
}
