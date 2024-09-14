// See https://aka.ms/new-console-template for more information


int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

Queue<int> inputt=new Queue<int>(input);

Queue<int> inputtt=new Queue<int>();

while (inputt.Count>0)
{
   int numberToPop=inputt.Dequeue();

   if (numberToPop%2==0)
   {
       inputtt.Enqueue(numberToPop);
   }

  

}

Console.WriteLine(string.Join(", ",inputtt));

