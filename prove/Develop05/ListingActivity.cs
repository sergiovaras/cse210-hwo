using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
        Console.WriteLine("You have a few seconds to think before starting...");
        ShowCountDown(5);

        Console.WriteLine("\nStart listing items now:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> userResponses = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userResponses.Add(response);
            }
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items!");
        DisplayEndingMessage();
    }
}