using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsPuzzle222_6
{
    delegate int MathAction(int a, int b);

    class Operator
    {

        MathAction _op;
        char _nameOp;
        int _priority;

        public char NameOp { get => _nameOp; set => _nameOp = value; }
        public int Priority { get => _priority; set => _priority = value; }
        internal MathAction Op { get => _op; set => _op = value; }

        public Operator(char nameOp, int prior, MathAction op)
        {
            NameOp = nameOp;
            Priority = prior;
            Op = op;
        }


    }
}
