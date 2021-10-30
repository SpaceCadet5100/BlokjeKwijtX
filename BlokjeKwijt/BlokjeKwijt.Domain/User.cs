using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Naam")]
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Name {get;set;}
        //regex heere

        [Display(Name = "Telefoonnummer")]
        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Een correct telefoonnummer, aub")]
        public string PhoneNumber { get; set; }

        //regex heere
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is verplicht")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Een correct email, aub")]
        public string Email { get; set; }

        public List<UserHasExtraBrick> UserExtraBricks;
        public List<UserHasMissingBrick> UserMissingBricks;

    }
}
