using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOccurenciesCounter;

namespace TestProject
{
	[TestClass]
	public class StringTests
	{
		[TestMethod]
		public void Result_Should_Be_The_Word_Known()
		{
			// Arrange
			var input = "If you know the enemy and know yourself you need not fear the results of a hundred battles";

			// Act
			var firstWord = OccurenciesCounter.GetFirstMaxOccurringWord(input);

			// Assert
			Assert.AreEqual("know", firstWord);
		}
	}
}
