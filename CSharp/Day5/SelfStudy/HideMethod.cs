namespace Day5.SelfStudy.HideMethod;

class Main
{
    public static void Parent()
    {
        Parent parent = new();
        parent.Method();
        parent.HideMethod();
    }

    public static void Child()
    {
        Child child = new();
        child.Method();
        child.HideMethod();
    }

    public static void ParentEqualChildInstance()
    {
        // Parent can assign child instance but can access to child method
        Parent parent = new Child();
        parent.Method();
        parent.HideMethod();
    }
}

class Parent
{
    public Parent() => Console.WriteLine("> Parent Constructor");

    public void Method() => Console.WriteLine("> Parent Method");

    public void HideMethod() => Console.WriteLine("> Parent HideMethod");
}

class Child : Parent
{
    public Child() => Console.WriteLine("> Child Constructor");

    /*
        * - You can hide method parent by make same name in child
        */
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    public void Method() => Console.WriteLine("> Child Method");
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

    /*
        * - Using new keyword to know IDE and my team i edit to parent method
        */
    public new void HideMethod() => Console.WriteLine("> Child HideMethod");
}
