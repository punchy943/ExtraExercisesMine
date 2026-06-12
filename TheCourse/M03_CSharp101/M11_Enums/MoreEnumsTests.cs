namespace TheCourse.M03_CSharp101.Exercises.M11_Enums;

public class TrafficLightTests
{
    [Theory(Skip = "To Do")]
    [InlineData(TrafficLight.LightColor.Red, "Stop")]
    [InlineData(TrafficLight.LightColor.Yellow, "Slow down")]
    [InlineData(TrafficLight.LightColor.Green, "Go")]
    public void GetInstruction_returns_correct_instruction(TrafficLight.LightColor color, string expected)
    {
        var light = new TrafficLight { Color = color };
        var result = light.GetInstruction();
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(TrafficLight.LightColor.Red, TrafficLight.LightColor.Green)]
    [InlineData(TrafficLight.LightColor.Green, TrafficLight.LightColor.Yellow)]
    [InlineData(TrafficLight.LightColor.Yellow, TrafficLight.LightColor.Red)]
    public void Next_cycles_to_correct_color(TrafficLight.LightColor current, TrafficLight.LightColor expected)
    {
        var light = new TrafficLight { Color = current };
        light.Next();
        Assert.Equal(expected, light.Color);
    }
}

public class OrderTests
{
    [Theory(Skip = "To Do")]
    [InlineData(Order.OrderStatus.Pending, true)]
    [InlineData(Order.OrderStatus.Shipped, true)]
    [InlineData(Order.OrderStatus.Delivered, false)]
    [InlineData(Order.OrderStatus.Cancelled, false)]
    public void CanBeCancelled_returns_correct_result(Order.OrderStatus status, bool expected)
    {
        var order = new Order { Status = status };
        var result = order.CanBeCancelled();
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void Ship_changes_status_to_shipped()
    {
        var order = new Order { Status = Order.OrderStatus.Pending };
        order.Ship();
        Assert.Equal(Order.OrderStatus.Shipped, order.Status);
    }

    [Fact(Skip = "To Do")]
    public void Ship_throws_when_not_pending()
    {
        var order = new Order { Status = Order.OrderStatus.Shipped };
        var ex = Assert.Throws<InvalidOperationException>(() => order.Ship());
        Assert.Equal("Kan enkel verzonden worden vanuit pending status.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void Deliver_changes_status_to_delivered()
    {
        var order = new Order { Status = Order.OrderStatus.Shipped };
        order.Deliver();
        Assert.Equal(Order.OrderStatus.Delivered, order.Status);
    }

    [Fact(Skip = "To Do")]
    public void Deliver_throws_when_not_shipped()
    {
        var order = new Order { Status = Order.OrderStatus.Pending };
        var ex = Assert.Throws<InvalidOperationException>(() => order.Deliver());
        Assert.Equal("Kan enkel afgeleverd worden na verzending.", ex.Message);
    }

    [Theory(Skip = "To Do")]
    [InlineData(Order.OrderStatus.Pending)]
    [InlineData(Order.OrderStatus.Shipped)]
    public void Cancel_changes_status_to_cancelled(Order.OrderStatus status)
    {
        var order = new Order { Status = status };
        order.Cancel();
        Assert.Equal(Order.OrderStatus.Cancelled, order.Status);
    }

    [Theory(Skip = "To Do")]
    [InlineData(Order.OrderStatus.Delivered)]
    [InlineData(Order.OrderStatus.Cancelled)]
    public void Cancel_throws_when_status_is_delivered_or_cancelled(Order.OrderStatus status)
    {
        var order = new Order { Status = status };
        var ex = Assert.Throws<InvalidOperationException>(() => order.Cancel());
        Assert.Equal("Kan niet geannuleerd worden in huidige status.", ex.Message);
    }

    [Theory(Skip = "To Do")]
    [InlineData(Order.OrderStatus.Pending, "In behandeling.")]
    [InlineData(Order.OrderStatus.Shipped, "Verzonden.")]
    [InlineData(Order.OrderStatus.Delivered, "Afgeleverd.")]
    [InlineData(Order.OrderStatus.Cancelled, "Geannuleerd.")]
    public void GetStatusMessage_returns_correct_message(Order.OrderStatus status, string expected)
    {
        var order = new Order { Status = status };
        var result = order.GetStatusMessage();
        Assert.Equal(expected, result);
    }
}

public class AccountTests
{
    [Fact(Skip = "To Do")]
    public void HasPermission_returns_true_when_permission_is_granted()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read | Account.Permissions.Write };
        var result = account.HasPermission(Account.Permissions.Write);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void HasPermission_returns_false_when_permission_is_not_granted()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read };
        var result = account.HasPermission(Account.Permissions.Delete);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void GrantPermission_adds_permission()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read };
        account.GrantPermission(Account.Permissions.Write);
        Assert.True(account.HasPermission(Account.Permissions.Write));
        Assert.True(account.HasPermission(Account.Permissions.Read));
    }

    [Fact(Skip = "To Do")]
    public void RevokePermission_removes_permission()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read | Account.Permissions.Write };
        account.RevokePermission(Account.Permissions.Write);
        Assert.False(account.HasPermission(Account.Permissions.Write));
        Assert.True(account.HasPermission(Account.Permissions.Read));
    }

    [Fact(Skip = "To Do")]
    public void HasAllPermissions_returns_true_when_all_present()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read | Account.Permissions.Write | Account.Permissions.Delete };
        var result = account.HasAllPermissions(Account.Permissions.Read | Account.Permissions.Write);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void HasAllPermissions_returns_false_when_one_missing()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read };
        var result = account.HasAllPermissions(Account.Permissions.Read | Account.Permissions.Write);
        Assert.False(result);
    }

    [Fact(Skip = "To Do")]
    public void HasAnyPermission_returns_true_when_one_matches()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read };
        var result = account.HasAnyPermission(Account.Permissions.Read | Account.Permissions.Admin);
        Assert.True(result);
    }

    [Fact(Skip = "To Do")]
    public void HasAnyPermission_returns_false_when_none_match()
    {
        var account = new Account { UserPermissions = Account.Permissions.Read };
        var result = account.HasAnyPermission(Account.Permissions.Write | Account.Permissions.Admin);
        Assert.False(result);
    }
}

