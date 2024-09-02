using FluentAssertions;

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
        var password = "abc123___";

        Password.Validator(password).Should().BeFalse();
    }
}