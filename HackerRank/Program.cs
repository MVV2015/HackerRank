using System;


namespace HackerRank
{
	class MainClass //Grading Students
	{
		public static void Main (string [] args)
		{
			int n = Convert.ToInt32 (Console.ReadLine ());
			var grades = new int [n];
			for (int a0 = 0; a0 < n; a0++) 
			{
				int grade = Convert.ToInt32 (Console.ReadLine ());
				grades [a0] = grade;
			}
			int i = 0;
			foreach(int x in grades)
			{
				if(x > 35)
				{
					if((x % 5) > 2)
					{
						while((grades[i] % 5) > 0)
						{
							grades[i]+=1;
						}
					}
				}
				i++;
			}
			foreach (var x in grades) 
			{
				Console.WriteLine (x);
			}
		}
	}
}
