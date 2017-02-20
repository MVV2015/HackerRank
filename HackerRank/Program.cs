using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank
{
	class MainClass //Designer PDF Viewer
	{
		public static void Main (string [] args)
		{
			string [] h_temp = Console.ReadLine ().Split (' ');// Load height values of the alphabet
			int [] h = Array.ConvertAll (h_temp, Int32.Parse);// convert them to int
			string word = Console.ReadLine ();// get the word to enclose in a box
			char [] letters = word.ToCharArray ();// convert the string to a char array

			// Find the tallest letter
			int maxHeight = 0;
			for (int x = 0; x < letters.Length; x++)
			{
				int thisHeight = h[char.ToUpper (letters [x])-64 - 1];
				int anotherWay = h[((int)letters [x] % 32) - 1];
				if (maxHeight< thisHeight)
				{
					maxHeight = thisHeight;
				}
			}

			// Multiply hieght times length of the word
			int areaToHilight = word.Length * maxHeight;
			Console.WriteLine (areaToHilight);
		}
	}
}