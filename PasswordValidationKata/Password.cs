using System.Text.RegularExpressions;

namespace PasswordValidationKata;

public class Password
{
    public static bool Validator(string password)
    {
        if (Regex.IsMatch(password, "^[A-Z]*$"))
        {
            return true;
        }
        return false;
    }
}