using Nancy;
using System.Collections.Generic;
using FindReplace.Objects;

namespace FindReplace
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				Dictionary<string, string> objects = new Dictionary<string, string>();
				objects["HasSentence"] = "false";
				return View["index.cshtml", objects];
			};
			Post["/"] = _ =>
			{
				Dictionary<string, string> objects = new Dictionary<string, string>();
				objects["HasSentence"] = "true";
				string userString = Request.Form["userString"];
				string findWord = Request.Form["findWord"];
				string replaceWord = Request.Form["replaceWord"];
				objects["ReplacedSentence"] = UserInput.FindAndReplace(userString, findWord, replaceWord);
				return View["index.cshtml", objects];
			};
		}
	}
}
