using System;
using System.ComponentModel.Design;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldLenght = int.Parse(Console.ReadLine());
            int[] bugPlaces = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] field = new int[fieldLenght];

            for (int i = 0; i < bugPlaces.Length; i++)
            {

                int bugIndex = bugPlaces[i];        //suzdavame promenliva koqto da pazi indexa za nanasqne vuv array-a "field"

                if (bugIndex >= 0 && bugIndex < fieldLenght)     //proiverqvame dali ne ni davat index po golqm ili po maluk ot fieldLenght (zadadenite parametri)
                {
                    field[bugIndex] = 1;

                }
            }

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] elements = input.Split(" ");   //tuk splita gi razbiva na 123234 sfgvsg 1243453 demek vsqko e edin element ,nishto 4e sa mn cifri
                int bugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLenght = int.Parse(elements[2]);


                if (bugIndex < 0 || bugIndex > fieldLenght - 1 || field[bugIndex] == 0)     //proiverqvame dali ne ni davat index po golqm ili po maluk ot fieldLenght (zadadenite parametri)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int lastFieldIndex = field.Length - 1;
                if (direction == "right")
                {
                    int landIndex = bugIndex + flyLenght;

                    if (landIndex > lastFieldIndex)
                    {
                        continue;
                    }

                    if (field[landIndex]==1)
                    {
                        while (field[landIndex]==1)
                        {
                            landIndex += flyLenght;
                            if (landIndex> lastFieldIndex)
                            {
                                break;
                            }
                        }

                        
                    }
                    if (landIndex <= lastFieldIndex)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = bugIndex - flyLenght;

                    if (landIndex <0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLenght;
                            if (landIndex < 0)
                            { 
                                break;
                            }
                        }

                       
                    }
                    if (landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",field));





        }
    }
}
