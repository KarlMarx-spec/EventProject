using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
	public static class Searcher
	{
		public static T? GetMax<T>(this IEnumerable e, Func<T?, float?> getParameter)
		{
			float? maxValue = float.MinValue;
			T? max = default(T);

			foreach (T? item in e)
			{
				if (getParameter(item) > maxValue)
				{
					maxValue = getParameter(item);
					max = item;
				}
			}

			return max;
		}

		public static float? TTOFloat<T>(T? item)
		{
			float value = 0f;
			if (item == null)
				return 0f;
			else
				float.TryParse(item.ToString(), out value);

			return value;
		}
	}
}
