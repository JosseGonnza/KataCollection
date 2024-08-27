public class Program
{
    private static void Main(string[] args)
    {
        var fizzbuzz = new FizzBuzzKata.FizzBuzz();
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzbuzz.Convert(i));
        }
    }
}