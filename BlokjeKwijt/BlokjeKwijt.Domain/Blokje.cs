using System;

namespace BlokjeKwijt.Domain
{
    public class Blokje
    {
        public int ID { get; set; }

        public int Lenght {get;set;}
        public int Width { get; set; }
        public int Height { get; set; }
        public BlokjeColor Color { get; set; }
        public int NumberOfNobs { get; set; }
        public int BlockNumber { get; set; }
        public string ImageLink { get; set; }
    }
}
