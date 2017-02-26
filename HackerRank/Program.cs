using System;


namespace HackerRank
{
	class MainClass //Kangaroo
	{
		public static void Main (string [] args)
		{
			string [] tokens_x1 = Console.ReadLine ().Split (' ');
			int x1 = Convert.ToInt32 (tokens_x1 [0]);
			int v1 = Convert.ToInt32 (tokens_x1 [1]);
			int x2 = Convert.ToInt32 (tokens_x1 [2]);
			int v2 = Convert.ToInt32 (tokens_x1 [3]);

			if (((x1 >= x2 && v1 <= v2) || (x1 <= x2 && v1 >= v2))
				&& !(x1 != x2 && v1 == v2)
				&& (Math.Abs (x1 - x2) % Math.Abs (v1 - v2) == 0)) {
				Console.WriteLine ("YES");
			} else {
				Console.WriteLine ("NO");
			}



		}
	}
}
