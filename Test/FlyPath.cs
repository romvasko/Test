using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class FlyPath
    {
        IStartable _flyingObj;
        public FlyPath(IStartable start)
        {
            _flyingObj = start;
        }
        public override string ToString()
        {
            return _flyingObj.Start();
        }
    }
}
