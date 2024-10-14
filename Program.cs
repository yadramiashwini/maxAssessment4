namespace maxAssessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Array to store total points for each student
            int[] totalPoints = new int[numberOfStudents];

            // Loop through each student to gather their points
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter the number of competitions attended by student {i + 1}: ");
                int numberOfCompetitions = int.Parse(Console.ReadLine());

                int studentPoints = 0;

                Console.WriteLine($"Enter the student {i + 1} points:");
                for (int j = 0; j < numberOfCompetitions; j++)
                {
                    studentPoints += int.Parse(Console.ReadLine());
                }

                totalPoints[i] = studentPoints;
            }

            // Determine which student got the maximum points
            int maxPoints = totalPoints[0];
            int maxIndex = 0;

            for (int i = 1; i < numberOfStudents; i++)
            {
                if (totalPoints[i] > maxPoints)
                {
                    maxPoints = totalPoints[i];
                    maxIndex = i;
                }
            }

            // Output the student with the maximum points
            Console.WriteLine($"Student {maxIndex + 1} got maximum points");
        }
    }
}