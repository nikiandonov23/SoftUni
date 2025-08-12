using System;

class hello
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        Double sum = 0;                        //osrednena ocenka za edna prezentaciq
        Double finalSum = 0;                   //osrednena ocenka ot vsi4ki
        int counter = 0;                       //bro4 na vsi4ki ocenki
        int totalCounter = 0;

        while (name!="Finish")
        {
            for (int i = 1; i <= n; i++)
            {
                totalCounter++;
                counter++;
                Double grade = Double.Parse(Console.ReadLine());
                sum += grade;
                finalSum += grade;
            }
            Console.WriteLine($"{name} - {sum/counter:f2}.");
            name = Console.ReadLine();
            counter = 0;
            sum = 0;
            
        }
        if (name == "Finish")
        {
            Console.WriteLine($"Student's final assessment is {finalSum/totalCounter:f2}.");
        }
    }
}
