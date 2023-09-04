namespace Day5.Example;

class Main
{
    public static void Index()
    {
        Console.WriteLine(new Person(
            "Saeed",
            21,
            Gender.Male
        ));

        Person person1 = new Teacher(
            "Ahmed",
            32,
            Gender.Male,
            8700,
            Major.Math
        );
        Console.WriteLine(person1);

        Person person2 = new Student(
            "Aya",
            10,
            Gender.Female,
            Degree.ElementarySchool,
            "Elementary School in Cairo"
        );
        Console.WriteLine(person2);

        Person person3 = new CollageStudent(
            "Atef",
            22,
            Gender.Male,
            "Benha University",
            Major.FrondEnd
        );
        Console.WriteLine(person3);
    }
}
