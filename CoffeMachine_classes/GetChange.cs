using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class GetChange:ICommand
    {
        private Coffe _coffe;

        public GetChange(Coffe coffe)
        {
            _coffe = coffe;
        }

        public void Execute()
        {
            _coffe.DiscardBalance(_coffe.Balance);
        }
    }
}
