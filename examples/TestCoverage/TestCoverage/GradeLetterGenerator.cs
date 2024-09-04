namespace TestCoverage;

public static class GradeLetterGenerator
{
    public static string GetGradeLetters(double grade)
    {
        if (grade >= 90.0)
        {
            return grade >= 99.0
                ? "A+"
                : "A";
        }

        if (grade >= 80.0)
        {
            return grade >= 89.0
                ? "B+"
                : "B";
        }

        if (grade >= 70.0)
        {
            return grade >= 79.0
                ? "C+"
                : "C";
        }

        if (grade >= 60.0)
        {
            return grade >= 69.0
                ? "D+"
                : "D";
        }

        return "F";
    }
}