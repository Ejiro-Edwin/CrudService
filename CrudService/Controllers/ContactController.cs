using CrudService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudService.Controllers
{
    public class ContactController : ApiController
    {

        Contact[] contacts = new Contact[]
        {
            new Contact() {Id=0, Firstname="Peter", Lastname="Parker" },
            new Contact() {Id=1, Firstname="Ejiro", Lastname="Edwin"  },
            new Contact() {Id=2, Firstname="Ayo", Lastname="Balogun" },
            new Contact() {Id=3, Firstname="JohnMark", Lastname="Obiefuna" }
        };
        // GET: api/Contact
        public IEnumerable<Contact> Get()
        {
            return contacts;
        }

        // GET: api/Contact/5
        public IHttpActionResult Get(int id)
        {
            Contact contact = contacts.FirstOrDefault<Contact>(c => c.Id == id);

            if(contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: api/Contact
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Contact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contact/5
        public void Delete(int id)
        {
        }
    }
}
