public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, double length, double speed) : base (date,length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _length / 60 * _speed;
    }
    public override double CalculateSpeed()
    {
        return _speed;

    }
    public override double CalculatePace()
    {
        return 60 / _speed;
    }

}