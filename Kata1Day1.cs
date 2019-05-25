using System;
using System.IO;
namespace HelloWorld2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (StreamReader file = new StreamReader ("textFile")) 
			{
				int counter = 0;
				string ln;
				while ((ln = file.ReadLine ()) != null) 
				{
					Console.WriteLine (ln);
					counter++;
				}

			}
		}
	}
}
	