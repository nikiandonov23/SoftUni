using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string input = "";

            int numberOfProblems = 0;
            int numberOfPoorGrades = 0;
            Double gradeSum = 0;
            string nameOfTaskDiffFromEnough = "";


            while (input!= "Enough")
            {
                string nameOfTask = Console.ReadLine();
                if (nameOfTask != "Enough")
                {
                    nameOfTaskDiffFromEnough = nameOfTask;
                }
                if (nameOfTask == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeSum/numberOfProblems:f2}");
                    Console.WriteLine($"Number of problems: {numberOfProblems}");
                    Console.WriteLine($"Last problem: {nameOfTaskDiffFromEnough}");
                    break;
                }

                input = Console.ReadLine();

                int inputAsNumber = int.Parse(input);

                numberOfProblems += 1;
                gradeSum += inputAsNumber;

                if (inputAsNumber <= 4)
                {
                    numberOfPoorGrades++;
                }
                if (numberOfPoorGrades >= poorGrades)
                {
                    Console.WriteLine($"You need a break, {numberOfPoorGrades} poor grades.");
                    break;
                }
                

            }

            


        }
    }
}
