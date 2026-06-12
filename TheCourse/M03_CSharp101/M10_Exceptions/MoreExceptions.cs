namespace TheCourse.M03_CSharp101.Exercises.M10_Exceptions;

public class MoreExceptions
{
    // 1. Easy: returns the number, or 0 if the input is null
    public int GetLengthOrZero(string? input)
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: throws ArgumentNullException if name is null
    public void EnsureNotNull(string? name)
    {
        throw new NotImplementedException(); // TODO
    }

    // 3. Easy: returns the parsed double, or 0 if parsing fails
    public double ParseDouble(string input)
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Easy: throws ArgumentException with message "Age cannot be negative." when age < 0
    public void EnsureValidAge(int age)
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Medium: divides a by b, returns 0 if b is zero (instead of throwing)
    public int SafeDivide(int a, int b)
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: throws ArgumentOutOfRangeException with message "Index is out of range."
    // when index is negative or >= length
    public void EnsureValidIndex(int index, int length)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns the item at the given index, or "" if the index is out of range
    public string GetItemOrDefault(List<string> items, int index)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: throws InvalidOperationException with message "List is empty." when the list is empty,
    // otherwise returns the first item
    public string GetFirstOrThrow(List<string> items)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: tries to parse the input as int; returns true and sets result via out parameter when successful,
    // returns false and sets result to 0 when it fails
    public bool TryParseNumber(string input, out int result)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: wraps a FormatException thrown by double.Parse into an InvalidOperationException
    // with message "Invalid decimal value." and the original exception as InnerException
    public double ParseDecimalStrict(string input)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Medium: throws DivideByZeroException with message "Cannot divide by zero."
    // when divisor is zero, otherwise returns the division result
    public double DivideOrThrow(double numerator, double divisor)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Hard: returns the value for the given key, or throws KeyNotFoundException
    // with message "Key 'X' was not found." (replace X with the actual key)
    public int GetValueOrThrow(Dictionary<string, int> data, string key)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Hard: runs the given action; if it throws any exception, returns false, otherwise returns true
    public bool TryRun(Action action)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: validates that the email contains an "@" symbol,
    // throws ArgumentException with message "Invalid email address." if not
    public void EnsureValidEmail(string email)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: processes the numbers array; for each element that throws when divided
    // (i.e. when dividing 100 by that element causes DivideByZeroException),
    // skips it instead of crashing, and returns the list of successful results
    public List<int> SafeDivideAll(int[] numbers)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: validates a password; throws ArgumentException with message
    // "Password must be at least 8 characters." if too short,
    // or "Password must contain at least one digit." if it has no digits
    public void EnsureValidPassword(string password)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: opens and "uses" a resource represented by a flag; ensures cleanup happens
    // even if an exception occurs, by setting wasClosed to true via out parameter,
    // and rethrows the original exception
    public void UseResourceAndEnsureCleanup(Action action, out bool wasClosed)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: retries the given function up to maxAttempts times if it throws an exception;
    // returns the result on success, or rethrows the last exception if all attempts fail
    public int RetryOnFailure(Func<int> action, int maxAttempts)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: validates a custom exception hierarchy - throws a custom NegativeBalanceException
    // (derived from Exception) with message "Balance cannot be negative." when balance < 0
    public void EnsureValidBalance(decimal balance)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: catches multiple specific exception types (FormatException and OverflowException)
    // when parsing, and returns a different message for each:
    // "Format error" for FormatException, "Overflow error" for OverflowException, "" otherwise
    public string ParseWithDetailedError(string input)
    {
        throw new NotImplementedException(); // TODO
    }
}

public class NegativeBalanceException : Exception
{
    public NegativeBalanceException(string message) : base(message) { }
}