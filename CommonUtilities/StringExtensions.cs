using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CommonUtilities
{
	public static class StringExtensions
	{
		public static string ToTitleCase(this string str)
		{
			if (string.IsNullOrWhiteSpace(str))
				return str;

			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
			return textInfo.ToTitleCase(str.ToLower());
		}




		/// <summary>
		/// Trims all extra spaces found in the string.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string TrimExtra(this string str)
		{
			if (str == null)
			{
				return null;
			}
			else if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
			{
				return string.Empty;
			}

			var result = str.Trim();

			for (int k = 0; k < 1000; k++)
			{
				var temp = result.Replace("  ", " ");

				if (temp.Equals(result))
				{
					break;
				}

				result = temp;
			}

			return result;
		}





		/// <summary>
		/// Trims all extra spaces found in the string.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string TrimAll(this string str)
		{
			if (str == null)
			{
				return null;
			}
			else if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
			{
				return string.Empty;
			}

			var result = str.Trim();

			for (int k = 0; k < 1000; k++)
			{
				var temp = result.Replace(" ", "");

				if (temp.Equals(result))
				{
					break;
				}

				result = temp;
			}

			return result;
		}



	}
}