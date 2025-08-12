using System;

class hello
{
    static void Main()
    {
        string movieName = Console.ReadLine();

        double studentTickets = 0 ;
        double standartTickets = 0;
        double kidTickets = 0;
        double totalTickets = 0;

        while (movieName != "Finish")
        {
            double freeSeats = double.Parse(Console.ReadLine());
            double soldTickets = 0;

            string typeOfTicket = "";
            
            
            while ((typeOfTicket != "End")&&(soldTickets<freeSeats))
            {
                typeOfTicket = Console.ReadLine();


                if (typeOfTicket == "student")
                {
                    soldTickets++;
                    totalTickets++;

                    studentTickets++;
                }
                else if (typeOfTicket == "standard")
                {
                    soldTickets++;
                    totalTickets++;
                    standartTickets++;
                }
                else if (typeOfTicket == "kid")
                {
                    soldTickets++;
                    totalTickets++;

                    kidTickets++;
                }
                else if (typeOfTicket == "End")
                {
                    break;
                }
            }
            Console.WriteLine($"{movieName} - {soldTickets / freeSeats * 100:f2}% full.");
            movieName = Console.ReadLine();

        }
        if (movieName == "Finish")
        {
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standartTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTickets * 100:f2}% kids tickets.");


        }
    }
}

