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
    }
}
