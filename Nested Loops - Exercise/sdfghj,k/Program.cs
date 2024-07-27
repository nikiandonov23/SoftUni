using System;

class hello
{
    static void Main()
    {
        string movie = Console.ReadLine();

        double studentTicketss = 0;
        double standardTickets = 0;
        double kidTickets = 0;

        while (movie != "Finish")
        {
            double freeSeats = double.Parse(Console.ReadLine());
            string typeOfTicket = "";

            double soldTickets = 0;

            while ((typeOfTicket != "End") && (soldTickets < freeSeats))

            {
                typeOfTicket = Console.ReadLine();
                if (typeOfTicket == "student")
                {
                    studentTicketss++;
                    soldTickets++;
                }
                if (typeOfTicket == "standard")
                {
                    standardTickets++;
                    soldTickets++;

                }
                if (typeOfTicket == "kid")
                {
                    kidTickets++;
                    soldTickets++;


                }
                if (typeOfTicket == "End")
                { break; }
                
            }

            Console.WriteLine($"{movie} - {soldTickets / freeSeats * 100:f2}% full.");
            movie = Console.ReadLine();
            if (movie=="Finish")
            {
                Console.WriteLine($"Total tickets: {studentTicketss+standardTickets+kidTickets}");
                Console.WriteLine($"{studentTicketss/(studentTicketss+standardTickets+kidTickets)*100:f2}% student tickets.");
                Console.WriteLine($"{standardTickets / (studentTicketss + standardTickets + kidTickets) * 100:f2}% standard tickets.");
                Console.WriteLine($"{kidTickets / (studentTicketss + standardTickets + kidTickets) * 100:f2}% kids tickets.");


            }
        }
    }
}