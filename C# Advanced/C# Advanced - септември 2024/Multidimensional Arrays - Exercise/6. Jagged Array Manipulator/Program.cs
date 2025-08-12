// See https://aka.ms/new-console-template for more information

int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray=new int[rows][];

for (int i = 0; i < rows; i++)
{
    int[]data=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    jaggedArray[i] = data;

}

for (int i = 0; i < rows-1; i++)
{

    if (jaggedArray[i].Length == jaggedArray[i+1].Length)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            jaggedArray[i][j] *= 2;
            jaggedArray[i + 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            jaggedArray[i][j] /= 2;
            
        }

        for (int j = 0; j < jaggedArray[i+1].Length; j++)
        {
            jaggedArray[i + 1][j] /= 2;
        }
    }

}

string command = "";
 while ((command = Console.ReadLine()) != "End")
 {
     string[] tockens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
     string action = tockens[0];
     int row=int.Parse(tockens[1]);
     int col=int.Parse(tockens[2]);
     int value=int.Parse(tockens[3]);



     if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
     {
         continue;
     }

     switch (action)
         {



             case "Add":
                 jaggedArray[row][col] += value;

                 break;

             case "Subtract":
                 jaggedArray[row][col]-=value;
                 break;
         }
    
   
 }

for (int i = 0; i < jaggedArray.Length; i++)
{

    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        if (j>0)
        {
            Console.Write(' ');
        }
        Console.Write(jaggedArray[i][j]);
    }

    Console.WriteLine();
}