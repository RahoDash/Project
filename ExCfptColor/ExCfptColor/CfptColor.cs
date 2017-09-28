/*
 *  Project :   CfptColor
 *  Author  :   Besmir SILKA
 *  Desc.   :   "Controle de compétence POO N°1"  
 *  Version :   1.0, Besmir SILKA, 2017.09.28
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCfptColor
{
    public class CfptColor
    {
        /// <summary>
        /// constant
        /// </summary>
        const byte DEFAULT_RED = 0;
        const byte DEFAULT_GREEN = 0;
        const byte DEFAULT_BLUE = 0;
        const byte MAX_VALUE_COLOR = 255;
        const int DEFAULT_MAX_VALUE_COLOR = 256;


        /// <summary>
        /// Fields
        /// </summary>
        private byte _red;
        private byte _green;
        private byte _blue;


        /// <summary>
        /// Properties
        /// </summary>
        public byte Red { get => _red; set => _red = value; }
        public byte Green { get => _green; set => _green = value; }
        public byte Blue { get => _blue; set => _blue = value; }


        /// <summary>
        /// construtors
        /// </summary>
        public CfptColor()
        {
            Red = DEFAULT_RED;
            Green = DEFAULT_GREEN;
            Blue = DEFAULT_BLUE;
        }
        public CfptColor(int pRgb)
        {
            Red = Convert.ToByte(pRgb / DEFAULT_MAX_VALUE_COLOR / DEFAULT_MAX_VALUE_COLOR);
            Green = Convert.ToByte(pRgb / DEFAULT_MAX_VALUE_COLOR - Red * DEFAULT_MAX_VALUE_COLOR);
            Blue = Convert.ToByte(pRgb - (Red * DEFAULT_MAX_VALUE_COLOR * DEFAULT_MAX_VALUE_COLOR + Green * DEFAULT_MAX_VALUE_COLOR));
        }
        public CfptColor(byte pRed, byte pGreen, byte pBlue)
        {
            Red = pRed;
            Green = pGreen;
            Blue = pBlue;
        }
        public CfptColor(double pProportionR, double pProportionG, double pProportionB)
        {
            Red = Convert.ToByte(Convert.ToUInt16(pProportionR * MAX_VALUE_COLOR));
            Green = Convert.ToByte(Convert.ToUInt16(pProportionG * MAX_VALUE_COLOR));
            Blue = Convert.ToByte(Convert.ToUInt16(pProportionB * MAX_VALUE_COLOR));
        }



        /// <summary>
        /// Methods
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            byte[] result = { Red, Green, Blue };
            string[] output = BitConverter.ToString(result).Split('-');
            string output2 = "";
            for (int i = 0; i < output.Length; i++)
            {
                output2 += output[i];
            }
            return output2;
        }



        public bool ContainsMoreRedThan(CfptColor pColor)
        {
            return false;
        }
        public bool ContainsMoreGreenThan(CfptColor pColor)
        {
            return false;
        }
        public bool ContainsMoreBlueThan(CfptColor pColor)
        {
            return false;
        }


        public bool IsEqual(CfptColor pColor)
        {
            return false;
        }
        public double EuclideanDistance(CfptColor pColor)
        {
            return 0.0;
        }
    }
}
