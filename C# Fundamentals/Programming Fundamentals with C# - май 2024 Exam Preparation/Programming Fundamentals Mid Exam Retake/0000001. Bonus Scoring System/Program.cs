

int n=int.Parse(Console.ReadLine());

double lectures=int.Parse(Console.ReadLine());
double additionalBonus=int.Parse(Console.ReadLine());
List<double> students=new List<double>();


double maxBonus = 0;
double bestStudent = 0;

for (int i = 1; i <=n; i++)
{
    students.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < students.Count; i++)
{
    double tempBonus = Math.Ceiling(students[i] / lectures * (5 + additionalBonus));

    if (maxBonus<tempBonus)
    {
        maxBonus=tempBonus;
        bestStudent = students[i];
    }

}

Console.WriteLine($"Max Bonus: {maxBonus}.");
Console.WriteLine($"The student has attended {bestStudent} lectures.");