using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputPassword = Console.ReadLine();
            int counter = 1;

            int lenght = username.Length;

            string password = "";

            for (int i = lenght - 1; i >= 0; i--)
            {
                char letter = username[i];
                string stringLetter = letter.ToString();

                password += stringLetter;

            }
            while ((password != inputPassword)&&(counter<4))
            {
                counter += 1;
                Console.WriteLine("Incorrect password. Try again.");
                inputPassword = Console.ReadLine();

            }

            if (password==inputPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            if (counter>3)
            {
                Console.WriteLine($"User { username} blocked!");
            }
        }
    }
}
