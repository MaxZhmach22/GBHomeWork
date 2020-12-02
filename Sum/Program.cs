using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			long a;
            Console.Write("Введите число: ");
			bool f = long.TryParse(Console.ReadLine(), out a);
			Console.WriteLine($"Сумма чисел введенного числа = {RecursivSum(a)}");
			Console.ReadLine();
		}
		static long RecursivSum(long a)
		{
			if (a == 0)
			{
				return 0;
			}
			else return RecursivSum(a/10) + a % 10; 
		}
	}
}
