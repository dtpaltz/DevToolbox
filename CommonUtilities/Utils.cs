using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommonUtilities
{
	public static class Utils
	{
		public static string[] GetLines(string input)
		{
			var lines = input.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			return lines;
		}

		public static string[] GetWords(string input)
		{
			input = input.Replace("<", "");
			input = input.Replace(">", "");

			MatchCollection matches = Regex.Matches(input, @"\b\w+\b");

			var words = from m in matches.Cast<Match>()
						where !string.IsNullOrEmpty(m.Value)
						select TrimSuffix(m.Value);

			return words.ToArray();
		}

		public static string TrimComments(string input)
		{
			var allLines = GetLines(input);

			string newText = string.Empty;
			int n = allLines.Length;
			for (int i = 0; i < n; i++)
			{
				string line = TrimGlobal(allLines[i]);

				if (line.StartsWith("//") || line.StartsWith("/*") || line.StartsWith("*") || line.StartsWith("*/"))
				{
					// skip this line
					continue;
				}
				else if (line.Contains("//"))
				{
					int commentIdx = line.IndexOf("//");
					string newLine = line.Substring(0, commentIdx) + Environment.NewLine;

					if (newLine.Trim().Length > 0)
					{
						newText += newLine + Environment.NewLine;
					}
				}
				else
				{
					newText += line + Environment.NewLine;
				}
			}

			return newText.Remove(newText.LastIndexOf(Environment.NewLine));
		}

		private static string TrimSuffix(string word)
		{
			int apostropheLocation = word.IndexOf('\'');
			if (apostropheLocation != -1)
			{
				word = word.Substring(0, apostropheLocation);
			}

			return word;
		}

		/// <summary>
		/// Trims all extra spaces found in the string.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string TrimGlobal(string input)
		{
			var result = input.Trim();

			for (int k = 0; k < 1000; k++)
			{
				result = result.Replace("  ", " ");
			}

			return result;
		}






		public static List<string> ExtractNumbers(string str)
		{
			if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
			{
				return null;
			}

			MatchCollection matches = Regex.Matches(str, @"\d+");



			// Remove duplicates
			var distinctMatches = matches.Cast<Match>()
										  .Select(m => m.Value)
										  .Distinct()
										  .ToList();


			return distinctMatches;
		}




		public static string ReplaceLastOccurrence(string source, string find, string replace)
		{
			int place = source.LastIndexOf(find);

			if (place == -1) // If the substring is not found
			{
				return source;
			}

			// Remove the 'find' string from its last occurrence
			string temp = source.Remove(place, find.Length);

			// Insert the 'replace' string at the same position
			return temp.Insert(place, replace).TrimEnd();
		}


		public static string ReplaceFirstOccurrence(string source, string find, string replace)
		{
			int place = source.IndexOf(find);

			if (place == -1) // If the substring is not found
			{
				return source;
			}

			// Remove the 'find' string from its last occurrence
			string temp = source.Remove(place, find.Length);

			// Insert the 'replace' string at the same position
			return temp.Insert(place, replace).TrimStart();
		}
	}
}
