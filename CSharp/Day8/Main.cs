/*
 * - Generic type (template).
 * - (var) Keyword.
 * - Object initializer.
 * - Anonymous type (class).
 * - collections (ArrayList => boxing and unboxing, HashTable).
 */

namespace Day8;

class Main
{
    public static void Index()
    {
        var students = new Dictionary<Student, List<Subject>>();

        // Hardcoded Data
        var oop = new Subject("OOP", 3);
        var dataStructure = new Subject("Data Structure", 4);
        var algorithm = new Subject("Algorithm", 3);

        students[new("Saeed Ayman", 21)] = new List<Subject> {
            new ("C#", 3),
            oop,
            dataStructure,
            algorithm,
        };

        students[new("Ahmed Ibrahim", 23)] = new List<Subject> {
            new ("PHP", 3),
            oop,
            dataStructure,
            algorithm,
            new ("Laravel Framework", 5)
        };

        students[new("Mohamed Atef", 23)] = new List<Subject> {
            new ("JS", 4),
            oop,
            dataStructure,
            algorithm,
            new ("React Framework", 5)
        };


        // print to console
        Console.WriteLine("\n-----------------------------------------------\n");
        foreach (var (student, subjects) in students)
        {
            Console.WriteLine(student);
            Console.WriteLine("\nSubjects:");

            foreach (var subject in subjects)
                Console.WriteLine($"\t{subject}");

            Console.WriteLine("\n-----------------------------------------------\n");
        }
    }
}
