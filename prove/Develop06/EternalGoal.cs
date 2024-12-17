using System;

public class EternalGoal : Goal  
{  
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }  

    public override void RecordEvent()  
    {  
        Console.WriteLine($"You have read scriptures: {_points} points awarded!");  
    }  

    public override string GetStringRepresentation() => base.GetStringRepresentation() + " (Eternal Goal)";  
}  