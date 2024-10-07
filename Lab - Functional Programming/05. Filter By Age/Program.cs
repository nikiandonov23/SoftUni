    using System.Runtime.InteropServices;

    int n = int.Parse(Console.ReadLine());
    List<Person> allPersons=new List<Person>();
    for (int i = 0; i < n; i++)
    {
        string[] tockens=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

        string name = tockens[0];
        int age=int.Parse(tockens[1]);

        Person currentPerson=new Person();
        currentPerson.Name=name;
        currentPerson.Age=age;
        allPersons.Add(currentPerson);
        
    }
    string filterInput=Console.ReadLine();
    int ageFilter = int.Parse(Console.ReadLine());
    string format=Console.ReadLine();


    Func<Person, bool> filterFunction=null;
    switch (filterInput)
    {
        case"older":
            filterFunction = x => x.Age >= ageFilter;
            break;


        case"younger":
            filterFunction = x => x.Age < ageFilter;
            break;
        default:
            break;


    }

    allPersons = FilterPeople(allPersons, filterFunction);
    List<Person> FilterPeople(List<Person> allPersons, Func<Person, bool> filter)
    {
        return allPersons.Where(filter).ToList();
    }



    Func<Person, string> formatterFunc = null;
    switch (format)
    {
        case"name":
            formatterFunc = x => x.Name;
            break;

        case"age":
            formatterFunc=x=>x.Age.ToString();
            break;

        case"name age":
            formatterFunc = x => $"{x.Name} - {x.Age}";
            break;
    }

    PrintPeople(allPersons,formatterFunc);
    void PrintPeople(List<Person> allPersons, Func<Person, string> formatter)
    {
        foreach (var person in allPersons)
        {
            Console.WriteLine(formatter(person));
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }