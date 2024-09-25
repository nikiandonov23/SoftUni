// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices;

Dictionary<string, int> studentGrades = new Dictionary<string, int>();
studentGrades.Add("Niki",3);
studentGrades.Add("Mariq", 6);
studentGrades.Add("Petur", 4);
studentGrades.Add("Silviya", 5);

studentGrades = studentGrades.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

foreach (var student in studentGrades)
{
    Console.WriteLine($"{student.Key} has {student.Value}");
}