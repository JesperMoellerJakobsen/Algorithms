namespace SimpleAlgorithms
{
	public class PrimeNumberFinder
	{
		public bool IsPrime(int number)
		{
			if (number < 2) //0 1 and negative cannot be prime
				return false;

			int top = number / 2;

			for (int i = 2; i <= top; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
