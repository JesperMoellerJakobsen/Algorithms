
namespace BinarySearch
{
	public static class BinarySearchAlgorithm
	{
		public static int FindIndexIterative(this int[] array, int valueToFind)
		{
			if (array is null || array.Length == 0)
				return -1;

			int min = 0;
			int max = array.Length - 1;

			while (min <= max)
			{
				int mid = (min + max) / 2;
				int foundNumber = array[mid];
				if (valueToFind == foundNumber)
				{
					return mid;
				}
				else if (valueToFind < foundNumber)
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return -1;
		}


		public static int FindIndexRecursive(this int[] array, int valueToFind)
		{
			if (array is null || array.Length == 0)
				return -1;

			return FindByIndex(array, 0, array.Length - 1, valueToFind);
		}

		private static int FindByIndex(int[] array, int min, int max, int numberToFind)
		{
			if (min > max)
			{
				//Not found condition
				return -1;
			}

			int mid = min + (max - min) / 2;
			int foundNumber = array[mid];

			// Found value? Return index
			if (foundNumber == numberToFind)
				return mid;

			// Left leg search
			if (foundNumber > numberToFind)
				return FindByIndex(array, min, mid - 1, numberToFind);

			// Right leg search
			return FindByIndex(array, mid + 1, max, numberToFind);
		}
	}
}
