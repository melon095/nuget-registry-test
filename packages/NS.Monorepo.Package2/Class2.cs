using System.Reflection;

namespace NS.Monorepo.Package2;

public class Class2
{
    public void Method()
    {
        Console.WriteLine(Assembly.GetExecutingAssembly().GetName().Name);
    }
}
