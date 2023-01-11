using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{

	class Program
	{
	


		static void Main(string[] args)
		{
			//DateTime a = DateTime.Now;
			//DateTime b = DateTime.UtcNow;

			//Console.WriteLine(a + " " + b);
			//Test<DateTime>.Swap(ref a, ref b);
			//Console.WriteLine(a + " " + b);

			//var c = 6.06;
			//var d = 7.07;

			//Console.WriteLine(c + " " + d);
			//Test<double>.Swap(ref c, ref d);
			//Console.WriteLine(c + " " + d);


		}

		class Test<T>
        {

            public static void Swap<T>(ref T value1,ref T value2) where T : struct
            {
				T temp = value1;
                value1 = value2;
				value2 = temp;
            }
        }

	}
}
