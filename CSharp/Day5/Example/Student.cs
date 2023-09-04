namespace Day5.Example;

class Student : Person
{
    public Degree Degree { get; set; }
    public string Place { get; set; }

    public Student(string name, int age, Gender gender, Degree degree, string place)
        : base(name, age, gender) => (Place, Degree) = (place, degree);

    public override string ToString()
        => base.ToString() + $", \tDegree: {Degree}, \tPlace: {Place}";
}
