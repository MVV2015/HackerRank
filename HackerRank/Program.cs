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
			int size = Int32.Parse (h_temp [0]);
			int swaps = Int32.Parse (h_temp [1]);
			h_temp = Console.ReadLine ().Split (' '); // get array values. (all Natural numbers from 1 to N)
			int[] nums = Array.ConvertAll (h_temp, Int32.Parse); // assign as int array
			Dictionary <int, int > numPair = new Dictionary<int, int > ();

			// Assign array values as dictionary keys. The value for each key is assigned a default int.
			// The ints start at 0 and incerment up from there. Just happens to correspond to the array indexes.
			for (int n = 0; n < nums.Length; n++) 
			{
				numPair [nums [n]] = n;
			}

			int temp = 0;
			int largestNum = nums.Length; // The largest num in the array corresponds to the array size.
			int largestNumIndex; // Used to store the location of the largest value in the array.

			for (int i = 0; i < size; i++) // Step through the entire array.
			{
				if (swaps > 0) // Limit the number of swaps (ref input (swaps)
				{
					// Get the index of the largest remaining number from the Dictionary.
					largestNumIndex = numPair [largestNum]; 

					// Make sure it is Larger than the next int in the array.
					// Note the use of the indexer (i) to keep track of the placement of the value being compared to.
					if (nums [largestNumIndex] > nums [i])// Swap the values if needed 
					{						
						temp = nums [i];
						nums [i] = nums [largestNumIndex];
						nums [largestNumIndex] = temp;
						swaps--;
					}
					largestNum--;

					// Trade the dictionary items
					numPair [nums [largestNumIndex]] = largestNumIndex;
					numPair [nums [i]] = i;
				}
			}
			for (int n = 0; n < size;n++)
			{
				Console.Write (nums [n] + " ");
			}
		}
	}
}