namespace TheCourse.M03_CSharp101.Exercises.M15_LINQ.MethodSyntax;

public class MoreStudentQueriesTests
{
    private readonly List<Student> students =
    [
        new Student { Name = "Alice", Age = 17, Class = "Math" },
        new Student { Name = "Bob", Age = 20, Class = "Science" },
        new Student { Name = "Charlie", Age = 19, Class = "Math" },
        new Student { Name = "Diana", Age = 18, Class = "History" },
        new Student { Name = "Eve", Age = 21, Class = "Science" },
    ];

    [Fact(Skip = "To Do")]
    public void Test_HeeftMathStudent()
    {
        Assert.True(MoreStudentQueries.HeeftMathStudent(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_NamenInKlas()
    {
        var result = MoreStudentQueries.NamenInKlas(students, "Math").ToList();
        Assert.Equal(["Alice", "Charlie"], result);
    }

    [Fact(Skip = "To Do")]
    public void Test_OudsteLeeftijd()
    {
        Assert.Equal(21, MoreStudentQueries.OudsteLeeftijd(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_JongsteLeeftijd()
    {
        Assert.Equal(17, MoreStudentQueries.JongsteLeeftijd(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_TotaleLeeftijd()
    {
        Assert.Equal(95, MoreStudentQueries.TotaleLeeftijd(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_GeenEnkeleTeJong()
    {
        Assert.True(MoreStudentQueries.GeenEnkeleTeJong(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_ZoekOpNaam_gevonden()
    {
        var result = MoreStudentQueries.ZoekOpNaam(students, "Bob");
        Assert.NotNull(result);
        Assert.Equal(20, result!.Age);
    }

    [Fact(Skip = "To Do")]
    public void Test_ZoekOpNaam_niet_gevonden()
    {
        var result = MoreStudentQueries.ZoekOpNaam(students, "Frank");
        Assert.Null(result);
    }

    [Fact(Skip = "To Do")]
    public void Test_GesorteerdeHoofdletterNamen()
    {
        var result = MoreStudentQueries.GesorteerdeHoofdletterNamen(students).ToList();
        Assert.Equal(["ALICE", "BOB", "CHARLIE", "DIANA", "EVE"], result);
    }

    [Fact(Skip = "To Do")]
    public void Test_GesorteerdOpKlasEnLeeftijd()
    {
        var result = MoreStudentQueries.GesorteerdOpKlasEnLeeftijd(students).ToList();
        Assert.Equal("Diana", result[0].Name);
        Assert.Equal("Alice", result[1].Name);
        Assert.Equal("Charlie", result[2].Name);
        Assert.Equal("Bob", result[3].Name);
        Assert.Equal("Eve", result[4].Name);
    }

    [Fact(Skip = "To Do")]
    public void Test_AantalPerKlas()
    {
        var result = MoreStudentQueries.AantalPerKlas(students);
        Assert.Equal(2, result["Math"]);
        Assert.Equal(2, result["Science"]);
        Assert.Equal(1, result["History"]);
    }

    [Fact(Skip = "To Do")]
    public void Test_HeeftDuplicateNamen_false()
    {
        Assert.False(MoreStudentQueries.HeeftDuplicateNamen(students));
    }

    [Fact(Skip = "To Do")]
    public void Test_HeeftDuplicateNamen_true()
    {
        var withDuplicate = new List<Student>(students) { new Student { Name = "Alice", Age = 15, Class = "Art" } };
        Assert.True(MoreStudentQueries.HeeftDuplicateNamen(withDuplicate));
    }

    [Fact(Skip = "To Do")]
    public void Test_NamenMetLetter()
    {
        var result = MoreStudentQueries.NamenMetLetter(students, 'a').ToList();
        Assert.Contains("Charlie", result);
        Assert.Contains("Diana", result);
        Assert.DoesNotContain("Bob", result);
    }

    [Fact(Skip = "To Do")]
    public void Test_ZonderUitgeslotenen()
    {
        var result = MoreStudentQueries.ZonderUitgeslotenen(students, new[] { "Bob", "Eve" }).ToList();
        Assert.Equal(3, result.Count);
        Assert.DoesNotContain(result, s => s.Name == "Bob" || s.Name == "Eve");
    }

    [Fact(Skip = "To Do")]
    public void Test_GemiddeldeLeeftijdPerKlas()
    {
        var result = MoreStudentQueries.GemiddeldeLeeftijdPerKlas(students);
        Assert.Equal(18, result["Math"]);
        Assert.Equal(20.5, result["Science"]);
        Assert.Equal(18, result["History"]);
    }

    [Fact(Skip = "To Do")]
    public void Test_KlasMetMeesteStudenten()
    {
        var result = MoreStudentQueries.KlasMetMeesteStudenten(students);
        Assert.True(result == "Math" || result == "Science");
    }

    [Fact(Skip = "To Do")]
    public void Test_GroteKlassen()
    {
        var result = MoreStudentQueries.GroteKlassen(students);
        Assert.True(result.ContainsKey("Math"));
        Assert.True(result.ContainsKey("Science"));
        Assert.False(result.ContainsKey("History"));
        Assert.Equal(2, result["Math"].Count);
    }

    [Fact(Skip = "To Do")]
    public void Test_SamenvoegenZonderDuplicaten()
    {
        var lijst2 = new List<Student> { new Student { Name = "Alice", Age = 99, Class = "Other" }, new Student { Name = "Frank", Age = 22, Class = "Art" } };
        var result = MoreStudentQueries.SamenvoegenZonderDuplicaten(students, lijst2).ToList();
        Assert.Equal(6, result.Count);
        Assert.Equal("Alice", result[0].Name);
        Assert.Equal("Bob", result[1].Name);
    }

    [Fact(Skip = "To Do")]
    public void Test_LeeftijdRang()
    {
        Assert.Equal(1, MoreStudentQueries.LeeftijdRang(students, "Eve"));
        Assert.Equal(5, MoreStudentQueries.LeeftijdRang(students, "Alice"));
    }

    [Fact(Skip = "To Do")]
    public void Test_LeeftijdRang_niet_gevonden()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => MoreStudentQueries.LeeftijdRang(students, "Frank"));
        Assert.Equal("Student niet gevonden.", ex.Message);
    }

    [Fact(Skip = "To Do")]
    public void Test_KrisKrasParen()
    {
        var result = MoreStudentQueries.KrisKrasParen(students).ToList();
        Assert.All(result, p => Assert.NotEqual(p.Item1.Class, p.Item2.Class));
        Assert.All(result, p => Assert.NotEqual(p.Item1.Name, p.Item2.Name));
    }

    [Fact(Skip = "To Do")]
    public void Test_Rapport()
    {
        var result = MoreStudentQueries.Rapport(students).ToList();
        Assert.Equal(5, result.Count);
        Assert.Contains("Alice (Math): 17 years old", result[0]);
    }
}