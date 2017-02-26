using System;
using System.Linq;
using System.Collections.Generic;


namespace HackerRank
{
	class MainClass //Apple and Orange
	{
		public static void Main (string [] args)
		{
			string [] h_temp = Console.ReadLine ().Split (' ');// Get Start and end point of house
			int houseStart = Int32.Parse (h_temp [0]);
			int houseEnd = Int32.Parse (h_temp [1]);

			h_temp = Console.ReadLine ().Split (' '); // get location of trees
			int appleTree = Int32.Parse (h_temp [0]);
			int orangeTree = Int32.Parse (h_temp [1]);

			h_temp = Console.ReadLine ().Split (' '); // numbers of apples and oranges
			int apples = Int32.Parse (h_temp [0]);
			int oranges = Int32.Parse (h_temp [1]);

			h_temp = Console.ReadLine ().Split (' ');
			int[] appleDist = Array.ConvertAll (h_temp, Int32.Parse); // Distances apples fall from tree

			h_temp = Console.ReadLine ().Split (' ');
			int [] orangeDist = Array.ConvertAll (h_temp, Int32.Parse); // Diatances oranges fall from tree

			int appleHits = 0;
			int orangeHits = 0;
			int dropLocation = 0;

			for (int a = 0; a < apples; a++)
			{
				dropLocation = appleDist [a] + appleTree;
				if( dropLocation >= houseStart && dropLocation <= houseEnd)
				{
					appleHits++;
				}
			}

			for (int o = 0; o < oranges; o++)
			{
				dropLocation = orangeDist [o] + orangeTree;
				if (dropLocation >= houseStart && dropLocation <= houseEnd) 
				{
					orangeHits++;
				}
			}

			Console.WriteLine (appleHits);
			Console.WriteLine (orangeHits);
		}
	}
}