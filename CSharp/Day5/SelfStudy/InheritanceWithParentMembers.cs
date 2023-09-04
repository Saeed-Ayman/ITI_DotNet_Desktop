namespace Day5.SelfStudy.InheritanceWithParentMembers;

class Main
{
    public static void Parent()
    {
        // constructor need args 
        Parent parent = new(5, 7, 10);
        // parent.y, parent.z      - no enable to access because not a public property
        Console.WriteLine($"> Parent({parent.X})");
    }

    public static void Child()
    {
        // constructor need args
        Child child = new(5, 10);
        // can access to members are public only in classes child or parent
        Console.WriteLine($"> Child({child.X})");
    }
}

class Parent
{
    public int X { get; set; }
    protected int Y { get; set; }
    private int Z { get; set; }

    public Parent(int x, int y, int z)
    {
        (X, Y, Z) = (x, y, z);

        Console.WriteLine("> Parent Constructor");
    }
}

class Child : Parent
{
    /*
        * - Must pass args to parent class constructor if not include parameterless constructor use base
        * - can set these values what do you want to pass
        * - can access to members (public, protected) from child class 
        *   by using base key word if use same name or this if use different names 
        */
    public Child(int x, int y) : base(x, y, 1)
        => Console.WriteLine("> Child Constructor");
}