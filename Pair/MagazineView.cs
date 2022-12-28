using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair {
    public class MagazineView : IPrintable {
        public void PrintConsole(string str) {
            Console.WriteLine(str);
        }
    }
}
