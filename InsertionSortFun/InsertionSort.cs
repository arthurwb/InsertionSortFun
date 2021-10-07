/*
 * Bill Nicholsonm
 * nicholdw@ucmail.uc.edu
 */

namespace InsertionSortFun
{
	/// <summary>
	/// Perform insertion sort operations
	/// </summary>
    class InsertionSort
	{
	/// <summary>An insertion sort</summary>
	/// <param name="numArray">The array to be sorted</param>
	/// <returns>the sorted array</returns>
		public int[] sort(int[] numArray)
		{
			//Cycle through the original array
			for (int i = 1; i < numArray.Length; i++)
			{
				//Set the current number at the index to x for safe keeping
				int x = numArray[i];
				//Set j to equal the index before the current index
				int j = i - 1;
				//Loop determines if the immediate previous indexes number is greater than the current number, and if it is, move the current number back 1 index
				while (j >= 0 && numArray[j] > x)
				{
					//Replace the number at index i with the number at index j
					numArray[j + 1] = numArray[j];
					//Subtracts 1 from j to move backwards through the array
					j = j - 1;
				}
				//Adds 1 back to j and inserts the current indexes number back into the array where it belongs
				numArray[j + 1] = x;
			}
			//Returns the sorted array
			return numArray;
		}
	}
}
