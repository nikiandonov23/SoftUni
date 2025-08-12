using System;

class hello
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());                     // 16

        int finalNumber = 0;

        for (int i = 1111; i <= 9999; i++)             //vurti cikula ot 4isla za proverqvane
        {
            string iAsString = i.ToString();           //orushta vsqko 4islo ot cikula v string
            char digit1 = iAsString[0];                //imam nomerata nekonvertirani
            char digit2 = iAsString[1];
            char digit3 = iAsString[2];
            char digit4 = iAsString[3];

            string n11 = digit1.ToString();
            string n22 = digit2.ToString();
            string n33 = digit3.ToString();
            string n44 = digit4.ToString();

            int n1 = int.Parse(n11);                //imam chislata kato int
            int n2 = int.Parse(n22);
            int n3 = int.Parse(n33);
            int n4 = int.Parse(n44);

            if ((n1 == 0) || (n2 == 0) || (n3 == 0) || (n4 == 0))
                continue;

            if ((n % n1 == 0) && (n % n2 == 0) && (n % n3 == 0) && (n % n4 == 0))
            {
                Console.Write($"{i} ");

            }
            







        }
    }
}
