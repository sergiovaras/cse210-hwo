using System;

class Program
{
    static void Main(string[] args)
    {
       Rumming rummingActivity =   new Rumming("03 Nov 2014",30,4);
       Cycling cyclingActivity =   new Cycling("05 May 2024",45,60);
       Swimming swimmingActivity = new Swimming("06 Apr 2024",60,40);
       List<Activity> activities = new List<Activity>();
       activities.Add(rummingActivity);
       activities.Add(cyclingActivity);
       activities.Add(swimmingActivity);

       foreach (var Activity in activities)
       {
        Console.WriteLine(Activity.GetSummary());
        
       }
    }
}