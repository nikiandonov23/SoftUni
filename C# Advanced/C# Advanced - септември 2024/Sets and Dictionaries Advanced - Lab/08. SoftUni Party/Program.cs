// See https://aka.ms/new-console-template for more information

string command="";

HashSet<string>vipGuests=new HashSet<string>();
HashSet<string> regularGuests = new HashSet<string>();

while ((command = Console.ReadLine()) != "PARTY")
{
    char tobeChecked = command[0];
    if (char.IsDigit(tobeChecked))
    {
        vipGuests.Add(command);
    }
    else
    {
        regularGuests.Add(command);
    }
}

while ((command = Console.ReadLine()) != "END")
{
    char tobeChecked = command[0];
    if (char.IsDigit(tobeChecked))
    {
        vipGuests.Remove(command);
    }
    else
    {
        regularGuests.Remove(command);
    }
}

Console.WriteLine($"{(vipGuests.Count)+(regularGuests.Count)}");
if (vipGuests.Count>0)
{
    foreach (var guest in vipGuests)
    {
        Console.WriteLine(guest);
    }
}

if (regularGuests.Count>0)
{
    foreach (var guest in regularGuests)
    {
        Console.WriteLine(guest);
    }
}