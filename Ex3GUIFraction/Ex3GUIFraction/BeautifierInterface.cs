/***
 * Name     :   Fractions
 * Author   :   B.Silka
 * Desc.    :   Fractions Interface model
 * Version  :   2.0, 3.10.2017, B.SILKA  
 ***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3GUIFraction
{
    public interface BeautifierInterface
    {
        string Display(int num, int den);
    }

    public class BeautifierInterfaceParenthesis : BeautifierInterface
    {
        public string Display(int num, int den)
        {
            return $"({num}) / ({den})";
        }
    }

    public class BeautifierInterfaceBrackets : BeautifierInterface
    {
        public string Display(int num, int den)
        {
            return $"{{{num}}} / {{{den}}}";
        }
    }

    public class BeautifierInterfaceNormale : BeautifierInterface
    {
        public string Display(int num, int den)
        {
            return $"{num} / {den}";
        }
    }

    public class BeautifierInterfaceLatex : BeautifierInterface
    {
        public string Display(int num, int den)
        {
            return $"\\fraction{{{num}}}{{{den}}}";
        }
    }
}