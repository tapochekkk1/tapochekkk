using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КорсарВишневый
{
    class PearTree : Tree
    {
        public PearTree(int q, string w) : base(w, q)
        {

        }
        public override void Grow()
        {
            Age += 2;
        }

    }
}
