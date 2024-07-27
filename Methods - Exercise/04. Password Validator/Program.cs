// See https://aka.ms/new-console-template for more information


string password = Console.ReadLine();
methodLenght(password);
methodLettersAndDigits(password);
methodHasAtleasTwoDigits(password);


bool methodLenght(string password)
{
    bool isTrue = true;

    if (password.Length < 6 || password.Length > 10)
    {


        isTrue = false;
    }
    return isTrue;
}

bool methodLettersAndDigits(string password)
{
    bool isTrue = true;

    for (int i = 0; i < password.Length; i++)
    {
        char digit = password[i];

        if (digit < 48 || digit > 57 && digit < 65 || digit > 90 && digit < 97 || digit > 122)
        {

            isTrue = false;
            break;

        }

    }
    return isTrue;

}

bool methodHasAtleasTwoDigits(string password)
{
    bool isTrue = true;

    int counter = 0;
    for (int i = 0; i < password.Length; i++)
    {
        char digit = password[i];
        if (digit >= 48 && digit <= 57)
        {
            counter++;

        }
    }

    if (counter < 2)
    {

        isTrue = false;

    }
    return isTrue;
}

if (!methodLenght(password))
{
    Console.WriteLine("Password must be between 6 and 10 characters");

}

if (!methodLettersAndDigits(password))
{
    Console.WriteLine("Password must consist only of letters and digits");

}

if (!methodHasAtleasTwoDigits(password))
{
    Console.WriteLine("Password must have at least 2 digits");
}

if (methodLenght(password) && methodLettersAndDigits(password) && methodHasAtleasTwoDigits(password))
{
    Console.WriteLine("Password is valid");
}