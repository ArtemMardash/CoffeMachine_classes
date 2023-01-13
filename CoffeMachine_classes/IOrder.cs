using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_classes
{
    public interface IOrder
    {
        bool IsAvailable { get; }
        int GetTotalPrice();
        void Ship();
    }
}
