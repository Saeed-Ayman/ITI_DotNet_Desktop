namespace Day2;

class Main
{
    public static void Index()
    {
        Employee e = new("Saeed");
        Employee e2 = new("Mohamed");
        Employee e3 = new("Ahmed");

        Console.WriteLine("Employees");
        Console.WriteLine("=========");
        Console.WriteLine(e);
        Console.WriteLine(e2);
        Console.WriteLine(e3);
        Console.WriteLine("--------------------------");

        Company c = new("ITI");
        Company c2 = new("Com");

        Club cl = new("Des");
        // set event's
        c.OnAddEmployee += cl.ObserveAddEmployee;
        c2.OnAddEmployee += cl.ObserveAddEmployee;

        c.AddEmployee(e);
        c.AddEmployee(e2);
        c2.AddEmployee(e3);


        Console.WriteLine("Companies");
        Console.WriteLine("=========");

        Console.WriteLine(c);
        foreach (var employee in c.GetEmployees())
            Console.WriteLine($"\t{employee}");

        Console.WriteLine(c2);
        foreach (var employee in c2.GetEmployees())
            Console.WriteLine($"\t{employee}");
        Console.WriteLine("--------------------------");

        Console.WriteLine("Club");
        Console.WriteLine("=====");
        Console.WriteLine(cl);
        foreach (var employee in cl.GetSubscriptions())
            Console.WriteLine($"\t{employee}");
        Console.WriteLine("--------------------------");
    }
}