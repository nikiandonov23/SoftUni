





using System.Threading.Channels;
using System;


List<string> input = Console.ReadLine()
    .Split(" ")
    .ToList();


Random random = new Random();


for (int i = 0; i < input.Count; i++)
{
    int randomIndex=random.Next(0,input.Count);
    string tempWord=input[i];                           ///pazi istinskata duma s istinskiq index
    input[i]=input[randomIndex];                         //slaga istinskata duma na proizvolen index
    input[randomIndex]=tempWord;                         //vrusha originalnata duma na proizvolno mqsto , zashtoto ina4e mojoe da bude izgubena !!!!

}

for (int i = 0; i < input.Count; i++)
{
    Console.WriteLine(input[i]);
}