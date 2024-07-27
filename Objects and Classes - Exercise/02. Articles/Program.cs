// See https://aka.ms/new-console-template for more information

List<string> input=Console.ReadLine()    //"{title}, {content}, {author}". 
    .Split(", ")
    .ToList();

Article currArticle = new Article(input[0], input[1], input[2]);


int n = int.Parse(Console.ReadLine());


string command = "";
for (int i = 0; i < n; i++)
{
    


    command = Console.ReadLine();
    string[] tockens = command.Split(": ");
    string cmd= tockens[0];
    string  action= tockens[1];

    switch (cmd)
    {
        case"Edit":                    //change the old content with the new one

            currArticle.Content = action;
            break;


        case "ChangeAuthor":
            currArticle.Author = action;
            break;


        case "Rename":
            currArticle.Title = action;
            break;


    }



}

Console.WriteLine(currArticle);









class Article
{
    public Article(string title, string content, string author)    //constructora mi
    {
        Title = title;
        Content = content;
        Author = author;
    }


    public void Edit()
    {
    }

    public void ChangeAuthor()
    {
    }

    public void Reanme()
    {
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }


    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }



}