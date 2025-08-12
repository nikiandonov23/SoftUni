// See https://aka.ms/new-console-template for more information


List<string> Phr = new List<string>()
{ "Excellent product.", "Such a great product.", "I always use that product.",
    "Best product of its category.", "Exceptional product.", "I can't live without this product."

};

List<string> Events = new List<string>()
{
    "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
    "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
};

List<string> Authors = new List<string>()
{
    "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"

};


List<string> Cities = new List<string>()
{
    "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"

};


int n=int.Parse(Console.ReadLine());

Random rnd= new Random();
int randomNum = rnd.Next(1,10);







for (int i = 0; i < n; i++)
{
    int rndPhr = rnd.Next(0, Phr.Count - 1);
    int rndEvents = rnd.Next(0, Events.Count - 1);
    int rndAuthors = rnd.Next(0, Authors.Count - 1);
    int rndCities = rnd.Next(0, Cities.Count - 1);
    Console.WriteLine($"{Phr[rndPhr]} {Events[rndEvents]} {Authors[rndAuthors]} – {Cities[rndCities]}.");

}
