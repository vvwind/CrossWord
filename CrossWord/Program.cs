using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace CrossWord
{
	public static class WG
	{
		public static string[,] Other_words(string[,] myArr, string variant2)
		{
			for (int i = 0; i < variant2.Length; i++)
			{
				myArr[i + 5, 3] = variant2[i].ToString();
			}
			return myArr;
		}
	}







	public static class GFG
	{

		public static string[,] Init(string[,] myArr)
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
		public static void Print(string[,] myArr)
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
		static string variant;
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
			int rand_num = rd.Next(7, 10);
			int rand_num0 = rd.Next(1, 20);


			foreach (KeyValuePair<string, int> kvp in my_dct)
			{
				if (rand_num == kvp.Value && kvp.Key[0] == rus[rand_num0])
				{
					variant = kvp.Key;
					break;
				}
			}
			Console.WriteLine(variant);
			for (int j = 0; j < variant.Length; j++)
			{
				myArr[5, j] = variant[j].ToString();

			}

			int rand_num2 = rd.Next(3, 5);
			foreach (KeyValuePair<string, int> kvp in my_dct)
			{
				if (rand_num2 == kvp.Value && kvp.Key[0] == variant[3])
				{
					variant2 = kvp.Key;
					break;
				}

			}
			Console.WriteLine(variant2);
			WG.Other_words(myArr, variant2);
			GFG.Print(myArr);
		}
	}


}