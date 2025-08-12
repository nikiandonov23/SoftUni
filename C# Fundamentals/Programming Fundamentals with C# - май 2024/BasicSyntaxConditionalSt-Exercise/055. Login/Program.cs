using System;

namespace _055._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] nqkvaduma = username.ToCharArray();

            Array.Reverse(nqkvaduma);
            string password = new string(nqkvaduma);

            int attempts = 4;

            while (attempts > 0)
            {
                attempts -= 1;

                string input = Console.ReadLine();

                if (input == password)
                {

                    {
                        Console.WriteLine($"User {username} logged in.");
                        break;
                    }

                }
                else
                {
                    if (attempts==0)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }
                }



            }

        }
    }
}
