using System;
namespace Program
{
    class Program
    {
        public static void Main(String[] args)
        {
            Product sanchovies = new Product("sanchovies", 150, 20); // Создал объект или же экземпляр.
            Console.WriteLine(sanchovies.GetProductInfo());
            sanchovies.UpdatePrice(165); // Подорожали санчоусы
            sanchovies.Restock(20); // Пополнили запас санчоусов!
            sanchovies.Sell(15); // Продали санчоусы по хорошей цене.
            Console.WriteLine(sanchovies.GetProductInfo() + "\n");
            sanchovies.Sell(25);
            System.Console.WriteLine(sanchovies.GetProductInfo());
            sanchovies.Sell(26);
            System.Console.WriteLine(sanchovies.GetProductInfo());
        }
    }
}
