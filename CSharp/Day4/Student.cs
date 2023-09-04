namespace Day4;

class Student
{
    readonly int Id;
    readonly string Name;
    readonly int Age;
    readonly Subject[] Subjects;

    public Student(int id, string name, int age, Subject[] subjects)
        => (Id, Name, Age, Subjects) = (id, name, age, subjects);

    public string Print()
    {
        string str = $"id: {Id}\nname: {this.Name}\nage: {Age}\nSubjects:\n";

        for (int i = 0; i < Subjects.Length; i++)
            str += $"\t\tSubject{i + 1}: {Subjects[i].Print()}\n";

        return str;
    }
}
