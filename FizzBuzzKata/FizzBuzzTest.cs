using FluentAssertions;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
    [Fact(DisplayName = "Should return 1 to 1")]
    public void Should_return_1_to_1()
    {
        var fizzbuzz = new FizzBuzz();

        var result = fizzbuzz.Convert(1);

        result.Should().Be("1");
    }

    [Fact(DisplayName = "Should return Fizz to 3")]
    public void Should_return_Fizz_to_3()
    {
        var fizzbuzz = new FizzBuzz();

        var result = fizzbuzz.Convert(3);

        result.Should().Be("Fizz");
    }
}

public class FizzBuzz
{
    public string Convert(int number)
    {
        if (number == 3)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}