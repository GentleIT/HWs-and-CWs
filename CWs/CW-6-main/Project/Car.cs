public class Car : Transport
{
    private int _speed;
    public Car(int _speed = 80)
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
        Console.WriteLine($"Какая-то инфа и {_speed}");
    }
}