using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace CrossWord
{
	public static class RG
	{
		
		public static string MainW(Dictionary<string, int> my_dct, string variant, string rus, int rand_num, int rand_num0)
		{
			
			foreach (KeyValuePair<string, int> kvp in my_dct)
			{
				if (rand_num == kvp.Value && kvp.Key[0] == rus[rand_num0])
				{
					variant = kvp.Key;
					return variant;
					
				}
			}
			return variant;


		}

		public static string OtherW(Dictionary<string, int> my_dct, string variant, int rand_num2, string variant2)
		{
			foreach (KeyValuePair<string, int> kvp in my_dct)
			{
				if (rand_num2 == kvp.Value && kvp.Key[0] == variant[0])
				{
					variant2 = kvp.Key;
					return variant2;
				}

			}
			return variant2;
		}




	}





	public static class WG
	{

		public static string[,] Main_word(string[,] myArr, string variant)
		{
			for (int j = 0; j < variant.Length; j++) 
			{
				myArr[5, j] = variant[j].ToString();

			}
			return myArr;
		}


		public static string[,] Other_words(string[,] myArr, string variant2)
		{
			for (int i = 0; i < variant2.Length; i++)
			{
				myArr[i + 5, 0] = variant2[i].ToString();
			}
			return myArr;
		}
	}

	public static class GFG
	{

		public static string[,] Init(string[,] myArr) // Initialization with .
		{
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					myArr[i, j] = ".";

				}


			}
			return myArr;
		}
		public static void Print(string[,] myArr) // Printing array
		{

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write(myArr[i, j]);
				}

				Console.WriteLine();
			}

		}

	}
	class Program
	{
		private static string path = "C:/Users/vladi/source/repos/CrossWord/CrossWord/russian_nouns.txt";
		static string variant = " ";
		static string rus = "абвгдежзиклмнопрстуфхцчшщэюя";
		static string variant2;
		
		private static Dictionary<string, int> my_dct = new Dictionary<string, int>();
		public static string[,] myArr = new string[20, 20];



		static void Main()
		{

			var enumLines = File.ReadLines(path, Encoding.UTF8);

			foreach (var line in enumLines)
			{
				my_dct.Add(line, line.Length);
			}

			myArr = GFG.Init(myArr);
			Random rd = new Random();
			int rand_num = rd.Next(7, 11);
			int rand_num0 = rd.Next(1, 20);
			variant = RG.MainW(my_dct,variant,rus,rand_num,rand_num0);
			Console.WriteLine(variant);
			WG.Main_word(myArr, variant);

			int rand_num2 = rd.Next(3, 6);
			
			variant2 = RG.OtherW(my_dct,variant,rand_num2,variant2);
			Console.WriteLine(variant2);
			WG.Other_words(myArr, variant2);
			GFG.Print(myArr);
		}
	}


}