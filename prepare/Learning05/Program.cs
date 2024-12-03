using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Benneett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assigment2 = new MathAssignment("Robert Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());


        WritingAssignment assigment3 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}