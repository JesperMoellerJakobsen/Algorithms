using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
	public static class BinarySearchAlgorithm
	{
		public static int FindIndexOf(this int[] array, int numberToFind)
		{
			if (array is null || array.Length == 0)
				return -1;

			var maxIndex = array.Length - 1;
			var searchedIndex = maxIndex / 2;
			return FindByIndex(array, searchedIndex, maxIndex, numberToFind);
		}

		private static int FindByIndex(int[] array, int indexToSearch, int maxIndex, int numberToFind)
		{
			var foundValue = array[indexToSearch];

			if (foundValue == numberToFind)
				return indexToSearch;

			if(foundValue > numberToFind) //Left leg search
				return FindByIndex(array, indexToSearch/2, indexToSearch, numberToFind);


			//Right-leg search
			int newIndexToSearch = (indexToSearch + maxIndex) / 2;
			if (newIndexToSearch == indexToSearch)
			{
				//Dont search what we just tried. Try rounding up. Integer division cuts decimals.
				newIndexToSearch++;
			}

			if (newIndexToSearch > maxIndex) //Index is outside of search range, which means the value is not found.
				return -1;

			return FindByIndex(array, newIndexToSearch, maxIndex, numberToFind);
		}
	} 
}
