namespace Day5.Example;

class Teacher : Person
{
    public int Salary { get; set; }
    public Major Major { get; set; }

    public Teacher(string name, int age, Gender gender, int salary, Major major)
        : base(name, age, gender) => (Salary, Major) = (salary, major);

    public override string ToString()
        => base.ToString() + $", \tSalary: {Salary}, \tMajor: {Major}";
}


