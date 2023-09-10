/*
 * - var and dynamic
 * - init and object initializer
 * - extension method
 * - nullable and non-nullable datatypes
 * - non coalescing (operator (??) and assign operator (??=))
 * - Language-Integrated Query (Linq)
 *      - Select
 *      - Where
 *      - Max
 *      - Min
 *      - Average
 *      - Skip
 *      - SkipWhile
 *      - Take
 *      - TakeWhile
 *      - First
 *      - FirstOrDefault
 *      - Last
 *      - LastOrDefault
 *      - Single
 *      - SingleOrDefault
 */

namespace Linq;

static class StringExtensions
{
    // Helper function in console
    public static void Header(this string str)
    {
        Console.WriteLine("================");
        Console.WriteLine(str);
        Console.WriteLine("================");
    }

    public static void Title(this string str)
    {
        Console.WriteLine("----------");
        Console.WriteLine(str);
        Console.WriteLine("----------");
    }
}

#region Question Three Helper Classes
// Declare a class Subject that contains the following properties (Code, Name) and
// declare Student class that contains the following properties(ID, FirstName, LastName,
// Subject[]), then define List of students
class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public Subject[] Subjects { get; set; } = Array.Empty<Subject>();
}

class Subject
{
    public int Code { get; set; }
    public string? Name { get; set; }
}
#endregion

class Main
{
    public static void Index()
    {
        #region Question One
        "Question One".Header();

        var numbers = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

        // Query1: Display numbers without any repeated Data and sorted
        "Query1".Title();
        var Q1 = numbers.Distinct().Order().ToList();
        Q1.ForEach(Console.WriteLine);

        // Query2: using Query1 result and show each number and it’s multiplication
        "Query2".Title();
        var Q2 = Q1.Select(number => new { Number = number, Mulitply = number * number }).ToList();
        Q2.ForEach(Console.WriteLine);
        #endregion

        #region Question Two
        "Question Two".Header();

        string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

        #region Query expression(out of session)
        //var a = from name in names
        //        where name.Length == 3
        //        select name;
        // a.ToList().ForEach(Console.WriteLine);
        #endregion

        // Query1: Select names with length equal 3.
        "Query1".Title();
        var _Q1 = names.Where(name => name.Length == 3).ToList();
        _Q1.ForEach(Console.WriteLine);

        // Query2: Select names that contains “a” letter (Capital or Small)
        //         then sort them by length (Use toLower method and Contains method)
        "Query2".Title();
        var _Q2 = names.Where(name => name.Contains('a', StringComparison.OrdinalIgnoreCase)).ToList();
        _Q2.ForEach(Console.WriteLine);

        // Query3: Display the first 2 names
        "Query3".Title();
        var _Q3 = names.Take(2).ToList();
        _Q3.ForEach(Console.WriteLine);
        #endregion

        #region Question Three
        "Question Three".Header();

        var students = new List<Student>() {
            new () { ID = 1, FirstName = "Ali", LastName = "Mohammed", Subjects = new Subject[] {
                new () { Code = 22, Name = "EF" },
                new () { Code = 33, Name = "UML" }
            }},
            new (){ ID = 2, FirstName = "Mona", LastName = "Gala", Subjects = new Subject[] {
                new () { Code = 22, Name = "EF"},
                new () { Code = 34, Name = "XML" },
                new () { Code = 25, Name = "JS" }
            }},
            new () { ID = 3, FirstName = "Yara", LastName = "Youssef", Subjects = new Subject[] {
                new () { Code = 22, Name = "EF" },
                new () { Code = 25, Name = "JS" }
            }},
            new () { ID = 1, FirstName = "Ali", LastName = "Ali", Subjects = new Subject[] {
                new () { Code = 33, Name = "UML" }
            }},
        };

        // Query1: Display Full name and number of subjects for each student
        "Query1".Title();
        var __Q1 = students.Select(student => new
        {
            FullName = student.FirstName + " " + student.LastName,
            NumberOfSubjects = student.Subjects.Length,
        }).ToList();
        __Q1.ForEach(Console.WriteLine);

        // Query2: Write a query which orders the elements in the list by FirstName Descending
        //         then by LastName Ascending and result of query displays only first names
        //         and last names for the elements in list
        "Query2".Title();
        var __Q2 = students.
            OrderBy(student => student.LastName).
            OrderByDescending(student => student.FirstName).
            ToList();
        __Q2.ForEach(student => Console.WriteLine(student.FirstName + " " + student.LastName));

        // Query3: Display each student and student’s subject (use selectMany)
        "Query3".Title();
        var __Q3 = students.SelectMany(student => student.Subjects, (student, subject) => new
        {
            StudentName = student.FirstName + " " + student.LastName,
            SubjectName = subject.Name
        }).ToList();
        __Q3.ForEach(Console.WriteLine);
        #endregion

        #region Bonus Question
        "Bonus".Header();

        // if without using group by It's easy question
        var bonus = students.
            GroupBy(
                // Group By with full name
                student => student.FirstName + " " + student.LastName,
                // get result of grouping
                (studentName, groupStudent) => new
                {
                    StudentName = studentName,
                    Subjects = groupStudent.Select(student =>
                        student.Subjects.Select(subject => subject.Name).ToList()
                    ).
                    // because group return list<list<string>>
                    // we need destructor this list to one list by using Aggregate function
                    Aggregate(
                        // carry, obj
                        (subjects, subject) =>
                        {
                            subjects.AddRange(subject);
                            return subjects;
                        }
                     ).
                     ToList()
                }
            ).ToList();

        bonus.ForEach(r => Console.WriteLine(
            $"{r.StudentName}\n\t{string.Join("\n\t", r.Subjects)}"
        ));
        #endregion
    }
}
