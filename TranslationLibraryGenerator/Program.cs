using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Translation.V2;

namespace GoogleCloudTranslation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			TranslationClient client = TranslationClient.Create();
			var response = client.TranslateText("I have an apple.", "ja", "en");
			Console.WriteLine(response.TranslatedText);
		}
	}
}
