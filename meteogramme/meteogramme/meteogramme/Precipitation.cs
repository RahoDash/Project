using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace meteogramme
{
    public class Precipitation
    {
        private string _unit;
        private int _numSymbole;

        public Precipitation(string unit, int numSymbole)
        {
            throw new System.NotImplementedException();
        }

        public string Unit { get => _unit; set => _unit = value; }
        public int NumSymbole { get => _numSymbole; set => _numSymbole = value; }
    }
}