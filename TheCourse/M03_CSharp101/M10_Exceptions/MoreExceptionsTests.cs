namespace TheCourse.M03_CSharp101.Exercises.M10_Exceptions;

public class MoreExceptionsTests
{
    [Theory(Skip = "To Do")]
    [InlineData("hello", 5)]
    [InlineData(null, 0)]
    public void GetLengthOrZero_returns_length_or_zero_for_null(string? input, int expected)
    {
        var sut = new MoreExceptions();
        var result = sut.GetLengthOrZero(input);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void EnsureNotNull_throws_when_name_is_null()
    {
        var sut = new MoreExceptions();
        Assert.Throws<ArgumentNullException>(() => sut.EnsureNotNull(null));
    }

    [Fact(Skip = "To Do")]
    public void EnsureNotNull_does_nothing_when_name_is_not_null()
    {
        var sut = new MoreExceptions();
        sut.EnsureNotNull("Alice");
    }

    [Theory(Skip = "To Do")]
    [InlineData("3.14", 3.14)]
    [InlineData("not a number", 0)]
    public void ParseDouble_returns_value_or_zero(string input, double expected)
    {
        var sut = new MoreExceptions();
        var result = sut.ParseDouble(input);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidAge_throws_when_age_is_negative()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<ArgumentException>(() => sut.EnsureValidAge(-1));
        Assert.Equal("Age cannot be negative.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidAge_does_nothing_when_age_is_valid()
    {
        var sut = new MoreExceptions();
        sut.EnsureValidAge(25);
    }

    [Theory(Skip = "To Do")]
    [InlineData(10, 2, 5)]
    [InlineData(10, 0, 0)]
    public void SafeDivide_returns_result_or_zero_when_divisor_is_zero(int a, int b, int expected)
    {
        var sut = new MoreExceptions();
        var result = sut.SafeDivide(a, b);
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(-1, 5)]
    [InlineData(5, 5)]
    public void EnsureValidIndex_throws_when_index_out_of_range(int index, int length)
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<ArgumentOutOfRangeException>(() => sut.EnsureValidIndex(index, length));
        Assert.Equal("Index is out of range.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidIndex_does_nothing_when_index_is_valid()
    {
        var sut = new MoreExceptions();
        sut.EnsureValidIndex(2, 5);
    }

    [Theory(Skip = "To Do")]
    [InlineData(1, "Bob")]
    [InlineData(5, "")]
    public void GetItemOrDefault_returns_item_or_empty_string(int index, string expected)
    {
        var sut = new MoreExceptions();
        var result = sut.GetItemOrDefault(new List<string> { "Alice", "Bob", "Charlie" }, index);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstOrThrow_returns_first_item_when_list_is_not_empty()
    {
        var sut = new MoreExceptions();
        var result = sut.GetFirstOrThrow(new List<string> { "Alice", "Bob" });
        Assert.Equal("Alice", result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstOrThrow_throws_when_list_is_empty()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<InvalidOperationException>(() => sut.GetFirstOrThrow(new List<string>()));
        Assert.Equal("List is empty.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void TryParseNumber_returns_true_and_correct_value_when_valid()
    {
        var sut = new MoreExceptions();
        var success = sut.TryParseNumber("42", out var result);
        Assert.True(success);
        Assert.Equal(42, result);
    }

    [Fact(Skip = "To Do")]
    public void TryParseNumber_returns_false_and_zero_when_invalid()
    {
        var sut = new MoreExceptions();
        var success = sut.TryParseNumber("abc", out var result);
        Assert.False(success);
        Assert.Equal(0, result);
    }

    [Fact(Skip = "To Do")]
    public void ParseDecimalStrict_wraps_format_exception()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<InvalidOperationException>(() => sut.ParseDecimalStrict("abc"));
        Assert.Equal("Invalid decimal value.", ex.Message);
        Assert.NotNull(ex.InnerException);
        Assert.IsType<FormatException>(ex.InnerException);
    }

    [Fact(Skip = "To Do")]
    public void DivideOrThrow_throws_divide_by_zero_exception()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<DivideByZeroException>(() => sut.DivideOrThrow(10, 0));
        Assert.Equal("Cannot divide by zero.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void DivideOrThrow_returns_result_when_divisor_is_not_zero()
    {
        var sut = new MoreExceptions();
        var result = sut.DivideOrThrow(10, 2);
        Assert.Equal(5, result);
    }

    [Fact(Skip = "To Do")]
    public void GetValueOrThrow_returns_value_when_key_exists()
    {
        var sut = new MoreExceptions();
        var data = new Dictionary<string, int> { ["Alice"] = 30 };
        var result = sut.GetValueOrThrow(data, "Alice");
        Assert.Equal(30, result);
    }

    [Fact(Skip = "To Do")]
    public void GetValueOrThrow_throws_key_not_found_exception_with_correct_message()
    {
        var sut = new MoreExceptions();
        var data = new Dictionary<string, int> { ["Alice"] = 30 };
        var ex = Assert.Throws<KeyNotFoundException>(() => sut.GetValueOrThrow(data, "Bob"));
        Assert.Equal("Key 'Bob' was not found.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void TryRun_returns_true_when_action_succeeds()
    {
        var sut = new MoreExceptions();
        var result = sut.TryRun(() => { });
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void TryRun_returns_false_when_action_throws()
    {
        var sut = new MoreExceptions();
        var result = sut.TryRun(() => throw new Exception("Boom"));
        Assert.False(result);
    }

    [Theory(Skip = "To Do")]
    [InlineData("alice@example.com")]
    public void EnsureValidEmail_does_nothing_when_email_is_valid(string email)
    {
        var sut = new MoreExceptions();
        sut.EnsureValidEmail(email);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidEmail_throws_when_email_is_invalid()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<ArgumentException>(() => sut.EnsureValidEmail("alice.example.com"));
        Assert.Equal("Invalid email address.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void SafeDivideAll_skips_elements_that_cause_divide_by_zero()
    {
        var sut = new MoreExceptions();
        var result = sut.SafeDivideAll(new[] { 5, 0, 2, 0, 10 });
        Assert.Equal(new List<int> { 20, 50, 10 }, result);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidPassword_throws_when_too_short()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<ArgumentException>(() => sut.EnsureValidPassword("ab1"));
        Assert.Equal("Password must be at least 8 characters.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidPassword_throws_when_no_digit()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<ArgumentException>(() => sut.EnsureValidPassword("abcdefgh"));
        Assert.Equal("Password must contain at least one digit.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidPassword_does_nothing_when_valid()
    {
        var sut = new MoreExceptions();
        sut.EnsureValidPassword("abcdefg1");
    }

    [Fact(Skip = "To Do")]
    public void UseResourceAndEnsureCleanup_sets_wasClosed_true_even_when_exception_is_thrown()
    {
        var sut = new MoreExceptions();
        Assert.Throws<Exception>(() => sut.UseResourceAndEnsureCleanup(() => throw new Exception("Boom"), out var wasClosed));
    }

    [Fact(Skip = "To Do")]
    public void UseResourceAndEnsureCleanup_sets_wasClosed_true_when_no_exception()
    {
        var sut = new MoreExceptions();
        sut.UseResourceAndEnsureCleanup(() => { }, out var wasClosed);
        Assert.True(wasClosed);
    }

    [Fact(Skip = "To Do")]
    public void RetryOnFailure_returns_result_on_success()
    {
        var sut = new MoreExceptions();
        var result = sut.RetryOnFailure(() => 42, 3);
        Assert.Equal(42, result);
    }

    [Fact(Skip = "To Do")]
    public void RetryOnFailure_retries_until_success()
    {
        var sut = new MoreExceptions();
        var attempts = 0;
        var result = sut.RetryOnFailure(() =>
        {
            attempts++;
            if (attempts < 3) throw new Exception("Fail");
            return 99;
        }, 5);
        Assert.Equal(99, result);
        Assert.Equal(3, attempts);
    }

    [Fact(Skip = "To Do")]
    public void RetryOnFailure_throws_after_max_attempts()
    {
        var sut = new MoreExceptions();
        Assert.Throws<Exception>(() => sut.RetryOnFailure(() => throw new Exception("Always fails"), 3));
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidBalance_throws_negative_balance_exception()
    {
        var sut = new MoreExceptions();
        var ex = Assert.Throws<NegativeBalanceException>(() => sut.EnsureValidBalance(-10));
        Assert.Equal("Balance cannot be negative.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureValidBalance_does_nothing_when_balance_is_valid()
    {
        var sut = new MoreExceptions();
        sut.EnsureValidBalance(100);
    }

    [Theory(Skip = "To Do")]
    [InlineData("abc", "Format error")]
    [InlineData("99999999999999999999", "Overflow error")]
    [InlineData("42", "")]
    public void ParseWithDetailedError_returns_correct_error_message(string input, string expected)
    {
        var sut = new MoreExceptions();
        var result = sut.ParseWithDetailedError(input);
        Assert.Equal(expected, result);
    }
}