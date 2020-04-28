using NUnit.Framework;
using System;

namespace BinarySearch
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestList()
		{
			int[] numbers = { 4, 7, 9, 23, 67, 68, 165, 188, 211, 255, 655 };

			foreach (var number in numbers)
			{
				var indexOfficialMethod = Array.IndexOf(numbers, number);
				var indexBinarySearchRecursive = numbers.FindIndexRecursive(number);
				var indexBinarySearchIterative = numbers.FindIndexIterative(number);

				Assert.That(indexOfficialMethod, Is.EqualTo(indexBinarySearchRecursive));
				Assert.That(indexOfficialMethod, Is.EqualTo(indexBinarySearchIterative));
			}
		}

		[Test]
		public void TestListNotFund()
		{
			int[] numbers = { 4, 7, 9, 23, 67, 68, 165, 188, 211, 255, 655 };
			int indexBinarySearchRecursive = numbers.FindIndexRecursive(6000);
			int indexBinarySearchIterative = numbers.FindIndexIterative(6000);
			int notFoundIndex = -1;

			Assert.That(indexBinarySearchRecursive, Is.EqualTo(notFoundIndex));
			Assert.That(indexBinarySearchIterative, Is.EqualTo(notFoundIndex));
		}

		[Test]
		public void TestNullList()
		{
			int[] numbers = null;
			int indexBinarySearchRecursive = numbers.FindIndexRecursive(6000);
			int indexBinarySearchIterative = numbers.FindIndexRecursive(6000);
			int notFoundIndex = -1;

			Assert.That(indexBinarySearchRecursive, Is.EqualTo(notFoundIndex));
			Assert.That(indexBinarySearchIterative, Is.EqualTo(notFoundIndex));
		}
	}
}
