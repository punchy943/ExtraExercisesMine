namespace TheCourse.M03_CSharp101.Exercises.M03_Operators;

public class MoreOperators
{
    // 1. Easy: subtraction
    public int Subtract(int a, int b)
    {
        return a-b; // TODO
    }

    // 2. Easy: multiplication
    public int Multiply(int a, int b)
    {
        return a * b; // TODO
    }

    // 3. Easy: is the number odd?
    public bool IsOdd(int x)
    {
        return x%2 != 0; // TODO
    }

    // 4. Easy: is the number positive (strictly greater than zero)?
    public bool IsPositive(int x)
    {
        return x>0; // TODO
    }

    // 5. Easy: is the number zero?
    public bool IsZero(int x)
    {
        return x==0; // TODO
    }

    // 6. Medium: is the number divisible by both 3 and 5?
    public bool IsDivisibleByThreeAndFive(int x)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: is the value within the inclusive range [min, max]?
    public bool IsBetweenInclusive(int value, int min, int max)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: returns true if exactly one of the two booleans is true (XOR)
    public bool ExactlyOneIsTrue(bool left, bool right)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: returns the largest of two numbers
    public int Max(int a, int b)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: returns the smallest of two numbers
    public int Min(int a, int b)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Medium: returns "Pass" if score >= 50, otherwise "Fail"
    public string GetResult(int score)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Medium: doubles the value if it is even, otherwise leaves it unchanged
    public int DoubleIfEven(int x)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Medium: returns true if the year is a leap year
    // (divisible by 4, but not by 100, unless also divisible by 400)
    public bool IsLeapYear(int year)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the middle value of three numbers
    public int Median(int a, int b, int c)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns true if all three booleans are true
    public bool AllAreTrue(bool a, bool b, bool c)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: returns the price after applying a percentage discount
    // (e.g. ApplyPercentageDiscount(100, 25) returns 75)
    public decimal ApplyPercentageDiscount(decimal price, decimal percentage)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: returns true if the character is a vowel (a, e, i, o, u - case insensitive)
    public bool IsVowel(char c)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: returns the grade letter based on score
    // 90+: "A", 80-89: "B", 70-79: "C", 60-69: "D", below 60: "F"
    public string GetGrade(int score)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: returns true if the number is a power of two
    // (1, 2, 4, 8, 16, ... are powers of two)
    public bool IsPowerOfTwo(int x)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: returns the number of true values among the three booleans
    public int CountTrue(bool a, bool b, bool c)
    {
        throw new NotImplementedException(); // TODO
    }
}