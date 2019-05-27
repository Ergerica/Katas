using System;
using System.IO;
using System.Linq;
namespace HelloWorld2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("give place where txt file is");
			string path = Console.ReadLine();
			int longestAngramSize=0;
			string longestAnagram="";
			using (StreamReader sr = new StreamReader (path)) 
			{
				string ln,tmp;

				while ((ln = sr.ReadLine ()) != null)
				{
					tmp = SortString (ln);
					int counter = 0;
				// longestAnagram="";
					using (StreamReader srr = new StreamReader(path)) 
					{
						string line;
						while ((line = srr.ReadLine()) != null) 
						{
							string tmp2 = SortString(line);
							if (tmp == tmp2) 
							{
								counter++;
								Console.Write (line);
							}
							if (counter >= 2) 
							{
								longestAngramSize = Math.Max(longestAngramSize, line.Length);
								if (longestAngramSize == line.Length)
								{
									longestAnagram = ln;
								}
							}
							
						}
						Console.WriteLine ();
					}
				}
			}
			Console.WriteLine ("LONGESTANAGRA" + longestAnagram);
		}

		static string SortString(string input)
		{
			char[] characters = input.ToArray();
			Array.Sort(characters);
			return new string(characters);
		}

	}
}
