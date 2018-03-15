using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIClonaeable
{
    public class Salary : ICloneable
    {
        const double DEFAULT_AMOUNT = 0;
        const double DEFAULT_BONUS = 0;

        double _amount;
        double _bonus;

        public double Amount { get => _amount; set => _amount = value; }
        public double Bonus { get => _bonus; set => _bonus = value; }

        public Salary() : this(DEFAULT_AMOUNT,DEFAULT_BONUS)
        {
            //no code
        }

        public Salary(double paramAmount, double paramBonus)
        {
            this.Amount = paramAmount;
            this.Bonus = paramBonus;
        }

        public Object Clone()
        {
            Salary otherSalary = (Salary)this.MemberwiseClone();
            return otherSalary;
        }
    }
}