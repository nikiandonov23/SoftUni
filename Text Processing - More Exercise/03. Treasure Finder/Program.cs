// See https://aka.ms/new-console-template for more information


List<int> key = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();


    
string input = "";
while ((input = Console.ReadLine()) != "find")
{
    List<int> lettersAsNumbers = new List<int>();

    int step = 0;




    for (int i = 0; i < input.Length; i++)
    {

        lettersAsNumbers.Add(input[i] - key[step]);

        if (step==key.Count-1)
        {
            step = 0;
            continue;
        }

        step++;
    }

    string decryptedList = "";

    for (int i = 0; i < lettersAsNumbers.Count; i++)
    {
        decryptedList += Convert.ToChar(lettersAsNumbers[i]);
    }

    int startIndexMaterial=decryptedList.IndexOf('&')+1;
    int endIndexMaterial = decryptedList.LastIndexOf('&') -startIndexMaterial;
    string material=decryptedList.Substring(startIndexMaterial, endIndexMaterial);

    int startIndexCoordinates = decryptedList.IndexOf('<') + 1;
    int endIndexCoordinates = decryptedList.IndexOf('>') - startIndexCoordinates;
    string coordinates = decryptedList.Substring(startIndexCoordinates, endIndexCoordinates);

    Console.WriteLine($"Found {material} at {coordinates}");
}

