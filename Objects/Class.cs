using System.Collections.Generic;
using System;

namespace FindReplace.Objects
{
	public class UserInput
	{
		public static string FindAndReplace(string userInput, string findWord, string replaceWord)
		{
			string[] replacementWords = userInput.Split();
			for (int index = 0; index < replacementWords.Length; index++)
			{
				if (replacementWords[index].ToUpper().Contains(findWord.ToUpper()))
				{
					string word = replacementWords[index];
					int wordIndex = word.ToUpper().IndexOf(findWord.ToUpper());
					string fixedString = word.Substring(0, wordIndex) + replaceWord + word.Substring(wordIndex + findWord.Length, word.Length - wordIndex - findWord.Length);
					replacementWords[index] = fixedString;
				}
			}
			return string.Join(" ", replacementWords);
		}
	}
}
