using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIClonaeable
{
    public class Person : ICloneable
    {
        const string DEFAULT_NAME = "";
        static readonly Job DEFAULT_JOB = new Job();

        string _name;
        Job _job;

        public string Name { get => _name; set => _name = value; }
        internal Job Job { get => _job; set => _job = value; }

        public Person(string paramName): this(paramName,DEFAULT_JOB)
        {
            this.Name = paramName;
        }

        public Person(string paramName, Job paramJob)
        {
            this.Name = paramName;
            this.Job = paramJob;
        }

        public Object Clone()
        {
            Person otherPerson = (Person)this.MemberwiseClone();
            otherPerson.Job = (Job)this.Job.Clone();
            return otherPerson;
        }
    }
}