using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    /// <summary>
    /// Ingredients to do Coffe: milk by liters, cocao by grams 
    /// </summary>
    public class Ingredients
    {
        public Ingredients(int milk, int teaBags, int coffeSeeds, int cocao)
        {
            Milk = milk;
            Teabags = teaBags;
            CoffeSeeds = coffeSeeds;
            Cocao = cocao;
        }

        public int Milk { get; set; }
        public int Teabags { get; set; }
        public int CoffeSeeds { get; set; }
        public int Cocao { get; set; }
    }
}
