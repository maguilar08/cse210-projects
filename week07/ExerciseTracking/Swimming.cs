public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = (_laps * 50) / 1000.0; // 1000.0 makes all double --with 1000 consider all integer and lose decimals.
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetMinutes()) * 60;
        return speed;
    }
    
    public override double GetPace()
    {
        double pace = GetMinutes() / GetDistance();
        return pace;
    }


}