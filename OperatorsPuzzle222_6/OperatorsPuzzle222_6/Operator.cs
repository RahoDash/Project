/***
* Name     :   Operator Puzzle 2 () 2 () 2 = 6
* Author   :   Besmir Silka
* Desc.    :   Class Operator, This will only Init the constructor and the delgate methode
* Version  :   1.0, 26.09.2017, B.SILKA  
***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPuzzle222_6
{
    /// <summary>
    /// Signature of the delegate function
    /// </summary>
    /// <param name="a">Require an integer 32-bit</param>
    /// <param name="b">Require an integer 32-bit</param>
    /// <returns></returns>
    delegate int MathAction(int a, int b);

    class Operator
    {
        /// <summary>
        /// Fields
        /// </summary>
        MathAction _op;
        char _nameOp;
        int _priority;

        /// <summary>
        /// Propreties
        /// </summary>
        public char NameOp { get => _nameOp; set => _nameOp = value; }
        public int Priority { get => _priority; set => _priority = value; }
        internal MathAction Op { get => _op; set => _op = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nameOp">Will set the operator to use</param>
        /// <param name="prior">Is the priority of the operator</param>
        /// <param name="op">will be delgated on call</param>
        public Operator(char nameOp, int prior, MathAction op)
        {
            NameOp = nameOp;
            Priority = prior;
            Op = op;
        }


    }
}
