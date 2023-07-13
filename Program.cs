using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] studMarks = new string[5, 5]
        {
            {"Roll No", "Sem1", "Sem2", "Sem3", "Sem4"},
            {"1", "85", "90", "78", "92"},
            {"2", "92", "88", "95", "90"},
            {"3", "78", "86", "80", "85"},
            {"4", "90", "92", "88", "95"}
        };

        
        for (int j = 0; j < 5; j++)
        {
            Console.Write(studMarks[0, j] + "\t");
        }
        Console.WriteLine();

        
        for (int i = 1; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(studMarks[i, j] + "\t");
            }

            int totalMarks = Convert.ToInt32(studMarks[i, 1]) + Convert.ToInt32(studMarks[i, 2]) +
                Convert.ToInt32(studMarks[i, 3]) + Convert.ToInt32(studMarks[i, 4]);
            Console.Write(totalMarks);

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
