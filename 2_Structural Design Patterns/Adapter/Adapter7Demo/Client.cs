using Adapter7Demo.Step1___Interface;

namespace Adapter7Demo;

// Client code
internal class Client(IAdapter adapter)
{
    public void DoWork()
    {
        adapter.SomeMethod();
    }
}