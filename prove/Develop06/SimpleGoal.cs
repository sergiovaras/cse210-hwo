using System;

public class SimpleGoal : Goal  
{  
    private bool _isComplete = false;  

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }  

    public override void RecordEvent()  
    {  
        if (!_isComplete)  
        {  
            _isComplete = true;  
            Console.WriteLine($"Goal '{_shortName}' completed!");  
        }  
    }  

    public override bool IsComplete() => _isComplete;  

    public override string GetStringRepresentation() => base.GetStringRepresentation() + (IsComplete() ? " [X]" : " [ ]");  
}  