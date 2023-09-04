namespace ITI.CSharpAdvanced.Day1;

public delegate bool Filter<T>(T instance);

class Main
{
    public static void Index()
    {
        Console.WriteLine("Filter by salary");
        Console.WriteLine("================");
        var list = FilterBy(EmployeeRepository.Employees, Emp => Emp.Salary > 5000);
        Print(list);

        Console.WriteLine("Filter by address");
        Console.WriteLine("================");
        list = FilterBy(EmployeeRepository.Employees, Emp => Emp.Address == "Cairo");
        Print(list);

        Console.WriteLine("Filter by name");
        Console.WriteLine("================");
        list = FilterBy(EmployeeRepository.Employees, Emp => Emp.Name.StartsWith("Med"));
        Print(list);
    }

    public static List<T> FilterBy<T>(List<T> data, Filter<T> filter)
    {
        var result = new List<T>();

        foreach (T item in data)
        {
            if (filter(item)) result.Add(item);
        }

        return result;
    }

    public static void Print<T>(List<T> list)
    {
        foreach (T item in list) Console.WriteLine(item);
    }
}
