using TestCoverage;

public static class Program
{
    public static void Main(string[] args)
    {
        for (double i = 0; i <= 100; i += 0.25)
        {
            Console.WriteLine($"{i} is a {GradeLetterGenerator.GetGradeLetters(i)}");
        }
    }
}