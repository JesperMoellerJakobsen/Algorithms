using BinarySearch;
using NUnit.Framework;
using System;

namespace BinarySearch
{
	[TestFixture]
	class Tests
	{	
		[Test]
		public void TestListOne()
		{
			int[] numbers = { 1, 3, 5, 7, 9, 15, 68, 99, 152 };

			foreach (var number in numbers)
			{
				var indexOfficialMethod = Array.IndexOf(numbers, number);
				var indexBinarySearch = numbers.FindIndexOf(number);

				Assert.That(indexOfficialMethod, Is.EqualTo(indexBinarySearch));
			}
		}

		[Test]
		public void TestListTwo()
		{
			int[] numbers = { 4, 7, 9, 23, 67, 68, 165, 188, 211, 255, 655 };

			foreach (var number in numbers)
			{
				var indexOfficialMethod = Array.IndexOf(numbers, number);
				var indexBinarySearch = numbers.FindIndexOf(number);

				Assert.That(indexOfficialMethod, Is.EqualTo(indexBinarySearch));
			}
		}

		[Test]
		public void TestListNotFund()
		{
			int[] numbers = { 4, 7, 9, 23, 67, 68, 165, 188, 211, 255, 655 };
			int indexBinarySearch = numbers.FindIndexOf(6000);
			int notFoundIndex = -1;

			Assert.That(indexBinarySearch, Is.EqualTo(notFoundIndex));
		}

		[Test]
		public void TestNullList()
		{
			int[] numbers = { 4, 7, 9, 23, 67, 68, 165, 188, 211, 255, 655 };
			int indexBinarySearch = numbers.FindIndexOf(6000);
			int notFoundIndex = -1;

			Assert.That(indexBinarySearch, Is.EqualTo(notFoundIndex));
		}
}
