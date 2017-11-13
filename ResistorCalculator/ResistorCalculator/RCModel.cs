﻿/**
 * SILKA Besmir
 * Epreuve de compétences.
 * 9.11.2017
 */

using System;

namespace ResistorCalculator
{
    public class RCModel
    {
        /*****************************************************************************/
        //Const
        /*****************************************************************************/
        static readonly double[] E24_SERIE = { 1.00, 1.10, 1.20, 1.30, 1.50, 1.60, 1.80,
            2.00, 2.20, 2.40, 2.70, 3.00, 3.30, 3.60, 3.90, 4.30, 4.70, 5.10, 5.60, 6.20,
            6.80, 7.50, 8.20, 9.10 };
        static readonly double[] E48_SERIE = { 1.00, 1.05, 1.10, 1.15, 1.21, 1.27, 1.33,
            1.40, 1.47, 1.54, 1.62, 1.69, 1.78, 1.87, 1.96, 2.05, 2.15, 2.26, 2.37, 2.49,
            2.61, 2.74, 2.87, 3.01, 3.16, 3.32, 3.48, 3.65, 3.83, 4.02, 4.22, 4.42, 4.64,
            4.87, 5.11, 5.36, 5.62, 5.90, 6.19, 6.49, 6.81, 7.15, 7.50, 7.87, 8.25, 8.66,
            9.09, 9.53 };
        static readonly double[] E96_SERIE = { 1.00, 1.02, 1.05, 1.07, 1.10, 1.13, 1.15,
            1.18, 1.21, 1.24, 1.27, 1.30, 1.33, 1.37, 1.40, 1.43, 1.47, 1.50, 1.54, 1.58,
            1.62, 1.65, 1.69, 1.74, 1.78, 1.82, 1.87, 1.91, 1.96, 2.00, 2.05, 2.10, 2.15,
            2.21, 2.26, 2.32, 2.37, 2.43, 2.49, 2.55, 2.61, 2.67, 2.74, 2.80, 2.87, 2.94,
            3.01, 3.09, 3.16, 3.24, 3.32, 3.40, 3.48, 3.57, 3.65, 3.74, 3.83, 3.92, 4.02,
            4.12, 4.22, 4.32, 4.42, 4.53, 4.64, 4.75, 4.87, 4.99, 5.11, 5.23, 5.36, 5.49,
            5.62, 5.76, 5.90, 6.04, 6.19, 6.34, 6.49, 6.65, 6.81, 6.98, 7.15, 7.32, 7.50,
            7.68, 7.87, 8.06, 8.25, 8.45, 8.66, 8.87, 9.09, 9.31, 9.53, 9.76 };
        static readonly double[] E192_SERIE = { 1.00, 1.01, 1.02, 1.04, 1.05, 1.06, 1.07,
            1.09, 1.10, 1.11, 1.13, 1.14, 1.15, 1.17, 1.18, 1.20, 1.21, 1.23, 1.24, 1.26,
            1.27, 1.29, 1.30, 1.32, 1.33, 1.35, 1.37, 1.38, 1.40, 1.42, 1.43, 1.45, 1.47,
            1.49, 1.50, 1.52, 1.54, 1.56, 1.58, 1.60, 1.62, 1.64, 1.65, 1.67, 1.69, 1.72,
            1.74, 1.76, 1.78, 1.80, 1.82, 1.84, 1.87, 1.89, 1.91, 1.93, 1.96, 1.98, 2.00,
            2.03, 2.05, 2.08, 2.10, 2.13, 2.15, 2.18, 2.21, 2.23, 2.26, 2.29, 2.32, 2.34,
            2.37, 2.40, 2.43, 2.46, 2.49, 2.52, 2.55, 2.58, 2.61, 2.64, 2.67, 2.71, 2.74,
            2.77, 2.80, 2.84, 2.87, 2.91, 2.94, 2.98, 3.01, 3.05, 3.09, 3.12, 3.16, 3.20,
            3.24, 3.28, 3.32, 3.36, 3.40, 3.44, 3.48, 3.52, 3.57, 3.61, 3.65, 3.70, 3.74,
            3.79, 3.83, 3.88, 3.92, 3.97, 4.02, 4.07, 4.12, 4.17, 4.22, 4.27, 4.32, 4.37,
            4.42, 4.48, 4.53, 4.59, 4.64, 4.70, 4.75, 4.81, 4.87, 4.93, 4.99, 5.05, 5.11,
            5.17, 5.23, 5.30, 5.36, 5.42, 5.49, 5.56, 5.62, 5.69, 5.76, 5.83, 5.90, 5.97,
            6.04, 6.12, 6.19, 6.26, 6.34, 6.42, 6.49, 6.57, 6.65, 6.73, 6.81, 6.90, 6.98,
            7.06, 7.15, 7.23, 7.32, 7.41, 7.50, 7.59, 7.68, 7.77, 7.87, 7.96, 8.06, 8.16,
            8.25, 8.35, 8.45, 8.56, 8.66, 8.76, 8.87, 8.98, 9.09, 9.19, 9.31, 9.42, 9.53,
            9.65, 9.76, 9.88 };

