using System;
using System.Linq;
using System.Collections.Generic;


namespace HackerRank
{
	class MainClass//CuttingBoard
	{
		public static void Main (string [] args)
		{
			Int64 modulus = (Int64)Math.Pow (10, 9) + 7;
			int numQueries = int.Parse (Console.ReadLine ());
			for (int i = 0; i < numQueries; i++) 
			{
				string [] temp = Console.ReadLine ().Split (' ');
				Int64 height = Int64.Parse (temp [0]);
				Int64 width = Int64.Parse (temp [1]);

				temp = Console.ReadLine ().Split (' ');
				Int64 [] tempCost = Array.ConvertAll (temp, Int64.Parse);
				List<Int64> yCutCost = new List<Int64> ();
				yCutCost.AddRange (tempCost);
				yCutCost.Sort ();
				yCutCost.Reverse ();

				temp = Console.ReadLine ().Split (' ');
				tempCost = Array.ConvertAll (temp, Int64.Parse);
				List<Int64> xCutCost = new List<Int64> ();
				xCutCost.AddRange (tempCost);
				xCutCost.Sort ();
				xCutCost.Reverse ();

				Int64 totalCuts = height + width - 2;
				Int64 xSegments = 1, ySegments = 1;
				Int64 totalCost = 0;
				int xIndex = 0;
				int yIndex = 0;

				while (totalCuts > 0) 
				{
					if (xIndex == height - 1)
					{
						totalCost += (yCutCost [yIndex] * xSegments)% modulus;
						ySegments++;
						yIndex++;
					}
					else if(yIndex == width - 1)
					{
						totalCost += (xCutCost [xIndex] * ySegments)% modulus;
						xSegments++;
						xIndex++;
					}
					else if (xCutCost [xIndex] >= yCutCost [yIndex]) 
					{
						totalCost += (xCutCost [xIndex] * ySegments)% modulus;
						xSegments++;
						xIndex++;
					} 
					else 
					{
						totalCost += (yCutCost [yIndex] * xSegments)% modulus;
						ySegments++;
						yIndex++;
					}
					totalCuts--;
				}
				Console.WriteLine (totalCost% modulus);
			}
		}
	}
}

// Not adding up right. Check modulo

 