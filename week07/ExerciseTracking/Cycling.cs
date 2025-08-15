public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

        public override double GetDistance()
    {
        double distance = (_speed / 60) * GetMinutes();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}