using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КорсарВишневый
{
    class Anton : AppleTree
    {
        public Anton(int qw, string er) : base(qw, er)
        {

        }
        public new void Grow() => Age *= 1.5;
    }
}
