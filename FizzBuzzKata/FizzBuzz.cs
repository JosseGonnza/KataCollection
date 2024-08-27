namespace FizzBuzzKata;

public class FizzBuzz
{
    private const string FIZZ = "Fizz";
    private const string BUZZ = "Buzz";
    private const string FIZZBUZZ = "FizzBuzz";

    public string Convert(int number)
    {
        bool isMultipleOf3 = number % 3 == 0;
        bool isMultipleOf5 = number % 5 == 0;
        bool isMultipleOf15 = number % 15 == 0;

        if (isMultipleOf15)
        {
            return FIZZBUZZ;
        }
        else if (isMultipleOf3)
        {
            return FIZZ;
        }
        else if (isMultipleOf5)
        {
            return BUZZ;
        }
        return number.ToString();
    }
}