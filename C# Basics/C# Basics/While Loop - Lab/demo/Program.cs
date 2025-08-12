using System;

class hello
{
    static void Main()
    {
        string name = Console.ReadLine();

        int poorGrade = 0;
        Double gradeSum = 0;
        Double classNumber = 1;

        while (classNumber<=12)
        {
            Double grade = Double.Parse(Console.ReadLine());

            if (grade >= 4)
            {
                classNumber++;
                gradeSum += grade;
            }
            if (grade < 4)
            {
                poorGrade++;
                if (poorGrade >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classNumber} grade");
                    break;
                }
                continue;
            }
        }
        if (classNumber > 12)
        {
            Console.WriteLine($"{name} graduated. Average grade: {gradeSum/12:f2}");
        }
        
    }
}
