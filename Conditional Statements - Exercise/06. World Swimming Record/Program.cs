using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            //съпротивлението на водата го забавя на всеки 15 м. с 12.5 секунди


            Double recordSeconds = Double.Parse(Console.ReadLine()); //postijenie sekundi za rekorda

            Double raztoqnie = Double.Parse(Console.ReadLine()); //raztoqnie m 1500
            Double skorost = Double.Parse(Console.ReadLine()); //skorost m/s 20
            Double vremeIvan = (raztoqnie * skorost);                           //15175.51 correct
            Double zabavqneVremeIvan = Math.Floor(raztoqnie / 15) * 12.5;
            Double zabavqneVremeIvanF = (zabavqneVremeIvan);
            Double krainoVremeIvan = (vremeIvan + zabavqneVremeIvanF);
            
            if (recordSeconds>krainoVremeIvan)
                Console.WriteLine($" Yes, he succeeded! The new world record is {krainoVremeIvan:f2} seconds.");
            else if (recordSeconds<=krainoVremeIvan)
                Console.WriteLine($"No, he failed! He was {krainoVremeIvan-recordSeconds:f2} seconds slower.");

        }
    }
}
