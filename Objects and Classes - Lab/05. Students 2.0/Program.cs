// See https://aka.ms/new-console-template for more information




string input = "";
List<Students> allStudents = new List<Students>();

while ((input = Console.ReadLine()) != "end")
{
    string[] tockens = input.Split(" ");


    Students currentStudent = new Students();


    currentStudent.FirstName = tockens[0];
    currentStudent.LastName = tockens[1];
    currentStudent.Age = tockens[2];
    currentStudent.HomeTown=tockens[3];

    bool doesItExist = false;


    foreach (var obekt in allStudents)
    {
        if (obekt.FirstName==currentStudent.FirstName&&obekt.LastName==currentStudent.LastName)
        {
            doesItExist = true;

            obekt.Age = currentStudent.Age;
            obekt.HomeTown=currentStudent.HomeTown;


        }
    }

    if (!doesItExist)
    {
        allStudents.Add(currentStudent);
    }

}

string homeTownToPrint = Console.ReadLine();

foreach (var currentStudent in allStudents)
{
    if (currentStudent.HomeTown==homeTownToPrint)
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