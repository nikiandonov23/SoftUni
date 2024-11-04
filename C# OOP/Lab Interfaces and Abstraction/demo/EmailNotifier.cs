namespace demo;

public class EmailNotifier:INotifier
{
    private readonly IWriter _writer;

    public EmailNotifier(IWriter writer)
    {
        this._writer = writer;
    }

    public bool Notify(string user, string message)
    {
      this._writer.Write($"Sending an emal to {user} : {message}");
        return true;
    }
}