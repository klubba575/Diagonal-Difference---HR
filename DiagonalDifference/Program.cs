using System;

namespace DiagonalDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 3;
			int[,] arr = { { 12, 5, 3 }, { 7, 1, 23 }, { 4, 9, 5 } };
			Console.WriteLine(difference(arr, n));
			
			static int difference(int [,] arr, int n)
			{
				int d1 = 0;
				int d2 = 0;
				for (int a = 0; a < n; a++)
				{
					for (int b = 0; b < n; b++)
					{
						if (a == b)
						{
							d1 += arr[a, b];
						}
						if (a  == n - b - 1)
						{
							d2 += arr[a, b];
						}
					}
				}
				return Math.Abs(d1 - d2);
			}
			
		}
	}
}
