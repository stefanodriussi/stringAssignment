# String occurrencies counter
A quick attempt to solve an assignment. Unfortunately i failed to complete the task in the due time but still I wanted to resolve it.

# Assignment
Find first most occurring word within a string. Example, given the string "If you know the enemy and know yourself you need not fear the results of a hundred battles" the result should be the word "know"

## First try
Since the short time at my disposal, my first attempt to solve this problem didn't account for an important detail: the 'first' most occurring word.

		public static string GetFirstMaxOccurringWord(string input)
		{
			var result = input.Split(' ')
				.GroupBy(w => w, (k, l) => new { Key = k, Count = l.Count() })
				.OrderByDescending(o => o.Count).FirstOrDefault()?.Key ?? string.Empty;
			return result;
		}
    
## Second try
With a little more time I came to this second solution. While not very elegant, it does the trick:

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
