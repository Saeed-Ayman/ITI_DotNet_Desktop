namespace Day5.Example;

class CollageStudent : Student
{
    public Major Major { get; set; }

    public CollageStudent(string name, int age, Gender gender, string place, Major major)
        : base(name, age, gender, Degree.University, place) => Major = major;
     
    public override string ToString() 
        => base.ToString() + $", \tMajor: {Major}";
}