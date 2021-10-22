using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class User
    {
        public int ID { get; set; }

        public string Name {get;set;}
        //regex heere

        public int PhoneNumber { get; set; }

        //regex heere
        public string Email { get; set; }

        public List<UserHasExtraBrick> UserExtraBricks;
        public List<UserHasMissingBrick> UserMissingBricks;

    }
}
