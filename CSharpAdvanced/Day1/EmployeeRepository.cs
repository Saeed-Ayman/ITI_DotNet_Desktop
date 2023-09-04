namespace Day1;

class EmployeeRepository
{
    public static List<Employee> Employees { get; }

    static EmployeeRepository()
    {
        Employees = new List<Employee>
        {
            new("Medhat1", 4500,"Cairo"),
            new("Saeed", 2000,"Alex"),
            new("Ayman", 10000,"Cairo"),
            new("Ahmed", 7000,"Cairo"),
            new("Ibrahim", 4000,"Alex"),
            new("Mohamed", 8000,"Alex"),
            new("Hassan", 4000,"Cairo"),
            new("Gamal", 6000,"Benha"),
            new("Medhat2", 8000,"Benha"),
        };
    }
}
