using System.Text.RegularExpressions;

namespace PasswordValidationKata;

public class Password
{
    public static bool Validator(string password)
    {
        if (Regex.IsMatch(password, ".*[A-Z].*") 
            && Regex.IsMatch(password, ".*[a-z].*")
            && Regex.IsMatch(password, ".*\\d.*")
            && Regex.IsMatch(password, ".*[_].*"))
        {
            return true;
        }
        return false;
    }
}