using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();              //The

            double textLenght = input.Length;
            double asciiValue = 0;

            double theMostPowerfullAsciiValue = 0;
            string theMostPowerfulWord = "";
            
            while (input!= "End of words")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char bukva = input[i];
                    asciiValue += bukva;






                }

                if ((input[0] == 65) || (input[0] == 97) || (input[0] == 69) || (input[0] == 101) || (input[0] == 73) || (input[0] == 105) || (input[0] == 79) || (input[0] == 111) || (input[0] == 85) || (input[0] == 117) || (input[0] == 89) || (input[0] == 121))
                {
                    asciiValue *= input.Length;
                }
                if ((input[0] != 65) && (input[0] != 97) && (input[0] != 69) && (input[0] != 101) && (input[0] != 73) && (input[0] != 105) && (input[0] != 79) && (input[0] != 111) && (input[0] != 85) && (input[0] != 117) && (input[0] != 89) && (input[0] != 121))
                {
                    asciiValue /= input.Length;
                    asciiValue = Math.Floor(asciiValue);
                }

                if (asciiValue > theMostPowerfullAsciiValue)
                {
                    theMostPowerfullAsciiValue = asciiValue;
                    theMostPowerfulWord = input;
                }
                asciiValue = 0;

                input = Console.ReadLine();

                if (input== "End of words")
                {
                    Console.WriteLine($"The most powerful word is {theMostPowerfulWord} - {theMostPowerfullAsciiValue}");
                    break;
                }

                
            }
           

        }
    }
}
