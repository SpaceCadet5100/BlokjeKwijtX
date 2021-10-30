using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class ContactForm
    {
        public int ID { get; set; }

        public User User {get;set;}

        [Display(Name = "Bericht")]
        [Required(ErrorMessage = "Bericht is verplicht")]
        public string Message { get; set; }
    }
}
