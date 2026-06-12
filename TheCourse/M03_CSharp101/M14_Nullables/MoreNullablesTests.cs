namespace TheCourse.M03_CSharp101.Exercises.M14_Nullables;

public class MoreNullablesTests
{
    [Theory(Skip = "To Do")]
    [InlineData(25, 25)]
    [InlineData(null, 0)]
    public void GetAgeOrZero_returns_age_or_zero(int? age, int expected)
    {
        var sut = new MoreNullables();
        var result = sut.GetAgeOrZero(age);
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(null, true)]
    [InlineData(5, false)]
    public void IsMissing_returns_correct_result(int? value, bool expected)
    {
        var sut = new MoreNullables();
        var result = sut.IsMissing(value);
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData("mark@example.com", "mark@example.com")]
    [InlineData(null, "no-email@example.com")]
    public void GetEmailOrDefault_returns_email_or_default(string? email, string expected)
    {
        var sut = new MoreNullables();
        var result = sut.GetEmailOrDefault(email);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetNameLength_returns_length_when_name_is_present()
    {
        var sut = new MoreNullables();
        var result = sut.GetNameLength(new User { Name = "Mark" });
        Assert.Equal(4, result);
    }

    [Fact(Skip = "To Do")]
    public void GetNameLength_returns_zero_when_name_is_null()
    {
        var sut = new MoreNullables();
        var result = sut.GetNameLength(new User { Name = null });
        Assert.Equal(0, result);
    }

    [Fact(Skip = "To Do")]
    public void GetNameLength_returns_zero_when_user_is_null()
    {
        var sut = new MoreNullables();
        var result = sut.GetNameLength(null);
        Assert.Equal(0, result);
    }

    [Fact(Skip = "To Do")]
    public void GetCity_returns_city_when_present()
    {
        var sut = new MoreNullables();
        var user = new User { Name = "Mark", Address = new Address { City = "Brussels" } };
        var result = sut.GetCity(user);
        Assert.Equal("Brussels", result);
    }

    [Fact(Skip = "To Do")]
    public void GetCity_returns_unknown_when_address_is_null()
    {
        var sut = new MoreNullables();
        var user = new User { Name = "Mark", Address = null };
        var result = sut.GetCity(user);
        Assert.Equal("Unknown", result);
    }

    [Fact(Skip = "To Do")]
    public void GetCity_returns_unknown_when_user_is_null()
    {
        var sut = new MoreNullables();
        var result = sut.GetCity(null);
        Assert.Equal("Unknown", result);
    }

    [Fact(Skip = "To Do")]
    public void GetCity_returns_unknown_when_city_is_null()
    {
        var sut = new MoreNullables();
        var user = new User { Name = "Mark", Address = new Address { City = null } };
        var result = sut.GetCity(user);
        Assert.Equal("Unknown", result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(10.0, 10.0)]
    [InlineData(null, 0.0)]
    public void GetValidDiscount_returns_discount_or_zero(decimal? discount, decimal expected)
    {
        var sut = new MoreNullables();
        var result = sut.GetValidDiscount(discount);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetValidDiscount_throws_when_discount_is_negative()
    {
        var sut = new MoreNullables();
        var ex = Assert.Throws<ArgumentException>(() => sut.GetValidDiscount(-5));
        Assert.Equal("Discount cannot be negative.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void SumNonNullValues_sums_only_non_null_values()
    {
        var sut = new MoreNullables();
        var result = sut.SumNonNullValues(new int?[] { 1, null, 3, null, 5 });
        Assert.Equal(9, result);
    }

    [Fact(Skip = "To Do")]
    public void SumNonNullValues_returns_zero_when_all_values_are_null()
    {
        var sut = new MoreNullables();
        var result = sut.SumNonNullValues(new int?[] { null, null });
        Assert.Equal(0, result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstAvailableName_returns_first_non_null_name()
    {
        var sut = new MoreNullables();
        var result = sut.GetFirstAvailableName(new List<string?> { null, null, "Mark", "Anna" });
        Assert.Equal("Mark", result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstAvailableName_returns_anonymous_when_all_are_null()
    {
        var sut = new MoreNullables();
        var result = sut.GetFirstAvailableName(new List<string?> { null, null });
        Assert.Equal("Anonymous", result);
    }

    [Fact(Skip = "To Do")]
    public void TrySetScore_sets_score_and_returns_true_when_both_are_present()
    {
        var sut = new MoreNullables();
        var user = new User { Name = "Mark" };
        var result = sut.TrySetScore(user, 95);
        Assert.True(result);
        Assert.Equal(95, user.Score);
    }

    [Fact(Skip = "To Do")]
    public void TrySetScore_returns_false_when_user_is_null()
    {
        var sut = new MoreNullables();
        var result = sut.TrySetScore(null, 95);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void TrySetScore_returns_false_when_score_is_null()
    {
        var sut = new MoreNullables();
        var user = new User { Name = "Mark" };
        var result = sut.TrySetScore(user, null);
        Assert.False(result);
        Assert.Null(user.Score);
    }

    [Fact(Skip = "To Do")]
    public void AverageOfNonNullValues_returns_average_of_non_null_values()
    {
        var sut = new MoreNullables();
        var result = sut.AverageOfNonNullValues(new int?[] { 2, null, 4, 6 });
        Assert.Equal(4.0, result);
    }

    [Fact(Skip = "To Do")]
    public void AverageOfNonNullValues_returns_null_when_all_values_are_null()
    {
        var sut = new MoreNullables();
        var result = sut.AverageOfNonNullValues(new int?[] { null, null });
        Assert.Null(result);
    }
}

public class Address
{
    public string? City { get; set; }
}