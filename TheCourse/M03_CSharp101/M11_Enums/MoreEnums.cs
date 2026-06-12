namespace TheCourse.M03_CSharp101.Exercises.M11_Enums;

public class TrafficLight
{
    public enum LightColor
    {
        Red,
        Yellow,
        Green
    }

    public LightColor Color { get; set; }

    // 1. Easy: returns "Stop" for Red, "Slow down" for Yellow, "Go" for Green
    public string GetInstruction()
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: switches to the next color in the cycle (Red -> Green -> Yellow -> Red)
    public void Next()
    {
        throw new NotImplementedException(); // TODO
    }
}

public class Order
{
    public enum OrderStatus
    {
        Pending,
        Shipped,
        Delivered,
        Cancelled
    }

    public OrderStatus Status { get; set; }

    // 3. Easy: returns true if the order can still be cancelled (only when Pending or Shipped)
    public bool CanBeCancelled()
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Medium: marks the order as shipped; throws InvalidOperationException
    // with message "Kan enkel verzonden worden vanuit pending status." if not Pending
    public void Ship()
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Medium: marks the order as delivered; throws InvalidOperationException
    // with message "Kan enkel afgeleverd worden na verzending." if not Shipped
    public void Deliver()
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: cancels the order; throws InvalidOperationException
    // with message "Kan niet geannuleerd worden in huidige status." if status is Delivered or Cancelled
    public void Cancel()
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns a human-readable Dutch status message for each status
    // Pending -> "In behandeling.", Shipped -> "Verzonden.", Delivered -> "Afgeleverd.", Cancelled -> "Geannuleerd."
    public string GetStatusMessage()
    {
        throw new NotImplementedException(); // TODO
    }
}

public class Account
{
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Admin = 8
    }

    public Permissions UserPermissions { get; set; }

    // 8. Medium: returns true if the user has the given permission
    public bool HasPermission(Permissions permission)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: adds the given permission to the user's existing permissions
    public void GrantPermission(Permissions permission)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: removes the given permission from the user's existing permissions
    public void RevokePermission(Permissions permission)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Hard: returns true if the user has ALL of the given permissions
    public bool HasAllPermissions(Permissions permissions)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Hard: returns true if the user has ANY of the given permissions
    public bool HasAnyPermission(Permissions permissions)
    {
        throw new NotImplementedException(); // TODO
    }
}

public class Thermostat
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public Season CurrentSeason { get; set; }

    // 13. Medium: returns the recommended temperature for the current season
    // Spring -> 20, Summer -> 24, Autumn -> 18, Winter -> 21
    public int GetRecommendedTemperature()
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: parses a string ("spring", "summer", "autumn", "winter", case-insensitive)
    // into the Season enum; throws ArgumentException with message "Onbekend seizoen."
    // if the string doesn't match any season
    public Season ParseSeason(string input)
    {
        throw new NotImplementedException(); // TODO
    }
}

public class Game
{
    public enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
        Nightmare = 4
    }

    public Difficulty CurrentDifficulty { get; set; }

    // 15. Hard: returns the score multiplier based on difficulty
    // (the multiplier equals the numeric value of the difficulty, e.g. Hard = 3 -> multiplier 3)
    public int GetScoreMultiplier()
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: increases the difficulty by one level; throws InvalidOperationException
    // with message "Kan niet moeilijker dan Nightmare." if already at Nightmare
    public void IncreaseDifficulty()
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: returns all difficulty levels as an array, ordered from Easy to Nightmare
    public Difficulty[] GetAllDifficulties()
    {
        throw new NotImplementedException(); // TODO
    }
}

public class Subscription
{
    public enum Plan
    {
        Free,
        Basic,
        Premium,
        Enterprise
    }

    public Plan CurrentPlan { get; set; }

    // 18. Hard: returns true if the current plan allows upgrading to the target plan
    // (you can only upgrade to a "higher" plan, based on declaration order)
    public bool CanUpgradeTo(Plan targetPlan)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: upgrades to the target plan if allowed, otherwise throws InvalidOperationException
    // with message "Upgrade niet mogelijk vanaf huidig plan."
    public void UpgradeTo(Plan targetPlan)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: returns the monthly price for the current plan
    // Free -> 0, Basic -> 5, Premium -> 15, Enterprise -> 50
    public decimal GetMonthlyPrice()
    {
        throw new NotImplementedException(); // TODO
    }
}