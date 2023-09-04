/*
 * - References data types (objects, array(1D, 2D)).
 * - if Condition, switch, comparisons and logical operations.
 * - loops (while, do while, for).
 */

namespace Day2;

class Main
{
    public static void Index()
    {
        #region Get info from user
        // Take number of tracks
        Console.Write($"Number of tracks: ");
        int tracksNumber = Convert.ToInt32(Console.ReadLine());
        // Take number of student
        Console.Write($"Number of students: ");
        int studentsNumber = Convert.ToInt32(Console.ReadLine());

        int[,] tracks = new int[tracksNumber, studentsNumber];

        Console.WriteLine("-----------------------------------");

        // Take age from each student
        for (int i = 0; i < tracksNumber; i++)
        {
            Console.WriteLine($"Track{i + 1}");
            Console.WriteLine("============");

            Console.WriteLine($"Enter students age");
            Console.WriteLine("===================");
            for (int j = 0; j < studentsNumber; j++)
            {
                Console.Write($"student{j + 1} age: ");
                tracks[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------");
        }
        #endregion

        #region Get info from user
        // Display ages
        Console.WriteLine("Student ages");
        Console.WriteLine("============");
        for (int i = 0; i < tracks.GetLength(0); i++)
        {
            int sum = 0;
            int studentNumber = tracks.GetLength(1);

            Console.WriteLine($"Track{i + 1}");
            Console.WriteLine("============");

            for (int j = 0; j < studentNumber; j++)
            {
                sum += tracks[i, j];
                Console.WriteLine($"Student{j + 1}: {tracks[i, j]}");
            }

            Console.WriteLine($"Average of ages: {sum * 1.0 / studentNumber}");
            Console.WriteLine("-----------------------------------");
        }
        #endregion
    }
}
