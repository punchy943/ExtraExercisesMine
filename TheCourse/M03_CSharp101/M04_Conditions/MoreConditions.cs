namespace TheCourse.M03_CSharp101.Exercises.M04_Conditions;

public class MoreConditions
{
    // 1. Easy: returns true if the number is negative
    public bool IsNegative(int number)
    {
        if (number < 0)
        {
            return true;
        }
        return false; // TODO
    }

    // 2. Easy: returns "Yes" if the person is a senior (65 or older), otherwise "No"
    public string IsSenior(int age)
    {
        if (age >= 65)
        {
            return "Yes";
        }
        return "No"; // TODO
    }

    // 3. Easy: returns true if the password has at least 8 characters
    public bool IsPasswordLongEnough(string password)
    {
        if (password.Length >= 8)
        {
            return true;
        }
        return false;  // TODO
    }

    // 4. Easy: returns the day type based on a switch ("zaterdag" or "zondag" => "weekend", anything else => "weekdag")
    public string GetDayType(string day)
    {
        return day switch
        {
            "zaterdag" or "zondag" => "weekend",
            _ => "weekdag"
        };
         // TODO
    }

    // 5. Medium: returns true if a person may drive
    // (at least 18 years old AND has a license)
    public bool MayDrive(int age, bool hasLicense)
    {
        if (age >= 18 && hasLicense)
        {
            return true;
        }
        return false; // TODO
    }

    // 6. Medium: returns the ticket price based on age
    // under 12: 5, 12 to 64 (inclusive): 10, 65 and older: 7
    public int TicketPrice(int age)
    {
        return age switch
        {
            < 12 => 5,
            > 64 => 7,
            _ => 10,
        }; // TODO
    }

    // 7. Medium: returns true if a number is within the range 1 to 100 (inclusive)
    public bool IsValidPercentage(int value)
    {
        if (0 < value && value < 101)
        {
            return true;
        }
        return false; // TODO
    }

    // 8. Medium: returns the BMI category
    // bmi < 18.5: "Ondergewicht", 18.5 to 24.9: "Normaal", 25 to 29.9: "Overgewicht", 30 or higher: "Obesitas"
    public string BmiCategory(double bmi)
    {
        return bmi switch
        {
            < 18.5 => "Ondergewicht",
            >= 18.5 and < 25 => "Normaal",
            >= 25 and < 30 => "Overgewicht",
            _ => "Obesitas"
        }; // TODO
    }

    // 9. Medium: returns true if the login is successful
    // (username equals "admin" AND password equals "1234")
    public bool IsLoginSuccessful(string username, string password)
    {
        if (username == "admin" && password == "1234")
        {
            return true; 
        }
        return false; // TODO
    }

    // 10. Medium: returns the season based on the month number (1-12)
    // 12, 1, 2: "Winter", 3, 4, 5: "Lente", 6, 7, 8: "Zomer", 9, 10, 11: "Herfst"
    public string GetSeason(int month)
    {
        return month switch
        {
            12 or 1 or 2 => "Winter",
            3 or 4 or 5 => "Lente",
            6 or 7 or 8 => "Zomer",
            _ => "Herfst"
        }; // TODO
    }

    // 11. Hard: returns the membership fee
    // isStudent and age < 26: 20
    // isStudent: 35
    // age >= 65: 25
    // otherwise: 50
    public int MembershipFee(int age, bool isStudent)
    {
        if (age < 26 && isStudent)
        {
            return 20;
        }
        if (isStudent)
        {
            return 35;
        }
        if (age >= 65)
        {
            return 25;
        }
        return 50; // TODO
    }

    // 12. Hard: returns true if a triangle with the given sides is valid
    // (the sum of any two sides must be greater than the third side, and all sides must be positive)
    public bool IsValidTriangle(int sideA, int sideB, int sideC)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Hard: returns the parking fee based on hours parked
    // first hour (0 to 1, inclusive): free
    // 1 to 3 hours: 2 per hour
    // more than 3 hours: 6 + 1 per additional hour above 3
    public decimal ParkingFee(decimal hours)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the password strength
    // length < 6: "Zwak"
    // length 6 to 9 without a digit: "Gemiddeld"
    // length 6 to 9 with at least one digit, or length >= 10 without digit: "Sterk"
    // length >= 10 with at least one digit: "Zeer sterk"
    public string PasswordStrength(string password, bool containsDigit)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns the shipping label based on combined conditions
    // isFragile and isInternational: "Fragiel - Internationaal"
    // isFragile: "Fragiel"
    // isInternational: "Internationaal"
    // otherwise: "Standaard"
    public string GetShippingLabel(bool isFragile, bool isInternational)
    {
        throw new NotImplementedException(); // TODO
    }
}