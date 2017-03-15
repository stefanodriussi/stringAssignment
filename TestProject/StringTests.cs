using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOccurenciesCounter;

namespace TestProject
{
	[TestClass]
	public class StringTests
	{
		[TestMethod]
		public void Result_Should_Not_Be_The_Word_Known()
		{
			// Arrange
			var input = "If you know the enemy and know yourself you need not fear the results of a hundred battles";

			// Act
			var firstWord = OccurenciesCounter.GetFirstMaxOccurringWord(input);

			// Assert
			Assert.AreNotEqual("know", firstWord);
		}

		[TestMethod]
		public void Result_Should_Be_The_Word_Known()
		{
			// Arrange
			var input = "If you know the enemy and know yourself you need not fear the results of a hundred battles";

			// Act
			var firstWord = OccurenciesCounter.GetFirstMaxOccurringWordRedux(input);

			// Assert
			Assert.AreEqual("know", firstWord);
		}
	}
}
