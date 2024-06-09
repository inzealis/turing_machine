using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine_1006
{
    public class TMRule
    {
        public int CurrentState { get; set; }
        public char ReadSymbol { get; set; }
        public int NewState { get; set; }
        public char WriteSymbol { get; set; }
        public int Move { get; set; }
    }
}
