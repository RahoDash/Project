/***
 * Name  :   Fractions
 * Author   :   B.Silka
 * Desc.    :   Model class of Fractions
 * Version  :   4.0, 18.09.2017, B.SILKA  
 ***/

using Ex3GUIFraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public delegate string DisplayDelegate(int a, int b);
    public class Fraction
    {
        private const int DEFAULT_NOMINATOR = 0;
        private const int DEFAULT_DENOMINATOR = 1;
        private const int DIVIDED_BY_ZERO = 0;
        private const int REVERSE_SIGN = -1;
        private const int INIT_VAR = 0;
        private const int DEFAULT_MULTIPLIER = 10;
        private readonly static BeautifierInterface DEFAULT_DISPLAY = new BeautifierInterfaceNormale();

        #region fields
        //Variable
        private int _numerator;
        private int _denominator;
        private BeautifierInterface Dis;
        private int multiplier = 1;
        #endregion

        #region properties
        //properties
        private int Numerator { get => _numerator; set => _numerator = value; }
        private int Denominator
        {
            get => _denominator;
            set
            {
                if (value == DIVIDED_BY_ZERO)
                {
                    Console.WriteLine("Denominator cannot be null");
                    _denominator = DEFAULT_DENOMINATOR;
                }
                else
                {
                    _denominator = value;
                }
            }
        }
        #endregion

        #region constructors
        public Fraction() : this(DEFAULT_NOMINATOR) {}
        public Fraction(int num) : this(num, DEFAULT_DENOMINATOR){}

        public Fraction(decimal num) {
            while (num%1!=0)
            {
                multiplier *= DEFAULT_MULTIPLIER;
                num *= DEFAULT_MULTIPLIER;
            }
            Numerator = Convert.ToInt32(num);
            Denominator = multiplier;
            Dis = DEFAULT_DISPLAY;
        }

        public Fraction(int num, int den) : this(num, den, DEFAULT_DISPLAY) {}

        /// <summary>
        /// constructor designed
        /// </summary>
        /// <param name="num">numerator</param>
        /// <param name="den">denominator</param>
        /// <param name="helper">Interface display</param>
        public Fraction(int num, int den, BeautifierInterface dis)
        {
            Numerator = num;
            Denominator = den;
            Dis = dis;
        }
        #endregion

        #region methods
        /// <summary>
        /// Override the methode toString, spell the fraction designed
        /// </summary>
        /// <returns>string of the fraction</returns>
        public override string ToString()
        {
            Reduce();
            return Dis.Display(Numerator, Denominator);

            //return Helper.Display(Numerator, Denominator); //this.Numerator + " / " + this.Denominator;
        }
        /// <summary>
        /// Result of the fraction in Float
        /// </summary>
        /// <returns>Float result</returns>
        public double ToDouble()
        {
            return Convert.ToDouble(Numerator) / Convert.ToDouble(Denominator); ;
        }

        /// <summary>
        /// Add 2 fraction
        /// </summary>
        /// <param name="f">Fraction to add</param>
        /// <returns>the result of the fraction</returns>
        public Fraction Add(Fraction f)
        {
            reverseIfNeeded(this);
            reverseIfNeeded(f);

            int resNum = (Numerator * f.Denominator) + (f.Numerator * Denominator);
            int resDen = f.Denominator * Denominator;

            return new Fraction(resNum, resDen);
        }

        public Fraction Sub(Fraction f)
        {
            reverseIfNeeded(this);
            reverseIfNeeded(f);

            int resNum = (Numerator * f.Denominator) - (f.Numerator * Denominator);
            int resDen = f.Denominator * Denominator;

            return new Fraction(resNum, resDen);
        }

        /// <summary>
        /// Determine the greater common divider, and divide both number -> nominator and dominator
        /// </summary>
        private void Reduce()
        {
            int gcd = ComputeGcd(Numerator, Denominator);

            Numerator /= gcd;
            Denominator /= gcd;
        }

        /// <summary>
        /// Determine the greater common divider of "a" and "b"
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        /// <returns></returns>
        public int ComputeGcd(int a, int b)
        {
            int temp = INIT_VAR;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            if (temp < 0)
            {
                temp *= REVERSE_SIGN;
            }

            return temp;
        }

        /// <summary>
        /// Reverse the negative numbers
        /// if only the denominator is negative -> the numerator will take the negative and
        /// if both are negative they will be both positive.
        /// </summary>
        /// <param name="f">Fraction</param>
        public void reverseIfNeeded(Fraction f)
        {
            if (f.Denominator < 0)
            {
                f.Numerator *= REVERSE_SIGN;
                f.Denominator *= REVERSE_SIGN;
            }
        }
        #endregion
    }
}
