using System;

public class GoalManager  
{  
    private List<Goal> _goals = new List<Goal>();  
    private int _score;  

    public void DisplayMenu()  
    {  
        Console.WriteLine("\nMenu Options:");  
        Console.WriteLine("1. Create a New Goal");  
        Console.WriteLine("2. Record an event for a Goal");  
        Console.WriteLine("3. View all Goals");  
        Console.WriteLine("4. Save Goals");  
        Console.WriteLine("5. Load Goals");  
        Console.WriteLine("6. Exit");  
        Console.Write("Please select an option: ");  
    }  

    public int GetValidInteger(string prompt)  
    {  
        int result;  
        Console.Write(prompt);  
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)  
        {  
            Console.Write("Invalid input. " + prompt);  
        }  
        return result;  
    }  

    public void DisplayPlayerInfo()  
    {  
        Console.WriteLine($"\nCurrent Score: {_score}");  
        foreach (var goal in _goals)  
        {  
            Console.WriteLine(goal.GetStringRepresentation());  
        }  
    }  

    public void CreateGoal(string type)  
    {  
        Console.Write("What is the name of your goal?: ");  
        string name = Console.ReadLine();  
        Console.Write("What is a short description of it?: ");  
        string description = Console.ReadLine();  
        int points = GetValidInteger("What is the amount of points associated with this goal?: ");  

        Goal newGoal = null; 

        if (type == "simple")  
        {  
            newGoal = new SimpleGoal(name, description, points);  
        }  
        else if (type == "eternal")  
        {  
            newGoal = new EternalGoal(name, description, points);  
        }  
        else if (type == "checklist")  
        {  
            int target = GetValidInteger("Enter the target completions: ");  
            int bonus = GetValidInteger("Enter bonus points for completion: ");  
            newGoal = new ChecklistGoal(name, description, points, target, bonus);  
        }  

        if (newGoal != null)  
        {  
            _goals.Add(newGoal);  
            Console.WriteLine($"Goal '{name}' created successfully!");  
        }  
        else  
        {  
            Console.WriteLine("Error creating goal.");  
        }  
    }  

    public void RecordEvent(string name)  
    {  
        var goal = _goals.Find(g => g.GetStringRepresentation().Contains(name));  
        if (goal != null)  
        {  
            goal.RecordEvent();  
            _score += goal.IsComplete() ? goal.Points : 0;  
        }  
        else  
        {  
            Console.WriteLine("Goal not found.");  
        }  
    }  

    public void SaveGoals(string fileName)  
    {  
        using (StreamWriter writer = new StreamWriter(fileName))  
        {  
            writer.WriteLine(_goals.Count); 
            foreach (var goal in _goals)  
            {  
                writer.WriteLine(goal.GetDetailsString()); 
            }  
        }  
        Console.WriteLine("Goals saved successfully.");  
    }  

    public void LoadGoals(string fileName)  
    {  
        if (File.Exists(fileName))  
        {  
            using (StreamReader reader = new StreamReader(fileName))  
            {  
                int goalCount = int.Parse(reader.ReadLine()); 
                
                
                for (int i = 0; i < goalCount; i++)  
                {  
                    string line = reader.ReadLine();  
                    string[] parts = line.Split(" - "); 
                    if (parts.Length >= 3)  
                    {  
                        string name = parts[0];   
                        string description = parts[1];   
                        int points = int.Parse(parts[2].Split(' ')[0]); 
                        Goal loadedGoal = null;  

                        
                        if (line.Contains("(Simple Goal)"))  
                            loadedGoal = new SimpleGoal(name, description, points);  
                        else if (line.Contains("(Eternal Goal)"))  
                            loadedGoal = new EternalGoal(name, description, points);  
                        else if (line.Contains("(Checklist Goal)"))  
                        {  
                             
                            int completed = int.Parse(parts[2].Split('/')[0]);  
                            int target = int.Parse(parts[2].Split('/')[1]);  
                            int bonus = int.Parse(parts[2].Split(':')[1].Trim());  
                            loadedGoal = new ChecklistGoal(name, description, points, target, bonus);  
                        }  
                        
                        if (loadedGoal != null)  
                        {  
                            _goals.Add(loadedGoal);  
                            Console.WriteLine($"Goal '{name}' loaded successfully!");
                        }  
                    }  
                }  
            }  
            Console.WriteLine("Goals loaded successfully.");  
        }  
        else  
        {  
            Console.WriteLine("File not found.");  
        }  
    }  
} 