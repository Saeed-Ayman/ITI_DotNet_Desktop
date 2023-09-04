namespace Day7;

#pragma warning disable CS0660, CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
class Student
#pragma warning restore CS0660, CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
{
    private readonly int _id;
    private readonly string _name;
    private readonly int _age;

    public Student(int id = -1, string name = "None", int age = -1)
        => (_id, _name, _age) = (id, name, age);

    public static bool operator ==(Student s1, Student s2)
        => s1._id == s2._id && s1._name == s2._name && s1._age == s2._age;

    public static bool operator !=(Student s1, Student s2) 
        => s1._id != s2._id && s1._name != s2._name && s1._age != s2._age;

    public static bool operator <(Student s1, Student s2) => s1._age < s2._age;

    public static bool operator >(Student s1, Student s2) => s1._age > s2._age;

    public static implicit operator int(Student s) => s._id;

    public static implicit operator string(Student s) => s._name;

    public override string ToString() => $"{_id} - {_name}, {_age}";
}
