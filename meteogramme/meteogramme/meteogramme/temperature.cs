using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace meteogramme
{
    public class Temperature
    {
        private string _type;
        private float _tempMax;
        private float _tempMin;
        private float _tempAverage;

        public Temperature(string type, float tempMax, float tempMin, float tempAverage)
        {
            throw new System.NotImplementedException();
        }

        public string Type { get => _type; set => _type = value; }
        public float TempMax { get => _tempMax; set => _tempMax = value; }
        public float TempMin { get => _tempMin; set => _tempMin = value; }
        public float TempAverage { get => _tempAverage; set => _tempAverage = value; }
    }
}