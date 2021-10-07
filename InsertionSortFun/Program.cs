﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortFun
{
    class Program
    {
        static void Main(string[] args)
        {
			//declaring and instantiating a test array of unsorted numbers
			int[] test = new int[9];
			test[0] = 6;
			test[1] = 4;
			test[2] = 7;
			test[3] = 2;
			test[4] = 8;
			test[5] = 9;
			test[6] = 1;
			test[7] = 3;
			test[8] = 5;

			//Declaring and instantiating the sort object
			InsertionSort sorting = new InsertionSort();
			//calling the sort method and assigning the returned array to the result array
			int[] result = sorting.sort(test);
			//Cycle through and print the result array
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(result[i]);
			}
		}
    }
}
