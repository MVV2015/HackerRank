using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank
{
	class MainClass
	{
		public static void Main (string [] args)
		{
			int numQueries = int.Parse (Console.ReadLine ());
			for (int i = 0; i < numQueries; i++)
			{
				string [] temp = Console.ReadLine ().Split (' ');
				//int n = Int32.Parse (temp [0]);
				int testSum = Int32.Parse (temp [1]);
				temp = Console.ReadLine ().Split (' ');
				int [] aArray = Array.ConvertAll (temp, Int32.Parse);
				temp = Console.ReadLine ().Split (' ');
				int [] bArray = Array.ConvertAll (temp, Int32.Parse);

				Premute (aArray, bArray, testSum);

				//temp = Console.ReadLine ().Split (' ');
				//int testSum2 = Int32.Parse (temp [1]);
				//temp = Console.ReadLine ().Split (' ');
				//int [] cArray = Array.ConvertAll (temp, Int32.Parse);
				//temp = Console.ReadLine ().Split (' ');
				//int [] dArray = Array.ConvertAll (temp, Int32.Parse);

				//Premute (cArray, dArray, testSum2);
			}
		}

		static void Premute(int[] arr1, int[] arr2, int test)
		{
			Array.Sort (arr1);
			Array.Sort (arr2);
			Array.Reverse (arr2);

			for (int x = 0; x < arr1.Length; x++) 
			{
				if ((arr1 [x] + arr2 [x]) < test) 
				{
					Console.WriteLine ("NO");
					return;
				}
			}
			Console.WriteLine ("YES");
		}
	}
}