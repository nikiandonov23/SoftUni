// See https://aka.ms/new-console-template for more information




int n = int.Parse(Console.ReadLine());

int counter = 0;

List<string> totalInput = new List<string>();
List<string> result=new List<string>();


while (n > counter)
{
    totalInput.Add(Console.ReadLine());

    counter++;
}
totalInput.Sort();

for (int i = 0; i < totalInput.Count; i++)
{
    Console.WriteLine($"{i+1}.{totalInput[i]}");
}


