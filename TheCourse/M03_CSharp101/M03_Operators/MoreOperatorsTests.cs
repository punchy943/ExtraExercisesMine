namespace TheCourse.M03_CSharp101.Exercises.M03_Operators;

public class MoreOperatorsTests
{
    [Theory]
    [InlineData(8, 3, 5)]
    [InlineData(3, 8, -5)]
    [InlineData(5, 5, 0)]
    public void Subtract_returns_the_difference_of_two_numbers(int a, int b, int expected)
    {
        Assert.Equal(expected, new MoreOperators().Subtract(a, b));
    }

    [Theory]
    [InlineData(4, 3, 12)]
    [InlineData(0, 5, 0)]
    [InlineData(-2, 3, -6)]
    public void Multiply_returns_the_product_of_two_numbers(int a, int b, int expected)
    {
        Assert.Equal(expected, new MoreOperators().Multiply(a, b));
    }

    [Theory]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(0, false)]
    [InlineData(-3, true)]
    public void IsOdd_recognizes_odd_numbers(int x, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsOdd(x));
    }

    [Theory]
    [InlineData(5, true)]
    [InlineData(0, false)]
    [InlineData(-5, false)]
    public void IsPositive_recognizes_strictly_positive_numbers(int x, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsPositive(x));
    }

    [Theory]
    [InlineData(0, true)]
    [InlineData(1, false)]
    [InlineData(-1, false)]
    public void IsZero_recognizes_zero(int x, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsZero(x));
    }

    [Theory]
    [InlineData(15, true)]
    [InlineData(30, true)]
    [InlineData(9, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    public void IsDivisibleByThreeAndFive_checks_both_conditions(int x, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsDivisibleByThreeAndFive(x));
    }

    [Theory]
    [InlineData(5, 1, 10, true)]
    [InlineData(1, 1, 10, true)]
    [InlineData(10, 1, 10, true)]
    [InlineData(0, 1, 10, false)]
    [InlineData(11, 1, 10, false)]
    public void IsBetweenInclusive_checks_inclusive_range(int value, int min, int max, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsBetweenInclusive(value, min, max));
    }

    [Theory]
    [InlineData(true, false, true)]
    [InlineData(false, true, true)]
    [InlineData(true, true, false)]
    [InlineData(false, false, false)]
    public void ExactlyOneIsTrue_implements_xor(bool left, bool right, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().ExactlyOneIsTrue(left, right));
    }

    [Theory]
    [InlineData(5, 10, 10)]
    [InlineData(10, 5, 10)]
    [InlineData(7, 7, 7)]
    [InlineData(-3, -8, -3)]
    public void Max_returns_the_largest_of_two_numbers(int a, int b, int expected)
    {
        Assert.Equal(expected, new MoreOperators().Max(a, b));
    }

    [Theory]
    [InlineData(5, 10, 5)]
    [InlineData(10, 5, 5)]
    [InlineData(7, 7, 7)]
    [InlineData(-3, -8, -8)]
    public void Min_returns_the_smallest_of_two_numbers(int a, int b, int expected)
    {
        Assert.Equal(expected, new MoreOperators().Min(a, b));
    }

    [Theory(Skip = "To Do")]
    [InlineData(75, "Pass")]
    [InlineData(50, "Pass")]
    [InlineData(49, "Fail")]
    [InlineData(0, "Fail")]
    public void GetResult_returns_pass_or_fail_based_on_score(int score, string expected)
    {
        Assert.Equal(expected, new MoreOperators().GetResult(score));
    }

    [Theory(Skip = "To Do")]
    [InlineData(4, 8)]
    [InlineData(5, 5)]
    [InlineData(0, 0)]
    [InlineData(-2, -4)]
    public void DoubleIfEven_doubles_even_numbers_only(int input, int expected)
    {
        Assert.Equal(expected, new MoreOperators().DoubleIfEven(input));
    }

    [Theory(Skip = "To Do")]
    [InlineData(2024, true)]
    [InlineData(2023, false)]
    [InlineData(2000, true)]
    [InlineData(1900, false)]
    [InlineData(2100, false)]
    public void IsLeapYear_recognizes_leap_years(int year, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsLeapYear(year));
    }

    [Theory(Skip = "To Do")]
    [InlineData(1, 2, 3, 2)]
    [InlineData(3, 1, 2, 2)]
    [InlineData(5, 5, 1, 5)]
    [InlineData(-1, -5, 0, -1)]
    public void Median_returns_the_middle_value(int a, int b, int c, int expected)
    {
        Assert.Equal(expected, new MoreOperators().Median(a, b, c));
    }

    [Theory(Skip = "To Do")]
    [InlineData(true, true, true, true)]
    [InlineData(true, true, false, false)]
    [InlineData(false, false, false, false)]
    public void AllAreTrue_returns_true_only_when_all_three_are_true(bool a, bool b, bool c, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().AllAreTrue(a, b, c));
    }

    [Theory(Skip = "To Do")]
    [InlineData(100, 25, 75)]
    [InlineData(200, 50, 100)]
    [InlineData(100, 0, 100)]
    public void ApplyPercentageDiscount_subtracts_the_correct_percentage(decimal price, decimal percentage, decimal expected)
    {
        Assert.Equal(expected, new MoreOperators().ApplyPercentageDiscount(price, percentage));
    }

    [Theory(Skip = "To Do")]
    [InlineData('a', true)]
    [InlineData('E', true)]
    [InlineData('b', false)]
    [InlineData('Z', false)]
    public void IsVowel_recognizes_vowels_case_insensitively(char input, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsVowel(input));
    }

    [Theory(Skip = "To Do")]
    [InlineData(95, "A")]
    [InlineData(85, "B")]
    [InlineData(75, "C")]
    [InlineData(65, "D")]
    [InlineData(50, "F")]
    [InlineData(90, "A")]
    [InlineData(60, "D")]
    public void GetGrade_returns_the_correct_letter_grade(int score, string expected)
    {
        Assert.Equal(expected, new MoreOperators().GetGrade(score));
    }

    [Theory(Skip = "To Do")]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(16, true)]
    [InlineData(18, false)]
    [InlineData(0, false)]
    public void IsPowerOfTwo_recognizes_powers_of_two(int input, bool expected)
    {
        Assert.Equal(expected, new MoreOperators().IsPowerOfTwo(input));
    }

    [Theory(Skip = "To Do")]
    [InlineData(true, true, true, 3)]
    [InlineData(true, false, true, 2)]
    [InlineData(false, false, false, 0)]
    [InlineData(true, false, false, 1)]
    public void CountTrue_counts_the_number_of_true_values(bool a, bool b, bool c, int expected)
    {
        Assert.Equal(expected, new MoreOperators().CountTrue(a, b, c));
    }
}