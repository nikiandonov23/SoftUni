using System.Runtime.CompilerServices;

namespace demo;

public class SmsNotifier : INotifier
{
    private readonly IWriter _writer;
    public SmsNotifier(IWriter writer)
    {
        this._writer = writer;
    }

    public bool Notify(string user, string message)
    {


        this._writer.Write($"Sending an emal to {user} : {message}");
        return true;
    }
}