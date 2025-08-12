// See https://aka.ms/new-console-template for more information


decimal n = decimal.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string key = input[0];
    decimal value = decimal.Parse(input[1]);

    if (!studentGrades.ContainsKey(key))
    {
        studentGrades.Add(key, new List<decimal>());
        studentGrades[key].Add(value);
    }
    else if (studentGrades.ContainsKey(key))
    {
        studentGrades[key].Add(value);
    }

}

foreach (var student in studentGrades)
{

    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(grade => grade.ToString("F2")))} (avg: {student.Value.Average():F2})");
}
