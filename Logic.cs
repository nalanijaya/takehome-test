using System;
using System.Collections.Generic;

namespace Shuffle
{
	public static class Logic
	{
		//This is for the following logic:
		// Input a single integer N. Output the positive integers less than N in random order.
		public static int[] Shuffle(int number)
		{
			int[] numList = new int[] { };

			if (number <= 0) { //Skip negative and number 0
				return numList;
			} else {
				Random rd = new Random();
				int index = 0;
				numList = new int[number - 1];
				for (int i = 1; i < number; i++) { //O(n)
					numList[index] = i;
					index++;
				}

				if (numList.Length > 0) {
					for (int i = 0; i < numList.Length; i++){  //O(n)
						int r = rd.Next(i, numList.Length - 1); //random index
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
