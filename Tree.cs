using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КорсарВишневый
{
    abstract class Tree
    {
        private double age;
        public string Kind { get; private set; }
        public double Age
        {
            get { return age; }
            protected set
            {
                if (value > 0)
                {
                    age = value;
                }
                else age = 0;
            }
        }
        public Tree(string Kind1, int age1)
        {
            Kind = Kind1;
            age = age1;
        }
        public abstract void Grow();

    }
}
