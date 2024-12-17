using System;

public class Rumming : Activity
{
    private float _distance;

    public Rumming(string date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance/_length*60;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }
}