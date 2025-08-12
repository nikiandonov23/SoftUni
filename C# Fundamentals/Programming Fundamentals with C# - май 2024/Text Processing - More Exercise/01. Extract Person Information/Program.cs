// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    int nameStart = input.IndexOf('@');
    int nameEnd = input.IndexOf('|') - nameStart;
    string name = input.Substring(nameStart + 1, nameEnd - 1);


    int ageStart = input.IndexOf('#');
    int ageEnd = input.IndexOf('*') - ageStart;
    string age = input.Substring(ageStart + 1, ageEnd - 1);

    Console.WriteLine($"{name} is {age} years old.");

}



