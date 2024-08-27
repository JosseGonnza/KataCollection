using LeapYearKata;

public class Program
{
    private static void Main(string[] args)
    {
        // --> DESCOMENTAR PARA USAR

        /*var fizzbuzz = new FizzBuzzKata.FizzBuzz();
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzbuzz.Convert(i));
        }*/

        var leapYear = new LeapYear();
        for (int i = 1; i <= 2024; i++)
        {
            if (leapYear.IsLeapYear(i) == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}