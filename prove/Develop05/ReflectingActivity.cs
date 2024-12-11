using System;

public class ReflectingActivity : Activity
{
    private   List<string> _pompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _question = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public ReflectingActivity() :  base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }
        
        private string GetRandomPrompt()
        {
            Random rand =new Random();
            return _pompts[rand.Next(_pompts.Count)];
        }

        private string GetRandomQuestion()
        {
            Random rand = new Random();
            return _question[rand.Next(_question.Count)];

        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
            Console.WriteLine("When you are ready,think deeply about it..");

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine($"\nQuestion: {GetRandomQuestion()}");
                ShowSpinner(5);
            }

            DisplayEndingMessage();
        }

}