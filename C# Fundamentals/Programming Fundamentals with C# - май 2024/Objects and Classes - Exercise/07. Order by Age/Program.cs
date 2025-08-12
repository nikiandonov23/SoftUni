// See https://aka.ms/new-console-template for more information


using System.Collections.Specialized;



List<Data> allPeople = new List<Data>();
string input = "";
while ((input = Console.ReadLine()) != "End")
{
    string[] tockens = input.Split(" ");
    string name = tockens[0];
    string id= tockens[1];
    int age= int.Parse(tockens[2]);




    Data currentPerson = new Data(name,id, age);
    allPeople.Add(currentPerson);

}


allPeople.Sort((x1,x2)=>x1.Age.CompareTo(x2.Age));


foreach (var person in allPeople)
{
    person.Print();
}


class Data
{
    public Data(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return $"{Name}\n {ID}\n {Age}";
    }

    public void Print()
    {
        Console.WriteLine($"{Name} with ID: {ID} is {Age} years old.");
    }
}
