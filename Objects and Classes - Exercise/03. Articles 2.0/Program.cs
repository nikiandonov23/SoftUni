    // See https://aka.ms/new-console-template for more information


    int n = int.Parse(Console.ReadLine());


    List<Articles> allArticles = new List<Articles>();

    string input = "";
    for (int i = 0; i < n; i++)
    {
        input=Console.ReadLine();
        string[] tockens = input.Split(", ");

        Articles currArticles = new Articles(tockens[0], tockens[1], tockens[2]);
        allArticles.Add(currArticles);

    }


    foreach (var article in allArticles)
    {
        Console.WriteLine(article);
    }






    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }