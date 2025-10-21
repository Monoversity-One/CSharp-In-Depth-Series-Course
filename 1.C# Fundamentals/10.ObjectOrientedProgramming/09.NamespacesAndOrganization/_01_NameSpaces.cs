namespace _10.Object_OrientedProgramming._09.NamespacesAndOrganization;

class _06_NameSpaces
{
    void AnotherMethod()
    {
        MyCustomClass myObj = new MyCustomClass();
        MyCustomClass myObj2 = new MyCustomClass();
        myObj2.SayHi();
    }
}

public class MyCustomClass
{
    public string AnimalColor;
    public void SayHi()
    {
        Console.WriteLine("Hello form myNameSpace!");
    }
}