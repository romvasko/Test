using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair
{
    public class Jacket : Clothes
    {
        public string Cost { get; set; }


        public override string GetInfo()
        {
            return $"T-shirt Size: {Size} Cost: {Cost}\n";
        }

        public override string UpdateCost(string newValue)
        {
            Cost = newValue;
            return $"Updated new cost: {newValue}";
        }
    }
}
