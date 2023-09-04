/*
 * - overloading
 * - constructor, destructor and chaining 
 */

namespace Day4;

class Main
{
    public static void Index()
    {
        #region Get info from user
        Console.Write("Enter number of students: ");
        int StudentNumber = Convert.ToInt32(Console.ReadLine());
        var students = new Student[StudentNumber];

        Console.WriteLine("----------------------------------");

        Console.WriteLine("Enter student info");
        Console.WriteLine("==================");
        for (int i = 0; i < StudentNumber; i++)
        {
            Console.WriteLine($"Student{i + 1}");
            Console.WriteLine("==============");

            Console.Write("Id: ");
            var studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string studentName = Console.ReadLine() ?? "";

            Console.Write("Age: ");
            var studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of subject: ");
            var subjectNumber = Convert.ToInt32(Console.ReadLine());
            var studentSubjects = new Subject[subjectNumber];

            Console.WriteLine($"Enter subjects to student{i + 1}");
            Console.WriteLine("=================================");
            for (int j = 0; j < subjectNumber; j++)
            {
                Console.WriteLine($"Subject{j + 1}");
                Console.WriteLine("===============");

                Console.Write("Id: ");
                var subjectId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string subjectName = Console.ReadLine() ?? "";

                Console.Write("Duration: ");
                var subjectDuration = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-------------------------------------");

                studentSubjects[j] = new Subject(subjectId, subjectName, subjectDuration);
            }
            Console.WriteLine("***************************************");
            students[i] = new Student(studentId, studentName, studentAge, studentSubjects);
        }
        #endregion

        #region Print info to user
        Console.WriteLine("\n");
        Console.WriteLine("Print Students");
        Console.WriteLine("==============");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Student{i + 1}");
            Console.WriteLine("===============");
            Console.Write(students[i].Print());
            Console.WriteLine("-----------------------------------------------------");
        }
        #endregion
    }
}