using System;
using System.Collections.Generic;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal!");
        string choice;
        Journal journal = new();
        do
        {
            Console.WriteLine("Select one option: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            Console.Write(""); 
            choice = Console.ReadLine();
            if (choice == "1")
            {
                PromptGenerator _prompts = new PromptGenerator();
                string randomPrompt = _prompts.GetRandomPrompt();
                Console.WriteLine(""); 
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new()
                {
                    _date = dateText,
                    _promptText = randomPrompt,
                    _entryText = response
                };
                journal._entries.Add(entry);
                Console.WriteLine(""); 
            }
            else if (choice == "2")
            {
                Console.WriteLine(""); 
                journal.DisplayAll();
                Console.WriteLine(""); 
            }
            else if (choice == "3")
            {
                Console.WriteLine(""); 
                Console.WriteLine("What is the name of the file?");
                string file = Console.ReadLine();
                journal._file = file;
                journal.LoadFromFile(journal._file);
                Console.WriteLine(""); 
                Console.WriteLine($"File was opened correctly");
            }
            else if (choice == "4")
            {
                Console.WriteLine(""); 
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                journal._file = fileName;
                journal.SaveToFile(journal._entries);
                Console.WriteLine(""); 
                Console.WriteLine($"File saved as {fileName}");
                journal._entries.Clear();
            }
            else if (choice == "5")
            {
                Console.WriteLine("");
                Console.WriteLine("End for today!");
                Console.WriteLine(""); 
            }
            else
            {
                Console.WriteLine(); 
                Console.WriteLine(" Invalid Choice");
                Console.WriteLine(); 
            }
        } 
        while (choice != "5");
    }
}