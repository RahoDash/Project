using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIClonaeable
{
    public class Job : ICloneable
    {
        static readonly Salary DEFAULT_SALARY = new Salary();
        const string DEFAULT_DESCRIPTION = "";

        string _description;
        Salary _salary;

        public string Description { get => _description; set => _description = value; }
        internal Salary Salary { get => _salary; set => _salary = value; }

        public Job(): this(DEFAULT_DESCRIPTION,DEFAULT_SALARY)
        {
            //no code
        }

        public Job(string paramDescription) : this(paramDescription, DEFAULT_SALARY)
        {
            this.Description = paramDescription;
        }

        public Job(string paramDescription, Salary paramSalary)
        {
            this.Description = paramDescription;
            this.Salary = paramSalary;
        }

        public Object Clone()
        {
            Job otherJob = (Job)this.MemberwiseClone();
            otherJob.Salary = (Salary)this.Salary.Clone();
            return otherJob;
        }
    }
}