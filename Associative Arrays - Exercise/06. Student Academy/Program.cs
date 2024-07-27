// See https://aka.ms/new-console-template for more information


int n = int.Parse(Console.ReadLine());

Dictionary<string,List<double>> allStudents=new Dictionary<string,List<double>>();

string student = "";
for (int i = 0; i < n; i++)
{
    student= Console.ReadLine();
    double grade=double.Parse(Console.ReadLine());

    if (!allStudents.ContainsKey(student))
    {
        allStudents.Add(student, new List<double>(){grade});     //dobavqm student i ocenka v list ot ocenki

    }

    else
    {
        allStudents[student].Add(grade);
    }



}

foreach (var element in allStudents)
{
    
    double avarageGrade = element.Value.Sum()/element.Value.Count();
    if (avarageGrade<4.50)
    {
        allStudents.Remove(element.Key);
    }

}

foreach (var element in allStudents)
{
    double avarageGrade = element.Value.Sum() / element.Value.Count();
    Console.WriteLine($"{element.Key} -> {avarageGrade:f2}");
}

