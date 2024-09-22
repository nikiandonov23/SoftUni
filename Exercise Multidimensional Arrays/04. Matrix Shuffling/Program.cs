int[] dimentions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int row = dimentions[0];
int col = dimentions[1];

string[,] matrix = new string[row, col];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();


    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = data[j];
    }

}

string input = "";
while ((input = Console.ReadLine()) != "END")
{
    string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (tockens.Length!=5|| tockens[0] != "swap")
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    int row1 = int.Parse(tockens[1]),
        col1 = int.Parse(tockens[2]),
        row2 = int.Parse(tockens[3]),
        col2 = int.Parse(tockens[4]);

    if (    row1 < 0 || row1 >= matrix.GetLength(0) ||
            col1 < 0 || col1 >= matrix.GetLength(1) || 
            row2 < 0 || row2 >= matrix.GetLength(0) || 
            col2 < 0 || col2 >= matrix.GetLength(1)    
            )
    {
        Console.WriteLine("Invalid input!");
        continue;
        

    }

    switch (tockens[0])
    {
        case "swap":
            string n1 = matrix[row1, col1];
            string temp = matrix[row2, col2];
            matrix[row2, col2] = n1;
            matrix[row1,col1]= temp;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j > 0)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }

            break;
    }


}



