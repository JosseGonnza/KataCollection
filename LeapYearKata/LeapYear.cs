namespace LeapYearKata;

public class LeapYear
{
        public bool IsLeapYear(int year)
        {
            return IsDivisible(year, 4) && !(IsDivisible(year, 100) && IsNotDivisible(year, 400));
        }

        private static bool IsNotDivisible(int year, int number)
        {
            return year % number != 0;
        }

        private static bool IsDivisible(int year, int number)
        {
            return year % number == 0;
        }
}