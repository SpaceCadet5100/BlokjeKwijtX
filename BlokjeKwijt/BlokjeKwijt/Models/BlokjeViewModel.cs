using BlokjeKwijt.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Models
{
    public class BlokjeViewModel
    {
        public int ColorID { get; set; }
        public Blokje Blokje { get; set; }
    }
}
