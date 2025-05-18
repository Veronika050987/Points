using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Program
    {
        static void Main(string[] args)
        {
			Points p1 = new Points(1, 2);
			Points p2 = new Points(4, 6);

			double distance = p1 - p2;

			Console.WriteLine($"Point 1: {p1}");
			Console.WriteLine($"Point 2: {p2}");
			Console.WriteLine($"Distance between p1 and p2: {distance}");

			GC.Collect();
			GC.WaitForPendingFinalizers();

			Console.WriteLine("Program finished!!!");
			Console.ReadKey();
		}
    }
}
