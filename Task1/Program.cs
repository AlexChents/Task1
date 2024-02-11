using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			string input = "The \"C# Professional\" course          includes the  topics I discuss in my CLR via C# book and teaches how the CLR works thereby showing you how to develop applications and reusable components for the .NET Framework.";
			//char[] punctuationMarks = { '.', ',', '!', '?', ':',';' };
			//input = input.Trim().Trim(punctuationMarks);
			while (input.IndexOf("  ") != -1)
			{
				input = input.Replace("  ", " ");
			}
			string[] inputArray = input.Split(' ');
			var groupWords = inputArray.Distinct().OrderBy(gw => gw.Length).GroupBy(gw => gw.Length);
			foreach (var group in groupWords)
			{
				Console.WriteLine("Words of length: " + group.Key + ", Count: " + group.Count());
				foreach (var word in group)
				{
					Console.WriteLine(word.ToString());
				}
			}
			Console.ReadKey();
		}
	}
}
