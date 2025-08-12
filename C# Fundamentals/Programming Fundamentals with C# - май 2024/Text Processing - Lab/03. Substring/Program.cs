// See https://aka.ms/new-console-template for more information



string toRemove = Console.ReadLine();
string word=Console.ReadLine();


int index = 0;
while (index!=-1)
{
     index = word.IndexOf(toRemove);
     if (index == -1)
     {
         break;
     }
    word =word.Remove(index,toRemove.Length);
   
}

Console.WriteLine(word);