using System.Collections.Generic;

namespace FindReplace.Objects
{
	public class UserInput
	{
		public string FindAndReplace(string userInput, string findWord, string replaceWord)
		{
			string replacementString = userInput;
			if (userInput.ToUpper() == findWord.ToUpper())
			{
				replacementString = replaceWord;
			}
			return replacementString;
		}
	}
}
