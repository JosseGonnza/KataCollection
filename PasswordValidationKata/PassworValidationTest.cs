using FluentAssertions;

namespace PasswordValidationKata;

public class PassworValidationTest
{
    [Fact(DisplayName = "Password is valid")]
    public void Should_be_valid_password()
    {
        var password = "ABCabc123___";

        var result = Password.Validator(password);
        
        result.Should().BeTrue();
    }
}