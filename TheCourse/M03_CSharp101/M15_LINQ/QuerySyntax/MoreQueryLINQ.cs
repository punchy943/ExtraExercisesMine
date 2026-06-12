namespace TheCourse.M03_CSharp101.Exercises.M15_LINQ.QuerySyntax;

//Tip voor de leerlingen: query syntax heeft geen directe equivalenten voor alles — Any(), All(), Max(), Min(), Sum(), ToDictionary() en FirstOrDefault() bestaan niet als query keywords. 
//Leerlingen zullen dus leren dat je die als method aanroept ná een query expressie, bv.:
//csharp(from s in studenten select s.Age).Max()
//Dat is een mooie leermogelijkheid over waar de twee syntaxen overlappen!

public class Student
{
    public required string Name { get; init; }
    public int Age { get; set; }
    public required string Class { get; init; }
}

public static class StudentQueries
{
    // 1. Easy: returns true if there is at least one student in "Math"
    public static bool HeeftMathStudent(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 2. Easy: returns the names of all students in the given class
    public static IEnumerable<string> NamenInKlas(IEnumerable<Student> studenten, string klas)
    {
        throw new NotImplementedException(); // TODO
    }

    // 3. Easy: returns the oldest age among all students
    public static int OudsteLeeftijd(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 4. Easy: returns the youngest age among all students
    public static int JongsteLeeftijd(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 5. Easy: returns the total of all ages combined
    public static int TotaleLeeftijd(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 6. Medium: returns true if no student is younger than 16
    public static bool GeenEnkeleTeJong(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 7. Medium: returns the student with the given name, or null if not found
    public static Student? ZoekOpNaam(IEnumerable<Student> studenten, string naam)
    {
        throw new NotImplementedException(); // TODO
    }

    // 8. Medium: returns the names of students, sorted alphabetically, then converted to uppercase
    public static IEnumerable<string> GesorteerdeHoofdletterNamen(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 9. Medium: returns the students sorted by class, and within each class by age (ascending)
    public static IEnumerable<Student> GesorteerdOpKlasEnLeeftijd(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 10. Medium: returns the number of students in each class as a dictionary (Class -> Count)
    public static Dictionary<string, int> AantalPerKlas(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 11. Medium: returns true if any two students share the same name
    public static bool HeeftDuplicateNamen(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 12. Medium: returns the names of students whose name contains the given letter (case-insensitive)
    public static IEnumerable<string> NamenMetLetter(IEnumerable<Student> studenten, char letter)
    {
        throw new NotImplementedException(); // TODO
    }

    // 13. Medium: returns the students that are NOT in the given list of excluded names
    public static IEnumerable<Student> ZonderUitgeslotenen(IEnumerable<Student> studenten, IEnumerable<string> uitgesloten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 14. Hard: returns the average age per class as a dictionary (Class -> AverageAge)
    public static Dictionary<string, double> GemiddeldeLeeftijdPerKlas(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 15. Hard: returns the name of the class with the most students
    public static string KlasMetMeesteStudenten(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 16. Hard: returns the students grouped by class, but only for classes with more than one student;
    // result is a dictionary (Class -> list of student names)
    public static Dictionary<string, List<string>> GroteKlassen(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 17. Hard: combines two lists of students into one, removing duplicates based on Name,
    // and returns the result sorted by Name
    public static IEnumerable<Student> SamenvoegenZonderDuplicaten(IEnumerable<Student> studenten1, IEnumerable<Student> studenten2)
    {
        throw new NotImplementedException(); // TODO
    }

    // 18. Hard: returns the rank (1-based position) of the given student when sorted by age descending
    // (e.g. the oldest student has rank 1); throws InvalidOperationException with message
    // "Student niet gevonden." if the student is not in the list
    public static int LeeftijdRang(IEnumerable<Student> studenten, string naam)
    {
        throw new NotImplementedException(); // TODO
    }

    // 19. Hard: returns pairs of (Student, Student) for every unique combination of two students
    // from different classes (no pair should appear twice, and a student shouldn't be paired with themselves)
    public static IEnumerable<(Student, Student)> KrisKrasParen(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }

    // 20. Hard: returns a "report card" string for each student in the format
    // "Name (Class): Age years old, X% of the average age"
    // where X is the student's age as a percentage of the overall average age, rounded to the nearest integer
    public static IEnumerable<string> Rapport(IEnumerable<Student> studenten)
    {
        throw new NotImplementedException(); // TODO
    }
}