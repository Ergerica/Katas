using System;
using System.IO;
using System.Linq;
namespace HelloWorld2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			// using stream reader cuz reading form the file at home// nota cambia r codigo a que sea para cualquiera con el setting
			using (StreamReader file = new StreamReader("/home/erica/textFile"))  
			{  
				int counter = 0;  
				string ln;  
			
				while ((ln = file.ReadLine()) != null)  
				{  
					string temp = SortString (ln);
					//Console.Write(ln+ " ");  
					counter++;  
					using (StreamReader files = new StreamReader("/home/erica/textFile"))  
					{  
						int counters = 0;  
						string lns;  
						//anidad :9 por eso esta tan lento pero permite revisar los files
						while ((lns = files.ReadLine()) != null)  
						{  
							string temp2 = SortString (lns);
							if (temp == temp2)
								Console.Write (lns+ " ");

							//Console.WriteLine(lns);  
							counters++;  
						}  
						Console.WriteLine ();
						files.Close();  
						//Console.WriteLine($"File has {counter} lines.");  
					}  
				}  
				file.Close();  
				//Console.WriteLine($"File has {counter} lines.");  
			}  

		}
		//algorithm used to sort string :0 surprise surprise
		static string SortString(string input)
		{
			char[] characters = input.ToArray();
			Array.Sort(characters);
			return new string(characters);
		}

	}
}
	