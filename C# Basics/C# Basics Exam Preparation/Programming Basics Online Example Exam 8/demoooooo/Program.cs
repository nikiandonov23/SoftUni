using System;

class hello
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());         //K – цяло число в интервала [0..8]
        int L = int.Parse(Console.ReadLine());         //L – цяло число в интервала [0..9]

        int M = int.Parse(Console.ReadLine());         //M– цяло число в интервала [0..8]
        int N = int.Parse(Console.ReadLine());         //N – цяло число в интервала [0..9]

        int counter = 0;

        for (int i = K; i <= 8; i++)
        {
            for (int j = 9; j >= L; j--)
            {
                for (int p = M; p <= 8; p++)
                {
                    for (int c = 9; c >= N; c--)
                    {
                        if ((i%2==0)&&(j%2!=0)&&(p%2==0)&&(c%2!=0))
                        {
                            string firstNum = $"{i}{j}";
                            int firstNumToInt = int.Parse(firstNum);

                            string secondNum = $"{p}{c}";
                            int secondNumToInt = int.Parse(secondNum);

                            if ((firstNumToInt == secondNumToInt)&&(counter<6))
                            {
                                Console.WriteLine($"Cannot change the same player.");
                            }
                            else if (counter < 6)
                            {
                                counter++;
                                Console.WriteLine($"{i}{j} - {p}{c}");
                            }
                            else
                                break;
                        }
                    }
                }
            }
        }


    }
}