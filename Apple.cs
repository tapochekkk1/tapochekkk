using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КорсарВишневый
{
    class AppleTree : Tree
    {
        public AppleTree(int a, string k) : base(k, a)
        {

        }
        public override void Grow() => Age += 1;
    }
}
