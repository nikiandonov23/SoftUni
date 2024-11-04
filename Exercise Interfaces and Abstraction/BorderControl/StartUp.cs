namespace BorderControl
{
    public class StartUp
    {
        static void Main()
        {

            List<IIdentifiable> allSubjects = new List<IIdentifiable>();

            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tockens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tockens.Length==2)
                {
                    IIdentifiable subject = new Robot(tockens[0], tockens[1]);
                    allSubjects.Add(subject);

                }
                else if (tockens.Length==3)
                {
                    IIdentifiable subject = new Citizen(tockens[0], int.Parse(tockens[1]), tockens[2]);
                    allSubjects.Add(subject);
                }
            }
            string decryption=Console.ReadLine();

            foreach (var subject in allSubjects)
            {
                if (subject.Id.EndsWith(decryption))
                {
                    Console.WriteLine(subject.Id);
                }
            }

            
        }
    }
}
