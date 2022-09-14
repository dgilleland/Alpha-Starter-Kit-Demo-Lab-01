namespace tests;

public abstract class Abstract_Console_Test
{
    protected System.Reflection.Assembly sut = default!;
    protected System.Reflection.MethodInfo entry = default!;
    protected StringWriter __output = default!;
    protected StringReader __input = default!;
    protected abstract string __AssemblyName { get; }
    protected void Run(string userInput, Action test)
    {
        using (__input = new StringReader(userInput))
        using (__output = new StringWriter())
        {
            // Redirect I/O
            SetOut(__output);
            SetIn(__input);
            // Obtain Entry Point
            _ObtainEntryPoint();
            // Run Program
            __RunEntryPoint(entry);
            // Run the tests
            test();
        }
    }

    protected void _ObtainEntryPoint()
    {
        // Obtain Entry Point
        sut = System.Reflection.Assembly.Load(__AssemblyName);
        if(sut != null)
            entry = sut.EntryPoint!;
    }

    private void __RunEntryPoint(System.Reflection.MethodInfo entryPoint)
    {
        object[] args = new object[] { Array.Empty<string>() };
        entryPoint.Invoke(null, args);
    }
}