using System;

class hello
{
    static void Main()              //· Група до 5 човека – изкачват Мусала
                                    //· Група от 6 до 12 човека – изкачват Монблан
                                    //· Група от 13 до 25 човека – изкачват Килиманджаро
                                    //· Група от 26 до 40 човека – изкачват К2
                                    //· Група от 41 или повече човека – изкачват Еверест
    {
        int n = int.Parse(Console.ReadLine());    //broi na grupite
        Double totalNumberOfPeople = 0;            //obsh broi katera4i
        int Musala = 0;
        int Monblan = 0;
        int Kilimandjaro = 0;
        int k2 = 0;
        int everest = 0;

        Double MusalaProc = 0;
        Double MonblanProc = 0;
        Double KilimandjaroProc = 0;
        Double k2Proc = 0;
        Double everestProc = 0;






        for (int i = 0; i < n; i++)
        {
            int numberOfPeope = int.Parse(Console.ReadLine());   //nomer na katera4ite vuv vsqka grupa
            totalNumberOfPeople += numberOfPeope;

            if (numberOfPeope <= 5)
            {
                Musala += numberOfPeope;
            }
            if ((numberOfPeope >= 6) && (numberOfPeope <= 12))
            {
                Monblan += numberOfPeope;
            }
            if ((numberOfPeope >= 13) && (numberOfPeope <= 25))
            {
                Kilimandjaro += numberOfPeope;
            }
            if ((numberOfPeope >= 26) && (numberOfPeope <= 40))
            {
                k2 += numberOfPeope;
            }
            if (numberOfPeope >= 41)
            {
                everest += numberOfPeope;
            }
          





        }
        MusalaProc = Musala / totalNumberOfPeople * 100;
        MonblanProc = Monblan / totalNumberOfPeople * 100;
        KilimandjaroProc = Kilimandjaro / totalNumberOfPeople * 100;
        k2Proc = k2 / totalNumberOfPeople * 100;
        everestProc = everest / totalNumberOfPeople * 100;

        Console.WriteLine($"{MusalaProc:f2}%");
        Console.WriteLine($"{MonblanProc:f2}%");
        Console.WriteLine($"{KilimandjaroProc:f2}%");
        Console.WriteLine($"{k2Proc:f2}%");
        Console.WriteLine($"{everestProc:f2}%");
    }
}
