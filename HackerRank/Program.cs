using System;
using System.Linq;
using System.Collections.Generic;


namespace HackerRank
{
	class MainClass //Largest Permutation
	{
		public static void Main (string [] args)
		{
			string [] h_temp = Console.ReadLine ().Split (' ');// Get Array size and number of Swaps allowed
			Int32 size = Int32.Parse (h_temp [0]);
			Int32 swaps = Int32.Parse (h_temp [1]);
			h_temp = Console.ReadLine ().Split (' '); // get array values
			var nums = Array.ConvertAll (h_temp, int.Parse); // assign as int array
			var currentIndex = 0;

			for (int i = 0; i < swaps; i++) 
			{
				if (currentIndex < size) 
				{
					var high = 0;
					for (int x = currentIndex; x < size; x++) 
					{
						if (nums [high] < nums [x]) // fix index references
						{
							high = x;
						}
					}
					if (nums [high] > nums [currentIndex] && high > 0) 
					{
						var temp = nums [currentIndex];
						nums [currentIndex] = nums [high];
						nums [high] = temp;
						currentIndex++;
					}
				}
			}
			string output = null;
			for (int n = 0; n < size;n++)
			{
				output += (nums [n] + " ");
			}
			Console.WriteLine ();
			Console.WriteLine (output);
		}
	}
}