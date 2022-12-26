using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Rocket : IStartable
    {
        public string Start()
        {
            return "You flying on rocket";
        }
    }
}
