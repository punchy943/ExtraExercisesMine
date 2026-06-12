namespace TheCourse.M03_CSharp101.Exercises.M12_DatesAndTimes;

public class MoreDatesAndTimes
{
    // 1. Easy: returns true if the year of the date is a leap year
    public bool IsLeapYear(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: returns the name of the day of the week (e.g. "Monday")
    public string GetDayName(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 3. Easy: returns true if the date falls on a weekend (Saturday or Sunday)
    public bool IsWeekend(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Easy: returns the date with the given number of days added
    public DateOnly AddDays(DateOnly date, int days)
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Easy: returns the age in years, given a birthdate and the current date
    public int GetAge(DateOnly birthDate, DateOnly today)
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: returns the first day of the month for the given date
    public DateOnly GetFirstDayOfMonth(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns the last day of the month for the given date
    public DateOnly GetLastDayOfMonth(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: returns true if the given time falls within business hours (09:00 to 17:00, inclusive)
    public bool IsBusinessHours(TimeOnly time)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: returns the number of weekdays (Monday to Friday) between two dates, inclusive
    public int CountWeekdays(DateOnly start, DateOnly end)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: returns the next occurrence of the given day of the week, after the given date
    // (e.g. if date is a Wednesday and dayOfWeek is Monday, returns the following Monday)
    public DateOnly GetNextWeekday(DateOnly date, DayOfWeek dayOfWeek)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Medium: rounds the given time up to the nearest quarter hour
    // (e.g. 09:07 -> 09:15, 09:16 -> 09:30, 09:00 -> 09:00)
    public TimeOnly RoundUpToQuarterHour(TimeOnly time)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Medium: returns the number of full months between two dates
    // (e.g. 2026-01-15 to 2026-04-10 -> 2)
    public int MonthsBetween(DateOnly start, DateOnly end)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Medium: throws ArgumentException with message "Vergaderingen mogen niet in het weekend plaatsvinden."
    // if the date falls on a weekend, otherwise does nothing
    public void EnsureNotWeekend(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the total duration of all appointments combined, given a list of (start, end) tuples
    // throws ArgumentException if any appointment has end before start
    public TimeSpan TotalDuration(List<(DateTime Start, DateTime End)> appointments)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns true if any of the given periods overlap with each other
    public bool HasOverlappingPeriods(List<(DateOnly Start, DateOnly End)> periods)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: returns the number of business days (Mon-Fri) needed to deliver, starting from the given date
    // (e.g. if startDate is a Friday and businessDays is 1, the delivery date is the following Monday)
    public DateOnly AddBusinessDays(DateOnly startDate, int businessDays)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: returns the quarter of the year (1-4) for the given date
    public int GetQuarter(DateOnly date)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: returns the next occurrence of the person's birthday on or after the given date
    // (e.g. if today is 2026-04-04 and birthDate is 1990-04-01, the next birthday is 2027-04-01;
    // if birthDate is 1990-04-10, the next birthday is 2026-04-10)
    public DateOnly GetNextBirthday(DateOnly birthDate, DateOnly today)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: merges overlapping or adjacent (touching) periods into a minimal list of non-overlapping periods
    // (e.g. [(1, 5), (4, 8), (10, 12)] -> [(1, 8), (10, 12)])
    public List<(DateOnly Start, DateOnly End)> MergePeriods(List<(DateOnly Start, DateOnly End)> periods)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: returns true if a meeting of the given duration can fit between start and end,
    // taking into account a list of already booked (start, end) periods that must not be overlapped
    public bool CanScheduleMeeting(DateTime start, DateTime end, TimeSpan duration, List<(DateTime Start, DateTime End)> bookedPeriods)
    {
        throw new NotImplementedException(); // TODO
    }
}