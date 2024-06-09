using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machine_1006
{
    public class TuringMachine
    {
        public TMState _state = new TMState();
        private List<TMRule> _rules = new List<TMRule>();

        public void AddState(TMState tm)
        { _state = tm; }

        public void AddRule(TMRule rule)
        {
            _rules.Add(rule);
        }
        public TMState Run(TMState _state)
        {
            var rule = _rules.FirstOrDefault(r => r.CurrentState == _state.CurrentState && r.ReadSymbol == _state.CurrentSymbol);
            if (rule == null)
            {
                _state.CurrentState = -1;
                Console.WriteLine("Не найдено правило");
            }
            else
            {
                _state.CurrentState = rule.NewState;
                _state.CurrentPosition += rule.Move;
                _state.CurrentSymbol = rule.WriteSymbol;
            }
            return _state;
        }
    }

}
