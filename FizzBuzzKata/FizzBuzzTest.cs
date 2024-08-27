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
}

public class FizzBuzz
{
    public string Convert(int number)
    {
        return number.ToString();
    }
}