public class ThermostatTests
{
    [Theory(Skip = "To Do")]
    [InlineData(Thermostat.Season.Spring, 20)]
    [InlineData(Thermostat.Season.Summer, 24)]
    [InlineData(Thermostat.Season.Autumn, 18)]
    [InlineData(Thermostat.Season.Winter, 21)]
    public void GetRecommendedTemperature_returns_correct_value(Thermostat.Season season, int expected)
    {
        var thermostat = new Thermostat { CurrentSeason = season };
        var result = thermostat.GetRecommendedTemperature();
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData("spring", Thermostat.Season.Spring)]
    [InlineData("WINTER", Thermostat.Season.Winter)]
    [InlineData("Summer", Thermostat.Season.Summer)]
    public void ParseSeason_parses_valid_strings_case_insensitively(string input, Thermostat.Season expected)
    {
        var thermostat = new Thermostat();
        var result = thermostat.ParseSeason(input);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void ParseSeason_throws_for_unknown_string()
    {
        var thermostat = new Thermostat();
        var ex = Assert.Throws<ArgumentException>(() => thermostat.ParseSeason("foo"));
        Assert.Equal("Onbekend seizoen.", ex.Message);
    }
}

public class GameTests
{
    [Theory(Skip = "To Do")]
    [InlineData(Game.Difficulty.Easy, 1)]
    [InlineData(Game.Difficulty.Medium, 2)]
    [InlineData(Game.Difficulty.Hard, 3)]
    [InlineData(Game.Difficulty.Nightmare, 4)]
    public void GetScoreMultiplier_returns_correct_value(Game.Difficulty difficulty, int expected)
    {
        var game = new Game { CurrentDifficulty = difficulty };
        var result = game.GetScoreMultiplier();
        Assert.Equal(expected, result);
    }

    [Theory(Skip = "To Do")]
    [InlineData(Game.Difficulty.Easy, Game.Difficulty.Medium)]
    [InlineData(Game.Difficulty.Medium, Game.Difficulty.Hard)]
    [InlineData(Game.Difficulty.Hard, Game.Difficulty.Nightmare)]
    public void IncreaseDifficulty_moves_to_next_level(Game.Difficulty current, Game.Difficulty expected)
    {
        var game = new Game { CurrentDifficulty = current };
        game.IncreaseDifficulty();
        Assert.Equal(expected, game.CurrentDifficulty);
    }

    [Fact(Skip = "To Do")]
    public void IncreaseDifficulty_throws_when_already_at_nightmare()
    {
        var game = new Game { CurrentDifficulty = Game.Difficulty.Nightmare };
        var ex = Assert.Throws<InvalidOperationException>(() => game.IncreaseDifficulty());
        Assert.Equal("Kan niet moeilijker dan Nightmare.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void GetAllDifficulties_returns_all_levels_in_order()
    {
        var game = new Game();
        var result = game.GetAllDifficulties();
        Assert.Equal(new[] { Game.Difficulty.Easy, Game.Difficulty.Medium, Game.Difficulty.Hard, Game.Difficulty.Nightmare }, result);
    }
}

public class SubscriptionTests
{
    [Theory(Skip = "To Do")]
    [InlineData(Subscription.Plan.Free, Subscription.Plan.Basic, true)]
    [InlineData(Subscription.Plan.Basic, Subscription.Plan.Premium, true)]
    [InlineData(Subscription.Plan.Premium, Subscription.Plan.Basic, false)]
    [InlineData(Subscription.Plan.Free, Subscription.Plan.Free, false)]
    public void CanUpgradeTo_returns_correct_result(Subscription.Plan current, Subscription.Plan target, bool expected)
    {
        var subscription = new Subscription { CurrentPlan = current };
        var result = subscription.CanUpgradeTo(target);
        Assert.Equal(expected, result);
    }

    [Fact(Skip = "To Do")]
    public void UpgradeTo_changes_plan_when_allowed()
    {
        var subscription = new Subscription { CurrentPlan = Subscription.Plan.Free };
        subscription.UpgradeTo(Subscription.Plan.Premium);
        Assert.Equal(Subscription.Plan.Premium, subscription.CurrentPlan);
    }

    [Fact(Skip = "To Do")]
    public void UpgradeTo_throws_when_not_allowed()
    {
        var subscription = new Subscription { CurrentPlan = Subscription.Plan.Premium };
        var ex = Assert.Throws<InvalidOperationException>(() => subscription.UpgradeTo(Subscription.Plan.Basic));
        Assert.Equal("Upgrade niet mogelijk vanaf huidig plan.", ex.Message);
    }

    [Theory(Skip = "To Do")]
    [InlineData(Subscription.Plan.Free, 0)]
    [InlineData(Subscription.Plan.Basic, 5)]
    [InlineData(Subscription.Plan.Premium, 15)]
    [InlineData(Subscription.Plan.Enterprise, 50)]
    public void GetMonthlyPrice_returns_correct_price(Subscription.Plan plan, decimal expected)
    {
        var subscription = new Subscription { CurrentPlan = plan };
        var result = subscription.GetMonthlyPrice();
        Assert.Equal(expected, result);
    }
}