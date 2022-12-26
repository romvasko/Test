using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class T_shirt : Clothes
    {
        public string Cost { get; set; }

        public override string GetInfo()
        {
            return $"Jacket Size: {Size} Cost: {Cost}\n";
        }

        public override string UpdateCost(string newValue)
        {
            Cost = newValue;
            return $"Updated new cost: {newValue}";
        }
    }
}
