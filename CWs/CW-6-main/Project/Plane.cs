public class Plane : Transport
{
    private int _speed;
    public Plane(int _speed = 600)
    {
        this._speed = _speed;
    }

    public override double CalculateTravelTime(double distance)
    {
        double t = distance / _speed;
        return t;
    }
    public override void GetTransportInfo()
    {
        Console.WriteLine($"Какая та инфа и {_speed}");
    }
}