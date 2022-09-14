namespace tests;

public class Student_Program_Should
{
    System.Reflection.Assembly sut;
    System.Reflection.MethodInfo entry;
    [Fact]
    public void Be_Placed_In_Src_Folder()
    {
        Action act = () => {
            sut = System.Reflection.Assembly.Load("src");
            entry = sut.EntryPoint;
        };
        act.Should().NotThrow<Exception>();
        sut.Should().NotBeNull();
        entry.Should().NotBeNull();
    }

    // [Fact]
    // public void 
}
public abstract class Abstract_Console_Test
{
    protected abstract string __AssemblyName { get; }
}