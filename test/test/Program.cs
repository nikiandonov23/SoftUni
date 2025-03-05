namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Niki");


            Console.WriteLine(p1.Name);

            p1.Name = "Nati";
            Console.WriteLine(p1.Name);

        }
    }
}
