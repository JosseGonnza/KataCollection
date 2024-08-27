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

    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            return true;
        }
    }
}