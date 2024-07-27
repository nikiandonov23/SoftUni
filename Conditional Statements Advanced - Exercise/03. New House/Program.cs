using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            Double rosePrice = 5;                        //· Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            Double daliqPrice = 3.80;                    //· Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            Double lalePrice = 2.80;                     //· Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            Double narcisPrice = 3;                      //· Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            Double gladiolaPrice = 2.50;                 //· Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            Double finalPrice = 0.0;

            if (typeOfFlowers == "Roses")
            {
                if (count > 80)
                {
                    finalPrice = (count * rosePrice) - (count * rosePrice * 0.1);
                }
                else
                {
                    finalPrice = count * rosePrice;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (count > 90)
                {
                    finalPrice = (count * daliqPrice) - (count * daliqPrice * 0.15);
                }
                else
                {
                    finalPrice = count * daliqPrice;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (count > 80)
                {
                    finalPrice = (count * lalePrice) - (count * lalePrice * 0.15);
                }
                else
                {
                    finalPrice = count * lalePrice;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (count < 120)
                {
                    finalPrice = (count * narcisPrice) + (count * narcisPrice * 0.15);
                }
                else
                {
                    finalPrice = count * narcisPrice;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (count < 80)
                {
                    finalPrice = (count * gladiolaPrice) + (count * gladiolaPrice * 0.20);
                }
                else
                {
                    finalPrice = count * gladiolaPrice;
                }
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {typeOfFlowers} and {budget - finalPrice:f2} leva left.");

            }
            else
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");













        }
    }
}
