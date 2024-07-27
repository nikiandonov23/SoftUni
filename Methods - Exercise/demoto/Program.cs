// See https://aka.ms/new-console-template for more information


string iAsString = i.ToString();

int digitSum = 0;
for (int j = 0; j < iAsString.Length - 1; j++)           //17
{
    char digit = iAsString[i];
    digitSum += digit + '0';
}