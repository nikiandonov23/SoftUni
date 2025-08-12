// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());


bool method(int chislo)
{
    
       bool IsTrue=false;

        int iCopy = chislo;
        int digitSum = 0;
        while (iCopy > 0)
        {


            digitSum += iCopy % 10;
            iCopy /= 10;


        }

        if (digitSum % 8 == 0)
        {
            int iCopy2 = chislo;

            while (iCopy2 > 0)
            {

                int digitLast = iCopy2 % 10;
                if (digitLast % 2 != 0)
                {
                    IsTrue=true;
                    break;
                }
                iCopy2 /= 10;
            }
        }

        return IsTrue;
}

for (int i = 1; i <=n; i++)
{
    method(i);
    if (method(i))
    {
        Console.WriteLine(i);
    }
}

