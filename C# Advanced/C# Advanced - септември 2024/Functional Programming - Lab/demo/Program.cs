// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
List<Person> allPersons = new List<Person>();
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string name = input[0];
    int age = int.Parse(input[1]);

    Person currentPerson = new Person();
    currentPerson.Name = name;
    currentPerson.Age = age;
    allPersons.Add(currentPerson);
}
string condition = Console.ReadLine();
int threshold = int.Parse(Console.ReadLine());
string format = Console.ReadLine();

void List<Person> filterFunc(string condition, int threshold)
{
    if (condition == "younger")
    {
        allPersons = allPersons.Where(x => x.Age < threshold).ToList();
    }

    else if (condition == "older")
    {
        allPersons = allPersons.Where(x => x.Age >= threshold).ToList();
    }

    
}








public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }



}