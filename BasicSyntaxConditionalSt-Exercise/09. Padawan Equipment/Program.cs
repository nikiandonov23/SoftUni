using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmaunt = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBelts = studentCount / 6;

            double sabre = sabrePrice * Math.Ceiling(studentCount * 1.1);
            double robe = robePrice * studentCount;
            double belt = beltPrice * (studentCount - freeBelts);

            double neededEquipment = sabre + robe + belt;

            

            if (moneyAmaunt>=neededEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
            }
            else if (moneyAmaunt<neededEquipment)
            {
                Console.WriteLine($"John will need {neededEquipment-moneyAmaunt:f2}lv more.");
            }

        }
    }
}
