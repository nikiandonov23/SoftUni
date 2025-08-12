using System;

    class Program
    {
        static void Main()
        {
        string firstName = "Nikolay";
        string middleName = "Valentinov";
        string lastName = " Andonov";
        decimal balance = 1000;
        string bankName = "HSBC";
        object iban = "BGNV 1234 5765 3945 3445";
        object firstCreditCardNumber=1;
        object secondCreditCardNumber=2;
        object thirdCreditCardNumber=3;
        Console.WriteLine("First name:{0}",firstName);
        Console.WriteLine("Middle name:{0}",middleName);
        Console.WriteLine("Last name:{0}",lastName);
        Console.WriteLine("Balance: {0} lv",balance);
        Console.WriteLine("Bank name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",iban);
        Console.WriteLine("First credit card number: {0}",firstCreditCardNumber);
        Console.WriteLine("Second credit card number: {0}", secondCreditCardNumber);
        Console.WriteLine("Third credit card number: {0}", thirdCreditCardNumber);
        Console.ReadLine();

    }
}

