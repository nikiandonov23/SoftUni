// See https://aka.ms/new-console-template for more information



string name = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
method();

void method()
{
    string word = "";

    for (int k = 1; k <= n; k++)
    {
        for (int i = 0; i < name.Length; i++)
        {
            word += name[i];
        }
    }




    Console.WriteLine(word);
}