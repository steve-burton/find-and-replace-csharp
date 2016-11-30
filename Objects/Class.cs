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
				if (replacementWords[index].ToUpper() == findWord.ToUpper())
				{
					replacementWords[index] = replaceWord;
				}
			}
			return string.Join(" ", replacementWords);
		}
	}
}
