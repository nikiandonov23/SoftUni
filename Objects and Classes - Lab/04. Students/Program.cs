// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;

List<Students> allStudents = new List<Students>();

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] tockens = input.Split(" ");

    string firstName = tockens[0];
    string lastName = tockens[1];
    string age= tockens[2];
    string homeTown= tockens[3];

    Students currentStudent = new Students();


    currentStudent.FirstName = firstName;
    currentStudent.LastName = lastName;
    currentStudent.Age = age;
    currentStudent.HomeTown = homeTown;

    allStudents.Add(currentStudent);

}

string toPrint = Console.ReadLine();

foreach (Students currentStudent in allStudents)
{
    if (toPrint==currentStudent.HomeTown)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}









class Students
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Age { get; set; }

    public string HomeTown { get; set; }



}