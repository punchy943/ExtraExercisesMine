namespace TheCourse.M03_CSharp101.Exercises.M04_Conditions;

public class MoreConditionsTests
{
    [Theory]
    [InlineData(-5, true)]
    [InlineData(0, false)]
    [InlineData(5, false)]
    public void IsNegative_returns_true_only_for_negative_numbers(int number, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().IsNegative(number));
    }

    [Theory]
    [InlineData(65, "Yes")]
    [InlineData(70, "Yes")]
    [InlineData(64, "No")]
    [InlineData(18, "No")]
    public void IsSenior_returns_yes_for_ages_65_and_above(int age, string expected)
    {
        Assert.Equal(expected, new MoreConditions().IsSenior(age));
    }

    [Theory]
    [InlineData("password", true)]
    [InlineData("12345678", true)]
    [InlineData("short", false)]
    [InlineData("", false)]
    public void IsPasswordLongEnough_checks_minimum_length_of_8(string password, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().IsPasswordLongEnough(password));
    }

    [Theory]
    [InlineData("zaterdag", "weekend")]
    [InlineData("zondag", "weekend")]
    [InlineData("maandag", "weekdag")]
    [InlineData("vrijdag", "weekdag")]
    public void GetDayType_returns_weekend_or_weekdag(string day, string expected)
    {
        Assert.Equal(expected, new MoreConditions().GetDayType(day));
    }

    [Theory]
    [InlineData(20, true, true)]
    [InlineData(17, true, false)]
    [InlineData(20, false, false)]
    [InlineData(16, false, false)]
    public void MayDrive_requires_correct_age_and_license(int age, bool hasLicense, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().MayDrive(age, hasLicense));
    }

    [Theory]
    [InlineData(10, 5)]
    [InlineData(11, 5)]
    [InlineData(12, 10)]
    [InlineData(40, 10)]
    [InlineData(64, 10)]
    [InlineData(65, 7)]
    [InlineData(80, 7)]
    public void TicketPrice_returns_expected_price_per_age_group(int age, int expected)
    {
        Assert.Equal(expected, new MoreConditions().TicketPrice(age));
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(100, true)]
    [InlineData(50, true)]
    [InlineData(0, false)]
    [InlineData(101, false)]
    [InlineData(-5, false)]
    public void IsValidPercentage_checks_range_1_to_100(int value, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().IsValidPercentage(value));
    }

    [Theory]
    [InlineData(17.0, "Ondergewicht")]
    [InlineData(18.5, "Normaal")]
    [InlineData(22.0, "Normaal")]
    [InlineData(24.9, "Normaal")]
    [InlineData(25.0, "Overgewicht")]
    [InlineData(29.9, "Overgewicht")]
    [InlineData(30.0, "Obesitas")]
    [InlineData(35.0, "Obesitas")]
    public void BmiCategory_returns_correct_category(double bmi, string expected)
    {
        Assert.Equal(expected, new MoreConditions().BmiCategory(bmi));
    }

    [Theory]
    [InlineData("admin", "1234", true)]
    [InlineData("admin", "wrong", false)]
    [InlineData("user", "1234", false)]
    [InlineData("user", "wrong", false)]
    public void IsLoginSuccessful_checks_username_and_password(string username, string password, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().IsLoginSuccessful(username, password));
    }

    [Theory]
    [InlineData(12, "Winter")]
    [InlineData(1, "Winter")]
    [InlineData(2, "Winter")]
    [InlineData(3, "Lente")]
    [InlineData(5, "Lente")]
    [InlineData(6, "Zomer")]
    [InlineData(8, "Zomer")]
    [InlineData(9, "Herfst")]
    [InlineData(11, "Herfst")]
    public void GetSeason_returns_correct_season_for_month(int month, string expected)
    {
        Assert.Equal(expected, new MoreConditions().GetSeason(month));
    }

    [Theory]
    [InlineData(20, true, 20)]
    [InlineData(30, true, 35)]
    [InlineData(70, true, 35)]
    [InlineData(65, false, 25)]
    [InlineData(70, false, 25)]
    [InlineData(40, false, 50)]
    public void MembershipFee_combines_age_and_student_status(int age, bool isStudent, int expected)
    {
        Assert.Equal(expected, new MoreConditions().MembershipFee(age, isStudent));
    }

    [Theory(Skip = "To Do")]
    [InlineData(3, 4, 5, true)]
    [InlineData(1, 1, 1, true)]
    [InlineData(1, 1, 3, false)]
    [InlineData(0, 4, 5, false)]
    [InlineData(-1, 4, 5, false)]
    public void IsValidTriangle_checks_triangle_inequality_and_positive_sides(int sideA, int sideB, int sideC, bool expected)
    {
        Assert.Equal(expected, new MoreConditions().IsValidTriangle(sideA, sideB, sideC));
    }

    [Theory(Skip = "To Do")]
    [InlineData(0.5, 0)]
    [InlineData(1, 0)]
    [InlineData(2, 2)]
    [InlineData(3, 4)]
    [InlineData(4, 7)]
    [InlineData(5, 8)]
    public void ParkingFee_calculates_fee_based_on_hours(decimal hours, decimal expected)
    {
        Assert.Equal(expected, new MoreConditions().ParkingFee(hours));
    }

    [Theory(Skip = "To Do")]
    [InlineData("abc", false, "Zwak")]
    [InlineData("abcdef", false, "Gemiddeld")]
    [InlineData("abcdef", true, "Sterk")]
    [InlineData("abcdefghij", false, "Sterk")]
    [InlineData("abcdefghij", true, "Zeer sterk")]
    public void PasswordStrength_combines_length_and_digit_presence(string password, bool containsDigit, string expected)
    {
        Assert.Equal(expected, new MoreConditions().PasswordStrength(password, containsDigit));
    }

    [Theory(Skip = "To Do")]
    [InlineData(true, true, "Fragiel - Internationaal")]
    [InlineData(true, false, "Fragiel")]
    [InlineData(false, true, "Internationaal")]
    [InlineData(false, false, "Standaard")]
    public void GetShippingLabel_combines_fragile_and_international_flags(bool isFragile, bool isInternational, string expected)
    {
        Assert.Equal(expected, new MoreConditions().GetShippingLabel(isFragile, isInternational));
    }
}