using System;

class hello
{
    static void Main()
    {
        int examHours = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());

        int arrivalHours = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());
        string lateOnTimeEarly = "";

        Double examTimeInMinutes = examHours * 60 + examMinutes;                  ///konvertirano vreme v minuti IZPIT
        Double arrivalTimeInMinutes = arrivalHours * 60 + arrivalMinutes;         ///konvertirano vreme v minuti PRISTIGANE

        Double differenceInMinutes = examTimeInMinutes - arrivalTimeInMinutes;    ///razlikata vuv vremeto na pristigane i izpita (IZPIT-PRISTIGANE)



        if (differenceInMinutes < 0)
        {
            lateOnTimeEarly = "Late";
            differenceInMinutes = differenceInMinutes * -1;
            if ((differenceInMinutes <= 59)&&(differenceInMinutes>=10))
            {
                Console.WriteLine(lateOnTimeEarly);
                Console.WriteLine($"{differenceInMinutes % 60} minutes");
            }
            if (differenceInMinutes > 59) 
            {

                Console.WriteLine(lateOnTimeEarly);
                Console.WriteLine($"{(differenceInMinutes - differenceInMinutes % 60) / 60} hours  {differenceInMinutes % 60} minutes");
            }
            if (differenceInMinutes < 10)
            {
                Console.WriteLine(lateOnTimeEarly);
                Console.WriteLine($" 0{differenceInMinutes % 60} minutes");
            }


        }


    }
}
