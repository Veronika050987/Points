using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public class Points
    {
		public double X { get; set; }//Properties
		public double Y { get; set; }//Properties

		public Points(double x, double y)
		{
			Console.WriteLine($"Point constructor called for ({x}, {y})");
			X = x;
			Y = y;
		}

		public static double operator -(Points p1, Points p2)
		{
			double dx = p1.X - p2.X;
			double dy = p1.Y - p2.Y;
			return Math.Sqrt(dx * dx + dy * dy);//Math.sqrt() — это метод, который возвращает квадратный корень числа.
												//Он является статическим методом объекта Math. 
		}

		public override string ToString()
		{
			return $"({X}, {Y})";
		}
	}
}
