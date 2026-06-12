namespace TheCourse.M03_CSharp101.Exercises.M14_Nullables;

public class User
{
    public string? Name { get; set; }
    public Address? Address { get; set; }
    public int? Score { get; set; }
}

public class MoreNullables
{
    // 1. Easy: returns the age, or 0 if age is null
    public int GetAgeOrZero(int? age)
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: returns true if the value has no value (is null)
    public bool IsMissing(int? value)
    {
        throw new NotImplementedException(); // TODO
    }

    // 3. Easy: returns the email, or "no-email@example.com" if null
    public string GetEmailOrDefault(string? email)
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Medium: returns the length of the user's name, or 0 if the user or the name is null
    public int GetNameLength(User? user)
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Medium: returns the city of the user's address, or "Unknown" if the user, address, or city is null
    public string GetCity(User? user)
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: returns the discount amount, or 0 if discount is null;
    // throws ArgumentException with message "Discount cannot be negative." if discount has a value below zero
    public decimal GetValidDiscount(decimal? discount)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns the sum of all non-null values in the array
    public int SumNonNullValues(int?[] values)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: returns the first non-null name from the list, or "Anonymous" if all are null
    public string GetFirstAvailableName(List<string?> names)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Hard: copies the score to the user only if the user is not null and the score has a value;
    // returns true if the score was set, false otherwise
    public bool TrySetScore(User? user, int? score)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Hard: returns the average of the non-null values in the array,
    // or null if the array contains no non-null values
    public double? AverageOfNonNullValues(int?[] values)
    {
        throw new NotImplementedException(); // TODO
    }
}