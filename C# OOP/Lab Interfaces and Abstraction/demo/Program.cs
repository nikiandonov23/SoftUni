namespace demo
{
    public class Program
    {
        static void Main(string[] args)
        {

            ConsoleOperator op = new ConsoleOperator();


            string[] users = op.Read().Split().ToArray();
            string message = op.Read();
            string notificationType = op.Read();


            INotifier notifier = GetNotifier(notificationType,op);

            

            foreach (var user in users)
            {
                notifier.Notify(user, message);
            }
        }

        private static INotifier GetNotifier(string notificationType,IWriter writer)
        {
            if (notificationType=="sms")
            {
                return new SmsNotifier(writer);
            }

            if (notificationType=="email")
            {
                return new EmailNotifier(writer);
            }

            throw new InvalidOperationException("invalid notification type");



        }



    }
}
