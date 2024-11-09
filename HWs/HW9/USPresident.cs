using System.Security.Cryptography.X509Certificates;

namespace Program;
class USPresident
{
    private string _name;
    private int _term;

    public USPresident(string _name, int _term)
    {
        this._name = _name;
        SetTerm(_term);
    }

    /* SetTerm(int years) – метод для установки срока президентства. Если значение срока 
    больше 8 лет (максимум для двух сроков), выбросьте исключение InvalidOperationException 
    с сообщением «Срок превышает допустимое количество лет для президентства». */
    public void SetTerm(int years)
    {
        if (years > 8)
        {
            throw new InvalidOperationException("Срок превышает допустимое количество лет для президентства");
        }
        else
        {
            this._term = years;
        }
    }

    // MakeDecision(string decision) – метод, возвращающий строку с сообщением о принятом решении.
    // Ну, возвращаю.
    public string MakeDecision(string decision)
    {
        Console.WriteLine("Было принято новое политическое решение!");
        return decision;
    }
}