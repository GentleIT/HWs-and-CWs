using System;
namespace Program
{
    class Program
    {
        public static void Main(String[] args)
        {
            Plane plane = new Plane();
            Car car = new Car();

            double resCar = car.CalculateTravelTime(800);
            double resPlane = plane.CalculateTravelTime(800);

            Console.WriteLine($"Результат машины: {resCar}, результат самолета: {resPlane}");
        }
    }
}
