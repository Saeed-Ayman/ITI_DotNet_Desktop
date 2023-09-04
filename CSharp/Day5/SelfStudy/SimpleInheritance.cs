namespace Day5.SelfStudy.SimpleInheritance;

class Main
{
    public static void Child() => new Child();
    public static void Parent() => new Parent();
}

class Parent
{
    public Parent() => Console.WriteLine("> Parent Constructor");
}

class Child : Parent
{
    public Child() => Console.WriteLine("> Child Constructor");
}

