using System;
using System.Collections.Generic;

namespace Shuffle
{
	public static class Logic
	{
		//This is for the following logic:
		// Input a single integer N. Output the positive integers less than N in random order.
		public static List<int> Shuffle(int number)
		{
			var numList = new List<int>();

			if (number <= 0) { //Skip negative and number 0
				return numList;
			} else {
				Random rd = new Random();
				for (int i = 1; i < number; i++) { //O(n)
					numList.Add(i);
				}

				if (numList.Count > 0) {
					for (int i = 0; i < numList.Count; i++){  //O(n)
						int r = rd.Next(i, numList.Count - 1); //random index
															   //swapping
						int temp = numList[r];
						numList[r] = numList[i];
						numList[i] = temp;
					}
				}
			}
			return numList;
		}
	}
}
