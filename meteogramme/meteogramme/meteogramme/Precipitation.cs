using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace meteogramme
{
    public class Precipitation
    {
        public List<string> Symbole { get; set; }
        public List<string> Id { get; set; }
        public List<string> Value { get; set; }
        public List<string> ValueMax { get; set; }
        public List<string> ValueMin { get; set; }

        public Precipitation()
        {
            Symbole = new List<string>();
            Id = new List<string>();
            Value= new List<string>();
            ValueMax = new List<string>();
            ValueMin = new List<string>();
        }
    }
}