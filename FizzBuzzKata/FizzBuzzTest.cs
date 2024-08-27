using FluentAssertions;

namespace FizzBuzzKata;

public class FizzBuzzTest
{
    private readonly FizzBuzz kata;

    public FizzBuzzTest()
    {
        kata = new FizzBuzz(); ;
    }

    [Fact(DisplayName = "Should return 1 to 1")]
    public void Should_return_1_to_1()
    {
        var result = kata.Convert(1);

        result.Should().Be("1");
    }

    [Fact(DisplayName = "Should return Fizz to 3")]
    public void Should_return_Fizz_to_3()
    {

        var result = kata.Convert(3);

        result.Should().Be("Fizz");
    }

    [Theory(DisplayName = "Should return Fizz to multiples of 3")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    [InlineData(12, "Fizz")]
    public void Should_return_Fizz_to_multiples_of_3(int number, string expected)
    {

        var result = kata.Convert(number);

        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Should return Buzz to multiples of 5")]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(20, "Buzz")]
    [InlineData(25, "Buzz")]
    public void Should_return_Buzz_to_multiples_of_5(int number, string expected)
    {

        var result = kata.Convert(number);

        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Should return FizzBuzz to multiples of 15")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(45, "FizzBuzz")]
    [InlineData(60, "FizzBuzz")]
    public void Should_return_FizzBuzz_to_multiples_of_15(int number, string expected)
    {

        var result = kata.Convert(number);

        result.Should().Be(expected);
    }
}
