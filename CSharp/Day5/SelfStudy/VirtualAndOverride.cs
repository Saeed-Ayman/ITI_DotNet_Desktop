namespace Day5.SelfStudy.VirtualAndOverride;

class Main
{
    public static void Parent() => new Parent().OverrideMethod();

    public static void Child() => new Child().OverrideMethod();

    public static void ParentEqualChildInstance()
    {
        // Parent can assign child instance but can access to child method
        Parent parent = new Child();
        parent.OverrideMethod();
    }
}

class Parent
{
    public Parent() => Console.WriteLine("> Parent Constructor");

    public virtual void OverrideMethod() => Console.WriteLine("> Parent OverrideMethod");
}

class Child : Parent
{
    public Child() => Console.WriteLine("> Child Constructor");

    /*
        * - Using override keyword to override to parent method when make instance of this class equal parent
        *   Parent p = new Child(); => make override to methods
        */
    public override void OverrideMethod() => Console.WriteLine("> Child OverrideMethod");
}
