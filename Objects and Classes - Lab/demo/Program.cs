// See https://aka.ms/new-console-template for more information





studentData Niki = new studentData() { age=int.Parse(Console.ReadLine()),name=Console.ReadLine(),school="PGEE"};
studentData Joro = new studentData() { age = 34, name = "Joro", school = "PGDD" };
studentData Natali = new studentData() { age = 33, name = "Natali", school = "Oblekloto" };


Niki.printAll();
Joro.printAll();
Natali.printAll();






class studentData
{
    public int age;
    public string name;
    public string school;

    public void printAll()                  ////pravim metod vutre v klasa koito ako iskame vikame ako ne iskame ne vikame
    {
        Console.WriteLine($"Age: {age} Name: {name} school: {school}");    
    }

}


