// See https://aka.ms/new-console-template for more information



Dictionary<string, List<string>> allCourses = new Dictionary<string, List<string>>();

string input = "";
while ((input = Console.ReadLine()) != "end")
{
    string[] tockens = input.Split(" : ");
    string courseName = tockens[0];
    string studentName = tockens[1];

    if (!allCourses.ContainsKey(courseName))
    {
        allCourses.Add(courseName, new List<string>(){studentName});
    }
    else
    {
        allCourses[courseName].Add(studentName);       //advame go v lista ot studenti ako ve4e kursa sushtestvuva
    }



}

foreach (var course in allCourses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count}");

    foreach (var student in course.Value)
    {
        Console.WriteLine($"-- {string.Join(" ", student)}");
    }
}

