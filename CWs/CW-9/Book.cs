class Book
{
    private string? _title;
    private string? _author;
    public int YearPublished { get; }
    public int Pages { get; }

    public Book() { }

    public Book(string title, string author, int yearPublished, int pages)
    {
        _title = title;
        _author = author;
        if (yearPublished < 1800)
        {
            throw new ArgumentOutOfRangeException("Жарамсыз шыққан жыл");
        }
        else
        {
            YearPublished = yearPublished;
        }
        if (pages <= 0)
        {
            throw new ArgumentException("Бет саны оң мәнде болуы керек");
        }
        else
        {
            Pages = pages;
        }
    }

    public void GetBookInfo()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Year Published: {YearPublished}, Pages: {Pages}");
    }
}