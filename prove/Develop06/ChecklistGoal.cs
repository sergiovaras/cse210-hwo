using System;

public class ChecklistGoal : Goal  
{  
    private int _amountCompleted = 0;  
    private int _target;  
    private int _bonus;  

    public ChecklistGoal(string name, string description, int points, int target, int bonus)  
        : base(name, description, points)  
    {  
        _target = target;  
        _bonus = bonus;  
    }  

    public override void RecordEvent()  
    {  
        if (_amountCompleted < _target)  
        {  
            _amountCompleted++;  
            Console.WriteLine($"Goal '{_shortName}': Progress updated! {_amountCompleted}/{_target} completed.");  
            if (IsComplete())  
            {  
                Console.WriteLine($"Goal '{_shortName}' complete! Bonus: {_bonus} points awarded!");  
            }  
        }  
    }  

    public override bool IsComplete() => _amountCompleted >= _target;  

    public override string GetStringRepresentation() => base.GetStringRepresentation() + $" [Completed {_amountCompleted}/{_target}]";  
}  