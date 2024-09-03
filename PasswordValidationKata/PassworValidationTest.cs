using FluentAssertions;
using FluentAssertions.Primitives;

namespace PasswordValidationKata;

public class PassworValidationTest
{
    [Fact(DisplayName = "Password is valid")]
    public void Should_be_valid_password()
    {
        Password.Validator("ABCabc123___").Should().BeTrue();
    }
    
    [Fact(DisplayName = "Password contain one uppercase char")]
    public void Should_contain_at_least_one_uppercase_character()
    {
        ShouldBeFalse("abc123___");
    }

    [Fact(DisplayName = "Password contain one lowercase char")]
    public void Should_contain_at_least_one_lowercase_character()
    {
        ShouldBeFalse("ABC123___");
    }

    [Fact(DisplayName = "Password contain one number")]
    public void Should_contain_at_least_one_number()
    {
        ShouldBeFalse("ABCabc___");
    }

    private static AndConstraint<BooleanAssertions> ShouldBeFalse(string password)
    {
        return Password.Validator(password).Should().BeFalse();
    }
}