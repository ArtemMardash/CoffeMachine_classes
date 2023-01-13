using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class AddMoney:ICommand
    {
        private Coffe _coffe;
        private int _money;

        public AddMoney(Coffe coffe, int money)
        {
            _coffe = coffe;
            _money = money;
        }

        public void Execute()
        {
            _coffe.AddBalance(_money);
        }
    }
}
