using NS.Monorepo.Package2;

namespace NS.Monorepo.Package1;

public class Class1
{
    private readonly Class2 _class2 = new();

    public void Method()
    {
        _class2.Method();
    }
}
