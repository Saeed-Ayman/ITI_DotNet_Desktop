namespace Day5.SelfStudy.InheritanceWithChildMembers;

class Main
{
    /*
    * constructor no need args
    * parent.x, parent.y      - no enable to access 
    */
    public static void Parent() => new Parent();

    public static void Child()
    {
        // constructor need args
        Child child = new(5, 10);
        // can access to args in class child
        Console.WriteLine($"> Child({child.X}, {child.Y})");
    }
}

class Parent
{
    public Parent() => Console.WriteLine("> Parent Constructor");
}

class Child : Parent
{
    public int X { get; set; }
    public int Y { get; set; }

    public Child(int x, int y)
    {
        (X, Y) = (x, y);

        Console.WriteLine("> Child Constructor");
    }
}

