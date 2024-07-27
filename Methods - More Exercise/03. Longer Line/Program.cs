// See https://aka.ms/new-console-template for more information




double x1 = double.Parse(Console.ReadLine());  //
double y1 = double.Parse(Console.ReadLine());  //
double x2 = double.Parse(Console.ReadLine());  //
double y2 = double.Parse(Console.ReadLine());  //

double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double y4 = double.Parse(Console.ReadLine());

double distance1 = methodDistance(x1, y1, x2, y2);
double distance2 = methodDistance(x3, y3, x4, y4);

if (distance1==distance2||distance1>distance2)
{
    methodCloserToTheCoordinate(x1,y1,x2,y2);
}
else if (distance2>distance1)
{
    methodCloserToTheCoordinate(x3,y3,x4,y4);
}




double methodDistance(double n1, double n2, double n3, double n4)
{

    double distance = Math.Sqrt(Math.Pow(n3 - n1, 2) + Math.Pow(n4 - n2, 2));
    return distance;
}


void methodCloserToTheCoordinate(double n1, double n2, double n3, double n4)
{


    double xx1 = Math.Pow(n1, 2);
    double yy1 = Math.Pow(n2, 2);
    double cc1 = xx1 + yy1;
    cc1 = Math.Sqrt(cc1);

    double xx2 = Math.Pow(n3, 2);
    double yy2 = Math.Pow(n4, 2);
    double cc2 = xx2 + yy2;
    cc2 = Math.Sqrt(cc2);



    if (cc1 == cc2)
    {
        Console.WriteLine($"({n1}, {n2})({n3}, {n4})");
    }
    else if (cc1 < cc2)
    {
        Console.WriteLine($"({n1}, {n2})({n3}, {n4})");

    }
    else if (cc2 < cc1)
    {
        Console.WriteLine($"({n3}, {n4})({n1}, {n2})");

    }
}


