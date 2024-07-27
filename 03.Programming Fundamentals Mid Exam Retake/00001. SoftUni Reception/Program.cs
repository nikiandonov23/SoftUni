// See https://aka.ms/new-console-template for more information


List<int> powerEmployers=new List<int>();     //number of students per hour

powerEmployers.Add(int.Parse(Console.ReadLine()));
powerEmployers.Add(int.Parse(Console.ReadLine()));
powerEmployers.Add(int.Parse(Console.ReadLine()));

int studentsCount=int.Parse(Console.ReadLine());
int hourCounter = 0;

while (studentsCount>0)
{
    hourCounter++;
    if (hourCounter%4==0)
    {
        continue;
    }
    
    studentsCount -= powerEmployers[0];
    studentsCount-=powerEmployers[1];
    studentsCount -= powerEmployers[2];



}

Console.WriteLine($"Time needed: {hourCounter}h.");
