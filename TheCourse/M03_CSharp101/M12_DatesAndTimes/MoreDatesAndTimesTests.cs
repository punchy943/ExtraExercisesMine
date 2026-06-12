namespace TheCourse.M03_CSharp101.Exercises.M12_DatesAndTimes;

public class MoreDatesAndTimesTests
{
    [Theory(Skip = "To Do")]
    [InlineData(2024, true)]
    [InlineData(2023, false)]
    [InlineData(2000, true)]
    [InlineData(1900, false)]
    public void IsLeapYear_returns_correct_result(int year, bool expected)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.IsLeapYear(new DateOnly(year, 1, 1));
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetDayName_returns_correct_day_name()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetDayName(new DateOnly(2026, 4, 6)); // Monday
        Assert.Equal("Monday", result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(2026, 4, 4, true)]  // Saturday
    [InlineData(2026, 4, 5, true)]  // Sunday
    [InlineData(2026, 4, 6, false)] // Monday
    public void IsWeekend_returns_correct_result(int year, int month, int day, bool expected)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.IsWeekend(new DateOnly(year, month, day));
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void AddDays_returns_date_shifted_by_given_days()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.AddDays(new DateOnly(2026, 4, 4), 10);
        Assert.Equal(new DateOnly(2026, 4, 14), result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(1990, 4, 1, 2026, 4, 4, 36)]
    [InlineData(1990, 4, 10, 2026, 4, 4, 35)]
    public void GetAge_returns_correct_age(int by, int bm, int bd, int ty, int tm, int td, int expected)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetAge(new DateOnly(by, bm, bd), new DateOnly(ty, tm, td));
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void GetFirstDayOfMonth_returns_first_day()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetFirstDayOfMonth(new DateOnly(2026, 4, 17));
        Assert.Equal(new DateOnly(2026, 4, 1), result);
    }

    [Fact(Skip = "To Do")]
    public void GetLastDayOfMonth_returns_last_day()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetLastDayOfMonth(new DateOnly(2026, 4, 5));
        Assert.Equal(new DateOnly(2026, 4, 30), result);
    }

    [Fact(Skip = "To Do")]
    public void GetLastDayOfMonth_handles_february_in_leap_year()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetLastDayOfMonth(new DateOnly(2024, 2, 1));
        Assert.Equal(new DateOnly(2024, 2, 29), result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(9, 0, true)]
    [InlineData(17, 0, true)]
    [InlineData(8, 59, false)]
    [InlineData(17, 1, false)]
    [InlineData(12, 30, true)]
    public void IsBusinessHours_returns_correct_result(int hour, int minute, bool expected)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.IsBusinessHours(new TimeOnly(hour, minute));
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void CountWeekdays_counts_only_monday_to_friday()
    {
        var sut = new MoreDatesAndTimes();
        // 2026-04-06 (Mon) to 2026-04-12 (Sun) -> 5 weekdays
        var result = sut.CountWeekdays(new DateOnly(2026, 4, 6), new DateOnly(2026, 4, 12));
        Assert.Equal(5, result);
    }

    [Fact(Skip = "To Do")]
    public void GetNextWeekday_returns_next_occurrence_of_given_day()
    {
        var sut = new MoreDatesAndTimes();
        // 2026-04-08 is a Wednesday, next Monday is 2026-04-13
        var result = sut.GetNextWeekday(new DateOnly(2026, 4, 8), DayOfWeek.Monday);
        Assert.Equal(new DateOnly(2026, 4, 13), result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(9, 7, 9, 15)]
    [InlineData(9, 16, 9, 30)]
    [InlineData(9, 0, 9, 0)]
    [InlineData(9, 46, 10, 0)]
    public void RoundUpToQuarterHour_rounds_correctly(int h, int m, int eh, int em)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.RoundUpToQuarterHour(new TimeOnly(h, m));
        Assert.Equal(new TimeOnly(eh, em), result);
    }

    [Fact(Skip = "To Do")]
    public void MonthsBetween_returns_number_of_full_months()
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.MonthsBetween(new DateOnly(2026, 1, 15), new DateOnly(2026, 4, 10));
        Assert.Equal(2, result);
    }

    [Fact(Skip = "To Do")]
    public void EnsureNotWeekend_throws_when_date_is_weekend()
    {
        var sut = new MoreDatesAndTimes();
        var ex = Assert.Throws<ArgumentException>(() => sut.EnsureNotWeekend(new DateOnly(2026, 4, 4)));
        Assert.Equal("Vergaderingen mogen niet in het weekend plaatsvinden.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void EnsureNotWeekend_does_nothing_for_weekday()
    {
        var sut = new MoreDatesAndTimes();
        sut.EnsureNotWeekend(new DateOnly(2026, 4, 6));
    }

    [Fact(Skip = "To Do")]
    public void TotalDuration_sums_all_appointment_durations()
    {
        var sut = new MoreDatesAndTimes();
        var appointments = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2026, 4, 4, 9, 0, 0), new DateTime(2026, 4, 4, 10, 0, 0)),
            (new DateTime(2026, 4, 4, 11, 0, 0), new DateTime(2026, 4, 4, 11, 30, 0))
        };
        var result = sut.TotalDuration(appointments);
        Assert.Equal(TimeSpan.FromMinutes(90), result);
    }

    [Fact(Skip = "To Do")]
    public void TotalDuration_throws_when_an_appointment_is_invalid()
    {
        var sut = new MoreDatesAndTimes();
        var appointments = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2026, 4, 4, 10, 0, 0), new DateTime(2026, 4, 4, 9, 0, 0))
        };
        Assert.Throws<ArgumentException>(() => sut.TotalDuration(appointments));
    }

    [Fact(Skip = "To Do")]
    public void HasOverlappingPeriods_returns_true_when_periods_overlap()
    {
        var sut = new MoreDatesAndTimes();
        var periods = new List<(DateOnly Start, DateOnly End)>
        {
            (new DateOnly(2026, 4, 1), new DateOnly(2026, 4, 5)),
            (new DateOnly(2026, 4, 4), new DateOnly(2026, 4, 8))
        };
        var result = sut.HasOverlappingPeriods(periods);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void HasOverlappingPeriods_returns_false_when_no_overlap()
    {
        var sut = new MoreDatesAndTimes();
        var periods = new List<(DateOnly Start, DateOnly End)>
        {
            (new DateOnly(2026, 4, 1), new DateOnly(2026, 4, 3)),
            (new DateOnly(2026, 4, 4), new DateOnly(2026, 4, 8))
        };
        var result = sut.HasOverlappingPeriods(periods);
        Assert.False(result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(2026, 4, 3, 1, 2026, 4, 6)]  // Friday + 1 business day -> Monday
    [InlineData(2026, 4, 6, 3, 2026, 4, 9)]  // Monday + 3 business days -> Thursday
    public void AddBusinessDays_skips_weekends(int sy, int sm, int sd, int days, int ey, int em, int ed)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.AddBusinessDays(new DateOnly(sy, sm, sd), days);
        Assert.Equal(new DateOnly(ey, em, ed), result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(2026, 1, 15, 1)]
    [InlineData(2026, 4, 1, 2)]
    [InlineData(2026, 7, 1, 3)]
    [InlineData(2026, 10, 1, 4)]
    public void GetQuarter_returns_correct_quarter(int year, int month, int day, int expected)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetQuarter(new DateOnly(year, month, day));
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(1990, 4, 1, 2026, 4, 4, 2027, 4, 1)]
    [InlineData(1990, 4, 10, 2026, 4, 4, 2026, 4, 10)]
    public void GetNextBirthday_returns_correct_date(int by, int bm, int bd, int ty, int tm, int td, int ey, int em, int ed)
    {
        var sut = new MoreDatesAndTimes();
        var result = sut.GetNextBirthday(new DateOnly(by, bm, bd), new DateOnly(ty, tm, td));
        Assert.Equal(new DateOnly(ey, em, ed), result);
    }

    [Fact(Skip = "To Do")]
    public void MergePeriods_merges_overlapping_and_adjacent_periods()
    {
        var sut = new MoreDatesAndTimes();
        var periods = new List<(DateOnly Start, DateOnly End)>
        {
            (new DateOnly(2026, 4, 1), new DateOnly(2026, 4, 5)),
            (new DateOnly(2026, 4, 4), new DateOnly(2026, 4, 8)),
            (new DateOnly(2026, 4, 10), new DateOnly(2026, 4, 12))
        };
        var result = sut.MergePeriods(periods);
        Assert.Equal(new List<(DateOnly Start, DateOnly End)>
        {
            (new DateOnly(2026, 4, 1), new DateOnly(2026, 4, 8)),
            (new DateOnly(2026, 4, 10), new DateOnly(2026, 4, 12))
        }, result);
    }

    [Fact(Skip = "To Do")]
    public void CanScheduleMeeting_returns_true_when_no_conflicts()
    {
        var sut = new MoreDatesAndTimes();
        var booked = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2026, 4, 4, 9, 0, 0), new DateTime(2026, 4, 4, 10, 0, 0))
        };
        var result = sut.CanScheduleMeeting(
            new DateTime(2026, 4, 4, 10, 0, 0),
            new DateTime(2026, 4, 4, 12, 0, 0),
            TimeSpan.FromMinutes(30),
            booked);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void CanScheduleMeeting_returns_false_when_no_gap_fits()
    {
        var sut = new MoreDatesAndTimes();
        var booked = new List<(DateTime Start, DateTime End)>
        {
            (new DateTime(2026, 4, 4, 9, 0, 0), new DateTime(2026, 4, 4, 11, 30, 0))
        };
        var result = sut.CanScheduleMeeting(
            new DateTime(2026, 4, 4, 9, 0, 0),
            new DateTime(2026, 4, 4, 12, 0, 0),
            TimeSpan.FromMinutes(45),
            booked);
        Assert.False(result);
    }
}