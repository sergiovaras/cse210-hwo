using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length,int laps) : base (date,length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps*50/100.0f;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _length*60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}