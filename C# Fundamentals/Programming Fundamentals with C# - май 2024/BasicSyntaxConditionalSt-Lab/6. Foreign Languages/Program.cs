using System;

namespace _6._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if ((country=="USA")||(country== "England")||(country=="Spain")||(country== "Argentina")||(country== "Mexico"))
            {
                var language = "";
                if ((country== "USA")||(country== "England"))
                {
                    language = "English";
                    Console.WriteLine($"{language}");
                }
                else if ((country == "Spain")|| (country == "Argentina") || (country == "Mexico"))
                {
                    language = "Spanish";
                    Console.WriteLine($"{language}");
                }
            }
            else
            {
                Console.WriteLine($"unknown");
            }

        }
    }
}
