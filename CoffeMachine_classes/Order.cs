using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class Order:IOrder
    {
        private Good _good;
        private Ingredients[] ingredients;

        public Order(Good good, params Ingredients[] ingredients)
        {
            _good = good;
        }

       
    }
}
