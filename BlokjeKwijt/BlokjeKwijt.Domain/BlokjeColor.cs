using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokjeKwijt.Domain
{
    public class BlokjeColor
    {
        public int ID { get; set; }
        [DisplayName("Hex waarde")]
        [RegularExpression("^#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$", ErrorMessage = "Verkeerde hex waarde ingevuld")]

        public String RgbValue { get; set; }
        [DisplayName("Kleurnaam")]
        public string Name { get; set; }
    }
}
