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
			var nums = Array.ConvertAll (h_temp, Int32.Parse).ToList(); // assign as int array															//var currentIndex = 0;
			var index = 0;
			var temp = 0;

			for (int i = 0; i < size; i++) 
			{
				if (swaps > 0) 
				{
					// skip sorted members and get index of remaining max value.
					index = nums.IndexOf (nums.Skip (i).Max ());
					if (nums [index] > nums [i]) 
					{
						
						temp = nums [i];
						nums [i] = nums [index];
						nums [index] = temp;
						swaps--;
					}
				}
			}
			for (int n = 0; n < size;n++)
			{
				Console.Write (nums [n] + " ");
			}
		}
	}
}