using System.Text;

namespace ShoppingSpree

{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            List<Product> allProducts = new List<Product>();



            string[] inputNames = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var element in inputNames)
            {
                string[] tockens = element.Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tockens[0];
                decimal money = decimal.Parse(tockens[1]);

                try
                {
                    Person currentPerson = new Person(name, money);
                    allPersons.Add(currentPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;

                }
            }

            string[] inputProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var element in inputProducts)
            {
                string[] tockens = element.Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tockens[0];
                decimal cost = decimal.Parse(tockens[1]);

                try
                {
                    Product currentProduct = new Product(name, cost);
                    allProducts.Add(currentProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;

                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tockens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string personName = tockens[0];
                string productName = tockens[1];

                Person person = allPersons.FirstOrDefault(p => p.Name == personName);
                Product product = allProducts.FirstOrDefault(p => p.Name == productName);

                if (person != null && product != null)
                {
                    if (person.TryPurchase(product))
                    {
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                }



            }

            foreach (var person in allPersons)
            {
                Console.WriteLine(person);
            }

            





        }
    }
}
