using System;
using System.Text.RegularExpressions;

namespace AddressBook
{
	internal static class Utilities
	{
		/// <summary>
		/// Get the text of the first match to pattern in source
		/// </summary>
		/// <param name="source"></param>
		/// <param name="pattern"></param>
		/// <returns>The text of the first match to pattern in source if a match is found, empty string otherwise</returns>
		public static String getRegexMatch(String source, String pattern)
		{
			String result = String.Empty;

			if (source != null)
			{
				Regex regex = new Regex(pattern);
				Match match = regex.Match(source);

				if (match != null)
				{
					result = match.Value;
				}
			}

			return result;
		}
	}
}