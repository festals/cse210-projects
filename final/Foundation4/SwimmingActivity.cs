public class SwimmingActivity : Activity
{
    private int _numLaps;

    public SwimmingActivity(string date, double length, int laps) : base (date,length)
    {
        _numLaps = laps;
    }

    public override double CalculateDistance()
    {
        return _numLaps * 50 / 1000;
    }
    public override double CalculateSpeed()
    {
        return (CalculateDistance() / _length) * 60;

    }
    public override double CalculatePace()
    {
        return _length / (CalculateDistance());
    }

}