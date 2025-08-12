using System;

namespace _05._Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            int textLenght = text.Length;
            


            for (int i = 0; i < textLenght; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }

                
        }
    }
}
