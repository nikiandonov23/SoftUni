using System;

class hello
{
    static void Main()                                                                                  //• Козунак – 3.20 лв.
                                                                                                        //• Яйца – 4.35 лв.за кора с 12 яйца
                                                                                                        //• Курабии – 5.40 лв.за килограм
                                                                                                        //• Боя за яйца - 0.15 лв.за яйце

    {
        int numberBakes = int.Parse(Console.ReadLine());
        int numberPacketEggs = int.Parse(Console.ReadLine());
        int numberKilosSweets = int.Parse(Console.ReadLine());

        Double bakesPrice = 3.2*numberBakes;
        Double PacketEggsPrice = 4.35*numberPacketEggs;
        Double sweetsPrice = 5.40*numberKilosSweets;
        Double eggPaintPrice = 0.15*numberPacketEggs*12;

        Double sum = bakesPrice + PacketEggsPrice + sweetsPrice + eggPaintPrice;
        Console.WriteLine($"{sum:f2}");

    }
}
