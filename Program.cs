using System;
using System.Diagnostics;
using System.Linq;

namespace Shuffle
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please enter an integer");
			var input = Console.ReadLine();
			int inputNumber = 0;
			if (!string.IsNullOrEmpty(input) && int.TryParse(input, out inputNumber))
			{
				Stopwatch sw = new Stopwatch();
				sw.Start();

				var shuffleNumList = Logic.Shuffle(inputNumber);
				sw.Stop();

				if (shuffleNumList.Length > 0) {
					Console.WriteLine();
					shuffleNumList.ToList().ForEach(item => Console.Write(item + " "));

					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("Elapsed={0}", sw.Elapsed);
				}					
				else {
					Console.WriteLine("There are no positive integer less than the input integer");
				}
			} else {
				Console.WriteLine("Please enter valid value. Exited !!!");
			}
			Console.ReadLine();
		}
	}
}
