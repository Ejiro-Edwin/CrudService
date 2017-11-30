using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudService.Models
{
    public class Contact
    {
        public int Id{ get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Contact()
        {
            Id = -1;
            Firstname = string.Empty;
            Lastname = string.Empty;

        }

    }
}