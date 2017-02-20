using System;
using System.Linq;
using System.Collections.Generic;


namespace HackerRank
{
	class MainClass//Grid Challenge
	{
		public static void Main (string [] args)
		{
			int numQueries = int.Parse (Console.ReadLine ());
			for (int i = 0; i < numQueries; i++) 
			{
				int gridSize = Int32.Parse (Console.ReadLine ());
				string [,] Grid = new string [gridSize, gridSize];
				string [] temp;
				for (int n = 0; n < gridSize; n++) 
				{
					string holding = Console.ReadLine();
					temp = holding.Select (x => x.ToString ()).ToArray ();
					Array.Sort (temp);
					for (int x = 0; x < gridSize; x++) 
					{
						Grid [x, n] = temp [x];
					}
				}
				checkOrder (Grid, gridSize);
			}
		}
		static void checkOrder(string[,] checkMe, int size)
		{
			for (int columb = 0; columb < size; columb++) 
			{
				for (int row = 0; row < size - 1; row++) 
				{
					if (string.Compare (checkMe [columb, row], checkMe [columb, row + 1]) > 0) 
					{
						// String.Compare returns 0 if equal, neg if A < B, and pos if A > B
						Console.WriteLine ("NO");
						return;
					}
				}
			}
			Console.WriteLine ("YES");
			return;
		}
	}
}