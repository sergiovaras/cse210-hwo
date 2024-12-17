using System;

public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date,int length,float speed) : base (date,length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * _length/60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60/GetSpeed();
    }
}