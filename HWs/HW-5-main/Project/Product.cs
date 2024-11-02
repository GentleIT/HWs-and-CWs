
public class Product
{
    // Объявил пустые параметры которые далее полюбому будут заполнены.
    private string _productName;
    private int _price;
    private int _stock;
    // Снизу два конструктора. Логика принятия параметрох как и у методов. Хотел ещё
    // использовать прикол под названием new, но не вспомнил как это делается.
    public Product(string productName, int price, int stock)
    {
        _productName = productName;
        _price = price;
        _stock = stock;
    }
    public Product(string productName)
    {
        _productName = productName;
        _price = 0;
        _stock = 0;
    }
    // Короче, снизу методы класса, объяснять внутренности не буду, и так все просто и
    // понятно.Тем более в самом тз все подробно расписано, так что его можно считать одним большим комментарием.
    public int UpdatePrice(int newPrice)
    {
        _price = newPrice;
        return _price;
    }
    public void Restock(int quantity)
    {
        _stock += quantity;
    }
    public string GetProductInfo()
    {
        string info = $"Название продукта: {_productName}, цена: {_price}, количество: {_stock}";
        return info;
    }
    public void Sell(int quantity)
    {
        if (_stock >= quantity)
            _stock -= quantity;
        else
            Console.WriteLine("Да не, нету уже товаров");
    }
}
