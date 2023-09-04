/*
 * - Abstract and Sealed(no inherit) with class's and method's.
 * - Any datatype inherit by default from object class.
 * - Static class's, member's and constructor.
 */

namespace Day6;

class Main
{
    public static void Index()
    {
        Title("Number of questions");
        int nOfMcq = Convert.ToInt32(Input("MCQ: "));
        int nOfTOrf = Convert.ToInt32(Input("True or false: "));
        End();

        int nOfQuestions = nOfMcq + nOfTOrf;
        Question[] questions = new Question[nOfQuestions];

        Title("Enter Questions");

        Console.WriteLine("> MCQ");
        for (int i = 0; i < nOfMcq; i++)
        {
            Console.WriteLine($"- Question {i + 1}:");
            string body = Input("Body: ");
            int mark = Convert.ToInt32(Input("Mark: "));

            int nOfChoose = Convert.ToInt32(Input("Number of choose: "));
            string[] chooses = new string[nOfChoose];

            for (int j = 0; j < nOfChoose; j++)
            {
                chooses[j] = Input($"Choose{j + 1}: ");
            }

            questions[i] = new Mcq(body, mark, chooses);
            End();
        }

        Console.WriteLine("> True or false");
        for (int i = 0; i < nOfTOrf; i++)
        {
            Console.WriteLine($"- Question {i + 1}:");
            string body = Input("Body: ");
            int mark = Convert.ToInt32(Input("Mark: "));

            questions[i + nOfMcq] = new TOrF(body, mark);
            End();
        }

        Title("Stored Questions");
        foreach (var question in questions)
        {
            question.Show();
        }
    }

    public static void Title(string text)
    {
        Console.WriteLine("==================================");
        Console.WriteLine(text);
        Console.WriteLine("==================================");
    }
    public static void Separator() => Console.WriteLine("-----------------------------------");
    public static void End() => Console.WriteLine("\n-----------------------------------------\n");
    public static string Input(string text)
    {
        Console.Write(text);
        return Console.ReadLine() ?? "";
    }
}
