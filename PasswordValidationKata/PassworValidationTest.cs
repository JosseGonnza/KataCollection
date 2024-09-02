using FluentAssertions;
using FluentAssertions.Primitives;

namespace PasswordValidationKata;

public class PassworValidationTest
{
    [Fact(DisplayName = "Password is valid")]
    public void Should_be_valid_password()
    {
        var password = "ABCabc123___";

        Password.Validator(password).Should().BeTrue();
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
  
    private static AndConstraint<BooleanAssertions> ShouldBeFalse(string password)
    {
        return Password.Validator(password).Should().BeFalse();
    }
}