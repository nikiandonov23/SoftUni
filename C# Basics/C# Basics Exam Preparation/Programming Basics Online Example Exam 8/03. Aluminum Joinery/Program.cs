using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberPVC = double.Parse(Console.ReadLine());
            string typePVC = Console.ReadLine();
            string delivery = Console.ReadLine();

            double totalPrice = 0;
            int deliveryPrice = 0;

            if (delivery == "With delivery")
            {
                deliveryPrice += 60;
            }



            if (typePVC == "90X130")
            {

                if ((numberPVC > 30) && (numberPVC <= 60))
                {
                    totalPrice += 110 * 0.95;
                }
                if (numberPVC > 60)
                {
                    totalPrice += 110 * 0.92;
                }
                if (numberPVC <= 30)
                {
                    totalPrice += 110;
                }
            }
            if (typePVC == "100X150")
            {
                if ((numberPVC > 40) && (numberPVC <= 80))
                {
                    totalPrice += 140 * 0.94;
                }
                if (numberPVC > 80)
                {
                    totalPrice += 140 * 0.90;            //popraveno
                }
                if (numberPVC <= 40)
                {
                    totalPrice += 140;
                }
            }
            if (typePVC == "130X180")
            {
                if ((numberPVC > 20) && (numberPVC <= 50))
                {
                    totalPrice += 190 * 0.93;
                }
                if (numberPVC > 50)
                {
                    totalPrice += 190 * 0.88;
                }
                if (numberPVC <= 20)
                {
                    totalPrice += 190;
                }
            }
            if (typePVC == "200X300")
            {
                if ((numberPVC > 25) && (numberPVC <= 50))
                {
                    totalPrice += 250 * 0.91;
                }
                if (numberPVC > 50)
                {
                    totalPrice += 250 * 0.86;
                }
                if (numberPVC <= 20)
                {
                    totalPrice += 250;
                }
            }





            
            if ((numberPVC >= 10)&&(numberPVC<=99))
            {
                double totalbeeeee = (numberPVC * totalPrice) + deliveryPrice;

                Console.WriteLine($"{totalbeeeee:f2} BGN");
            }
            if (numberPVC > 99)
            {
                double totalbeeeee = (numberPVC * totalPrice) + deliveryPrice;

                Console.WriteLine($"{totalbeeeee*0.96:f2} BGN");
            }
            if (numberPVC<10)
            {
                Console.WriteLine("Invalid order");

            }
        }
    }
}
