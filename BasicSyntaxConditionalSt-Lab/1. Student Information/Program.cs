using System;

namespace _1._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {avarageGrade:f02}");

        }
    }
}
