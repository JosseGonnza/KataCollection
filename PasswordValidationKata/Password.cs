using System.Text.RegularExpressions;

namespace PasswordValidationKata;

public class Password
{
    public static bool Validator(string password)
    {
        return ContainsAtLeastOneUppercaseChar(password) &&
               ContainsAtLeastOneLowercaseChar(password) && 
               ContainsAtLeastOneDigit(password) &&
               ContainsAtLeastOneUnderscore(password) &&
               ContainsAtLeast8Characters(password);
    }

    private static bool ContainsAtLeast8Characters(string password)
    {
        return password.Length >= 8;
    }

    private static bool ContainsAtLeastOneUnderscore(string password)
    {
        return Regex.IsMatch(password, ".*[_].*");
    }

    private static bool ContainsAtLeastOneDigit(string password)
    {
    return Regex.IsMatch(password, ".*\\d.*");
    }

    private static bool ContainsAtLeastOneLowercaseChar(string password)
    {
        return Regex.IsMatch(password, ".*[a-z].*");
    }

    private static bool ContainsAtLeastOneUppercaseChar(string password)
    {
        return Regex.IsMatch(password, ".*[A-Z].*");
    }
}