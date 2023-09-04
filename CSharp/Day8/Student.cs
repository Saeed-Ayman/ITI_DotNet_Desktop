namespace Day8;

class Student
{
    private static int ID = 0;
    private readonly int _id;
    private readonly string _name;
    private readonly int _age;

    public Student(string name, int age) => (_id, _name, _age) = (++ID, name, age);

    public override string ToString() => $"{_id}-{_name}, {_age} years.";
}