        const double DEFAULT_RAW = 0.0;

        /*****************************************************************************/
        //Fields
        /*****************************************************************************/
        private double _rawValue;

        /*****************************************************************************/
        //Properties
        /*****************************************************************************/
        public double RawValue { get => _rawValue; set => _rawValue = value; }

        /*****************************************************************************/
        //constructor
        /*****************************************************************************/
        /// <summary>
        /// Default constructor
        /// </summary>
        public RCModel()
        {
            RawValue = DEFAULT_RAW;
        }

        /// <summary>
        /// Designated constructor 
        /// </summary>
        /// <param name="paramRaw">Raw input</param>
        public RCModel(double paramRaw)
        {
            this.RawValue = paramRaw;
        }

        /*****************************************************************************/
        //Methods
        /*****************************************************************************/
        /// <summary>
        /// Convert 4 color rings into a double of code colors
        /// </summary>
        /// <param name="band1">index of the color</param>
        /// <param name="band2">index of the color</param>
        /// <param name="band3">index of the color</param>
        /// <param name="band4">index of the color</param>
        /// <returns>the result of the 4 bands converted</returns>
        public double ConvertFromColorBands(int band1, int band2, int band3, int band4)
        {
            double result = 0;
            result += band1*100;
            result += band2*10;
            result += band3*1;
            result *=  (Math.Pow(10, Convert.ToDouble(band4)));
            return result;
        }


        public double GetNearestStandardValue(double rawValue, int serieId)
        {
            int normalizedMultiplier;
            double[] tmpSerie;
            double standardValue, normalizedValue, result;

            if (rawValue == 0)
            {
                result = 0.0;
            }
            else
            {
                normalizedValue = rawValue / Math.Pow(10, Math.Floor(Math.Log10(rawValue)));
                Math.Log10(rawValue);
                normalizedMultiplier = Convert.ToInt32(Math.Floor((Math.Log10(rawValue))));

                switch (serieId)
                {
                    case 24:
                        tmpSerie = E24_SERIE;
                        break;
                    case 48:
                        tmpSerie = E48_SERIE;
                        break;
                    case 96:
                        tmpSerie = E96_SERIE;
                        break;
                    case 192:
                        tmpSerie = E192_SERIE;
                        break;
                    default:
                        tmpSerie = E192_SERIE;
                        break;
                }
                standardValue = tmpSerie[tmpSerie.Length - 1];
                for (int i = 0; i < tmpSerie.Length-2; i++)
                {
                    if ((normalizedValue >= tmpSerie[i]) && (normalizedValue < tmpSerie[i+1]))
                    {
                        standardValue = tmpSerie[i];

                    }
                }
                result = standardValue * Math.Pow(10, normalizedMultiplier);
            }
            return result;
        }
    }
}
