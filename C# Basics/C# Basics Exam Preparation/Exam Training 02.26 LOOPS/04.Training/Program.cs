using System;

class hello
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Double kilometersFirstDay = Double.Parse(Console.ReadLine());



        
        Double KIlometersNextDays = kilometersFirstDay;
        Double kilometersSum = 0;

        for (int i = 0; i < n; i++)
        {
            Double procentUvelichenie = Double.Parse(Console.ReadLine())/100;
            KIlometersNextDays = KIlometersNextDays + KIlometersNextDays * procentUvelichenie;
            kilometersSum += KIlometersNextDays;

            
        }
        Double totalKilometers = kilometersSum + kilometersFirstDay;
        if (totalKilometers >= 1000)
        {
            Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKilometers-1000)} more   kilometers!");
        }
        if (totalKilometers < 1000)
        {
            Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-totalKilometers)} more kilometers");
        }
    }
}
