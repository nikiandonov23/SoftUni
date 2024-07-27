using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                          
            int m = int.Parse(Console.ReadLine());    
            byte y = byte.Parse(Console.ReadLine());

            int nCopy = n;
            int PokeCounter = 0;

            while (nCopy>=m)
            {
                PokeCounter++;


                if (nCopy == n / 2&&y!=0)                          //DAVASHE RUNTIME ERROR 90 OT 100 ZASHTOTO Y!=0 NE BESHE VSKLIU4ENO V IF-A 
                {
                    nCopy /= y;
                }
                if (nCopy<m)
                {
                    PokeCounter -= 1;
                    break;
                }

                nCopy -= m;

               
            }
            Console.WriteLine(nCopy);
            Console.WriteLine(PokeCounter);
           

        }
    }
}
