using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>();
        
        _prompts.Add("What did I learn today that surprised me?");
        _prompts.Add("What decision did I make today that I'm proud of?");
        _prompts.Add("What did I do today that brought me closer to my goals?");
        _prompts.Add("What am I most grateful for today?");
        _prompts.Add("If you could relive a moment from today, what would it be and why?");
    

        Random randomGenerator = new Random();
        int prompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[prompt];
    }
}