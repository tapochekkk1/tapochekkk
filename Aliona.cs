using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КорсарВишневый
{
    class Aliona : PearTree

    {
        public Aliona(int az, string we) : base (az, we)
        { 
        
        }
        public override void Grow() => Age = +4;
    }
}
