using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOccurenciesCounter
{
    public class OccurenciesCounter
    {
		public static string GetFirstMaxOccurringWord(string input)
		{
			var result = input.Split(' ')
				.GroupBy(w => w, (k, l) => new { Key = k, Count = l.Count() })
				.OrderByDescending(o => o.Count).FirstOrDefault()?.Key ?? string.Empty;
			return result;
		}

		public static string GetFirstMaxOccurringWordRedux(string input)
		{
			var maxOccurencies = 0;
			var firstMaxWord = string.Empty;
			var bucket = new Dictionary<string, int>();
			foreach (var currentWord in input.Split(' '))
			{
				if (!bucket.ContainsKey(currentWord))
				{
					bucket.Add(currentWord, 1);
				}
				else
				{
					bucket[currentWord] += 1;
				}
				if (bucket[currentWord] > maxOccurencies)
				{
					maxOccurencies = bucket[currentWord];
					firstMaxWord = currentWord;
				}
			}
			return firstMaxWord;
		}
	}
}
