using System;
using System.Text.RegularExpressions;

namespace Disemvoweling
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args != null && args.Length == 1)
			{
                try
                {
				    string inputPhrase = getInputPhrase(args[0]);
                    string disemvowledPhrase = Disemvowler.Disemvowel(inputPhrase);
                    string vowels = Disemvowler.GetVowels(inputPhrase);

                    Console.WriteLine(disemvowledPhrase);
                    Console.WriteLine(vowels);
                }
                catch (InputPhraseException e)
                {
                    showError(e);
                }
			}
			else
			{
				showUsage();
			}
        }

        private static string getInputPhrase(string argument)
        {
            const string pattern = @"^[a-z\ ]*$";
        
            if(new Regex(pattern, RegexOptions.Singleline).IsMatch(argument)) return argument;

            throw new InputPhraseException($"Intput does not match \'{pattern}\'");
        }

        private static void showUsage()
		{
			Console.WriteLine($"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name} \"<input>\"");
			Console.WriteLine("Where:");
			Console.WriteLine("\t<input> - string of words to disemvowel in all lowercase (letters a-z) and without punctuation but including spaces.");
		}

        private static void showError(Exception e)
		{
			if(e != null) Console.WriteLine($"An error occurred:\n\t{e.Message}");
		}
    }
}
