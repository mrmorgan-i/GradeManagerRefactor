using System;

namespace RefactoringHomework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GradeManager manager = new GradeManager();

            manager.LogGradeProcessingMessage();

            double[] grades = { 90, 95, 98, 100, 92 };
            manager.processGrades("Kelly", grades);

            double final = manager.calculateFinalGrade(5.0, 95);
            Console.WriteLine($"Final Grade: {final}");
        }
    }
}