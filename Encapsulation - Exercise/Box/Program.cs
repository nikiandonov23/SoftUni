namespace Box
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());

            
            try
            {
                Box currentBox = new Box(length, width, height);
                Console.WriteLine(currentBox);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
