using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Translation.V2;

namespace GoogleCloudTranslation
{
	class Program
	{
		/// <summary>
		/// Google Cloud Translation Sample
		/// </summary>
		/// <param name="args">args[0]: Text, args[1]: Target Language (e.g. "ja"), args[2]: Source Language (e.g. "en")</param>
		static void Main(string[] args)
		{
			string text = "I have an apple.";
			string targetLanguage = "ja";
			string sourceLanguage = "en";

			if (args.Length == 3)
			{
				text = args[0];
				targetLanguage = args[1];
				sourceLanguage = args[2];
			}
			else
			{
				Console.WriteLine("\n  Invalid argument. args[0]: Text, args[1]: Target Language (e.g. \"ja\"), args[2]: Source Language (e.g. \"en\")");
				Console.WriteLine("\n  Use default value. args[0]="+text+", args[1]="+targetLanguage+", args[2]="+sourceLanguage);
			}

			Console.OutputEncoding = System.Text.Encoding.Unicode;
			TranslationClient client = TranslationClient.Create();
			TranslationResult response = client.TranslateText(text, targetLanguage, sourceLanguage);
			Console.WriteLine(response.TranslatedText);
		}
	}
}
