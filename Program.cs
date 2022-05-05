using System;
using System.Diagnostics;

namespace Shuffle
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Please enter an integer");
			var inputNumber = Console.ReadLine();

			if (!string.IsNullOrEmpty(inputNumber))
			{
				Stopwatch sw = new Stopwatch();
				sw.Start();
				var shuffleNumList = Logic.Shuffle(Convert.ToInt32(inputNumber));
				sw.Stop();

				if (shuffleNumList.Count > 0) {
					Console.WriteLine();
					shuffleNumList.ForEach(item => Console.Write(item + " "));

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
