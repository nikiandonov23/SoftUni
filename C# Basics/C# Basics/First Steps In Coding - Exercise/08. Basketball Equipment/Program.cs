using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Double godishnataxa = Double.Parse(Console.ReadLine());



            Double kecove = godishnataxa- godishnataxa * 40 / 100;
            Double ekip = kecove-kecove * 20 / 100;
            Double topka = ekip / 4;
            Double acc = topka / 5;
            Double obshto = kecove + ekip + topka + acc;
            


            Console.WriteLine(obshto+godishnataxa);
        }
    }
}
