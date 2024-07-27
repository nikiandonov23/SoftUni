using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalMoney = 0;

            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;


            while (input!="Start")
            {
                double inputAsNumber = double.Parse(input);

                if ((inputAsNumber == 0.1) || (inputAsNumber == 0.2) || (inputAsNumber == 0.5) || (inputAsNumber == 1) || (inputAsNumber == 2))
                {
                    totalMoney += inputAsNumber;
                }


                           
                else    
                {
                    Console.WriteLine($"Cannot accept {inputAsNumber}");
                    
                }

                input = Console.ReadLine();

            }
            while (input=="Start")
            {
                while (input!="End")
                {
                    input = Console.ReadLine();
                    if (input == "Nuts")
                    {
                        if (totalMoney >= nutsPrice)
                        {
                            totalMoney -= nutsPrice;
                            Console.WriteLine($"Purchased nuts");
                            
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                    }
                    else if (input == "Water")
                    {
                        if (totalMoney >= waterPrice)
                        {
                            totalMoney -= waterPrice;
                            Console.WriteLine($"Purchased water");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                    }
                    else if (input == "Crisps")
                    {
                        if (totalMoney >= crispsPrice)
                        {
                            totalMoney -= crispsPrice;
                            Console.WriteLine($"Purchased crisps");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                    }
                    else if (input == "Soda")
                    {
                        if (totalMoney >= sodaPrice)
                        {
                            totalMoney -= sodaPrice;
                            Console.WriteLine($"Purchased soda");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                    }
                    else if (input == "Coke")
                    {
                        if (totalMoney >= cokePrice)
                        {
                            totalMoney -= cokePrice;
                            Console.WriteLine($"Purchased coke");

                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");

                        }
                    }
                    else if (input=="End")
                    {
                        Console.WriteLine($"Change: {totalMoney:f2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                  
                }
                
                
            }
        }
    }
}
