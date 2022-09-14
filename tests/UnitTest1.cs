namespace tests;

public class Student_Program_Should : Abstract_Console_Test
{
    protected override string __AssemblyName => "src";
    [Fact(Timeout = 1000)]
    public void Be_Placed_In_Src_Folder()
    {
        Action act = base._ObtainEntryPoint;
        act.Should().NotThrow<Exception>();
        sut.Should().NotBeNull();
        entry.Should().NotBeNull();
    }

    [Fact(Timeout = 1000)]
    public void Output_UserName_And_Actual_Name()
    {
        Run("", () =>
        {
            var output = __output.ToString();
            output.Should().NotBeNullOrEmpty();
            var lines = output.Trim().Split(__output.NewLine, StringSplitOptions.RemoveEmptyEntries);
            lines.Length.Should().BeGreaterThanOrEqualTo(2, "because the first two lines of output should be your GitHub username and your actual name");
            
            lines[1].Should().Contain(" ", "your actual name should include your first and last name (separated by a space)");
        });
    }

    [Theory(Timeout = 1000)]
    [InlineData(1, 1, 0.5)]
    [InlineData(2, 1, 1)]
    public void Calculate_Area_From_Height_And_Base(int givenHeight, int givenBase, double expectedArea)
    {
        string userInput = $"{givenHeight}\n{givenBase}\n";
        Run(userInput, () =>
        {
            var output = __output.ToString();
            output.Should().NotBeNullOrEmpty();
            var lines = output.Trim().Split(__output.NewLine);
            lines.Length.Should().BeGreaterThanOrEqualTo(5, "expected two prompt lines followed by an output line");
            lines.Last().Should().Be(expectedArea.ToString(), $"The area of a triangle with base {givenBase} and height {givenHeight} should be {expectedArea}");
        });
    }
}
