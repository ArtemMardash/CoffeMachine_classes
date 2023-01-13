using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class Coffe
    {
        private Good[] _goods;
        public Coffe(int balance, params Good[] goods)
        {
            _goods = goods;
            Balance = balance;
        }
        public int Balance { get; private set; }

        public void AddBalance(int delta)
        {
            if (delta < 0) throw new ArgumentOutOfRangeException("delta");

            Balance += delta;

        }
        public void DiscardBalance(int delta)
        {
            if (delta < 0 || Balance > delta) throw new ArgumentOutOfRangeException("delta");

            Balance -= delta;
        }
    }
}
