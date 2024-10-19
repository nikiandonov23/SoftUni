using System;
using System.Collections.Generic;
using System.Linq;

namespace demoto_DOT.Net_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information


            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> swords = new Dictionary<string, int>()
{
    {"Gladius",0},
    {"Shamshir",0},
    {"Katana",0},
    {"Sabre",0},
    {"Broadsword",0},


};



            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteel = steel.Dequeue();
                int currentCarbon = carbon.Pop();
                int currentSum = currentSteel + currentCarbon;

                switch (currentSum)
                {
                    case 70:  //Gladius
                        swords["Gladius"] += 1;
                        break;

                    case 80: // Shamshir
                        swords["Shamshir"] += 1;
                        break;

                    case 90: //Katana
                        swords["Katana"] += 1;
                        break;

                    case 110:  //Sabre
                        swords["Sabre"] += 1;
                        break;

                    case 150:  //Broadsword
                        swords["Broadsword"] += 1;
                        break;

                    default:
                        carbon.Push(currentCarbon + 5);
                        break;
                }
            }

            var filteredSwords = swords.Where(x => x.Value != 0).ToDictionary(x => x.Key, x => x.Value);
            var filteredSwordsFinal = filteredSwords.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            if (filteredSwordsFinal.Count > 0)
            {
                Console.WriteLine($"You have forged {filteredSwordsFinal.Values.Sum()} swords.");
            }
            if (filteredSwordsFinal.Count == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }


            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }


            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(" ", carbon)}");
            }
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }


            if (filteredSwordsFinal.Count > 0)
            {
                foreach (var sword in swords)
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }




        }
    }
}
