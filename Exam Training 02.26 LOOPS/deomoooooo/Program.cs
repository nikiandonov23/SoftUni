using System;

class hello
{
    static void Main()
    {
        //1. Цена на ягодите в лева – реално число в интервала [0.00 … 10000.00]
        //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
        //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
        //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
        //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]
        Double strawberryPrice = Double.Parse(Console.ReadLine());

        Double bananaCount = Double.Parse(Console.ReadLine());
        Double orangeCount = Double.Parse(Console.ReadLine());
        Double raspberryCount = Double.Parse(Console.ReadLine());
        Double strawberryCount = Double.Parse(Console.ReadLine());

        Double raspberryPrice = (strawberryPrice / 2);
        Double orangePrice = (raspberryPrice - (raspberryPrice * 40 / 100));
        Double bananaPrice = (raspberryPrice - (raspberryPrice * 80 / 100));
        {
            Double strawberrySum = strawberryPrice * strawberryCount;
            Double raspberrySum = raspberryPrice * raspberryCount;
            Double orangeSum = orangePrice * orangeCount;
            Double bananaSum = bananaPrice * bananaCount;
            Console.WriteLine($"{strawberrySum+raspberrySum+orangeSum+bananaSum:f2}");
            

        }


    }
}
