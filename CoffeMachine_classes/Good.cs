using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public class Good
    {
        private Ingredients[] _ingredients; 
        public Good(string name, int price, params Ingredients[] ingredients)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; private set; }
        public int Price { get; private set; }  
    }
}
