using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = "";
            double balance = budget;

            double gamePrice = 0;


            while ((input = Console.ReadLine()) != "Game Time")
            {

                if (input == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought OutFall 4");

                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }


                }
                if (input == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought CS: OG");
                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }


                }
                if (input == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought Zplinter Zell");
                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }

                }
                if (input == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought Honored 2");
                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }


                }
                if (input == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought RoverWatch");
                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }




                }
                if (input == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (balance - gamePrice < 0)
                    {

                        Console.WriteLine("Too Expensive");

                    }
                    else if (balance - gamePrice >= 0)
                    {
                        balance -= gamePrice;
                        Console.WriteLine($"Bought RoverWatch Origins Edition");

                        if (balance - gamePrice == 0)
                        {
                            Console.WriteLine("Out of Money");
                            break;
                        }

                    }


                }


                if (input != "OutFall 4" && input != "CS: OG" && input != "Honored 2" && input != "Zplinter Zell" && input != "RoverWatch" && input != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }


            }
            if (input == "Game Time")
            {
                if (balance > 0)
                {
                    Console.WriteLine($"Total spent: ${budget - balance:f2}. Remaining: ${balance:f2}");

                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");


                }
            }





        }
    }
}
