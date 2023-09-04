namespace Day5.SelfStudy.MultiInheritance;

class Main
{
    public static void Parent()
    {
        Parent parent = new();
        parent.OverrideMethod();
        parent.OverrideMethod2();
    }

    public static void Child()
    {
        Child child = new();
        child.OverrideMethod();
        child.OverrideMethod2();
    }

    public static void SubChild()
    {
        SubChild child = new();
        child.OverrideMethod();
        child.OverrideMethod2();
    }

    public static void ParentEqualChildInstance()
    {
        // Parent can assign child instance but can access to child method
        Parent parent = new Child();
        parent.OverrideMethod();
        parent.OverrideMethod2();
    }
}

class Parent
{
    public Parent() => Console.WriteLine("> Parent Constructor");

    public virtual void OverrideMethod() => Console.WriteLine("> Parent OverrideMethod");

    public virtual void OverrideMethod2() => Console.WriteLine("> Parent OverrideMethod2");
}

class Child : Parent
{
    public Child() => Console.WriteLine("> Child Constructor");

    // Can override again in child classes.
    public override void OverrideMethod() => Console.WriteLine("> Child OverrideMethod");

    // This function can not override this method in child classes
    public new void OverrideMethod2() => Console.WriteLine("> Child OverrideMethod2");
}

class SubChild : Child
{
    public SubChild() => Console.WriteLine("> SubChild Constructor");

    public override void OverrideMethod() => Console.WriteLine("> SubChild OverrideMethod");

    // Can not override this method because made hide method in parent class.
    public new void OverrideMethod2() => Console.WriteLine("> SubChild OverrideMethod2");
}
