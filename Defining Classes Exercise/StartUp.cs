using System;
using System.Collections.Generic;
using System.Linq;


namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person>allPersons=new List<Person>();

            int n = int.Parse(Console.ReadLine());
            string input = "";
            for (int i = 0; i < n; i++)
            {
                input=Console.ReadLine();
                string[] tockens=input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tockens[0];
                int age=int.Parse(tockens[1]);

                Person currentPerson=new Person(name,age);
                allPersons.Add(currentPerson);
            }


            allPersons = allPersons.OrderBy(letter=>letter.Name).Where(age => age.Age > 30).ToList();
            foreach (var persol in allPersons)
            {
                Console.WriteLine($"{persol.Name.Trim()} - {persol.Age}");
            }


        }
    }
}
