using System;
namespace Program;
class Program
{
    static void Main(string[] args)
    {
        Book crimeAndPunishment = new Book();

        try
        {
            crimeAndPunishment = new Book("Crime and Punishment", "Fyodor Dostoevsky", 1866, 671);

        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("КатеееееееееееееееееееееееееError: " + e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        finally
        {
            crimeAndPunishment.GetBookInfo();
        }
    }
}
