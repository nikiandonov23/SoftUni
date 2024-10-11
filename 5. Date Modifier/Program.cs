// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Numerics;
using _5._Date_Modifier;

string inpu1=Console.ReadLine();
string input2 = Console.ReadLine();

DateModifier dateModifier=new DateModifier();

BigInteger diffrence = dateModifier.CalculateDiffrence(inpu1, input2);
Console.WriteLine(BigInteger.Abs(diffrence));



