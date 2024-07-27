// See https://aka.ms/new-console-template for more information



int n = int.Parse(Console.ReadLine());

int[] array=new int[n];
array[0] = 1;


for (int i = 0; i < array.Length; i++)
{
    
   

    if (array[i+1]==0)
    {

        array[i + 1] += 1;
        
    }

    if (array[i-1]>0)
    {
        if (array[i - 1] == 0)
        {
            array[i - 1] += 1;
        }
        
    }

}


