using FluentAssertions;

namespace LeapYearKata;

public class LeapYearTest
{
    [Fact(DisplayName = "Should return true when year is 4")]
    public void Should_return_true_when_year_is_4()
    {
        var leapYear = new LeapYear();

        var result = leapYear.IsLeapYear(4);

        result.Should().BeTrue();
    }

    [Theory(DisplayName = "Should return false when year is not multiple of 4")]
    [InlineData(3)]
    [InlineData(1611)]
    [InlineData(1995)]
    [InlineData(2023)]
    public void Should_return_false_when_year_is_not_multiple_of_4(int year)
    {
        var leapYear = new LeapYear();

        var result = leapYear.IsLeapYear(year);

        result.Should().BeFalse();
    }

    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }
            return true;
        }
    }
}