namespace demo;

public class ConsoleOperator:IReader,IWriter
{
    public string Read()
    {
        return Console.ReadLine();  
    }

    public void Write(string textToBeWriten)
    {
        Console.WriteLine(textToBeWriten);
    }
}