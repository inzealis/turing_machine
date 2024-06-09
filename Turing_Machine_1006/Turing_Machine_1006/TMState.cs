using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine_1006
{
    public class TMState
    {
        public int CurrentState { get; set; }
        public int CurrentPosition { get; set; }
        public char CurrentSymbol { get; set; }
    }
}
