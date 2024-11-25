using System;

public class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding. \n In all your ways submit to Him, and He will make your paths straight.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureText());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("Well done!");
                break;
            }

            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1); 
        }
    }
}
