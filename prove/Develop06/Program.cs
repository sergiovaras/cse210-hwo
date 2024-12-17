using System;  
using System.Collections.Generic;  
using System.IO;  
using System.Text.Json; 


class Program  
{  
    static void Main(string[] args)  
    {  
        GoalManager manager = new GoalManager();  
        bool running = true;  

        while (running)  
        {  
            manager.DisplayMenu();  
            string choice = Console.ReadLine();  

            try  
            {  
                switch (choice)  
                {  
                    case "1":  
                        Console.Write("Choose goal type (simple/eternal/checklist): ");  
                        string type = Console.ReadLine().ToLower();  
                        manager.CreateGoal(type);  
                        break;  
                    case "2":  
                        Console.Write("Enter the name of the goal to record an event: ");  
                        string goalName = Console.ReadLine();  
                        manager.RecordEvent(goalName);  
                        break;  
                    case "3":  
                        manager.DisplayPlayerInfo();  
                        break;  
                    case "4":  
                        Console.Write("Enter a name for your file: ");
                        string savedFileName = Console.ReadLine();
                        manager.SaveGoals(savedFileName);  
                        break;  
                    case "5":
                        Console.Write("Enter a name for your file: ");
                        string loadedFileName = Console.ReadLine();
                        manager.LoadGoals(loadedFileName);  
                        break;  
                    case "6":  
                        running = false;  
                        break;  
                    default:  
                        Console.WriteLine("Invalid option, please try again.");  
                        break;  
                }  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine($"An error occurred: {ex.Message}");  
            }  
        }  
    }  
}  