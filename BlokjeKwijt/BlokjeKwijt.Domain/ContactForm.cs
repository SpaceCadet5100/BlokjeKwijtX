using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class ContactForm
    {
        public int ID { get; set; }

        public User User {get;set;}
        public string Message { get; set; }
    }
}
