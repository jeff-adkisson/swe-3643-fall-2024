using TestCoverage;
using Xunit.Abstractions;

namespace TestCoverageUnitTests;

public class GradeLetterGeneratorTests(ITestOutputHelper console)
{
    [Theory]
    [InlineData(99, "A+")]
    [InlineData(89, "B+")]
    [InlineData(79, "C+")]
    [InlineData(69, "D+")]
    public void GradeLetterGenerator_ReceivesScore_ReturnsLetterGrade(double grade, string expectedLetterGrade)
    {
        // Arrange

        // Act
        var actualLetterGrade = GradeLetterGenerator.GetGradeLetters(grade);
        console.WriteLine($"{grade} is a {actualLetterGrade}");

        // Assert
        Assert.Equal(expectedLetterGrade, actualLetterGrade);
    }
}