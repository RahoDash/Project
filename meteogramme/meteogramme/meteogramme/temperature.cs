using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace meteogramme
{
    public class Temperature
    {
        public List<string> TempMin { get; set; }
        public List<string> TempMax { get; set; }
        public List<string> Temp { get; set; }

        public Temperature()
        {
            Temp = new List<string>();
            TempMax = new List<string>();
            TempMin = new List<string>();
        }
    }
}