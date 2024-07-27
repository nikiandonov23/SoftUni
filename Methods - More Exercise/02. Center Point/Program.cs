// See https://aka.ms/new-console-template for more information



double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());





void methodDouble(double n1, double n2, double n3, double n4)
{


    double xx1 = Math.Pow(x1, 2);
    double yy1 = Math.Pow(y1, 2);
    double cc1 = xx1 + yy1;
    cc1 = Math.Pow(cc1, 2);

    double xx2 = Math.Pow(x2, 2);
    double yy2 = Math.Pow(y2, 2);
    double cc2 = xx2 + yy2;
    cc2 = Math.Pow(cc2, 2);



    if (cc1 == cc2)
    {
        Console.WriteLine($"({x1}, {y1})");
    }
    else if (cc1 < cc2)
    {
        Console.WriteLine($"({x1}, {y1})");

    }
    else if (cc2 < cc1)
    {
        Console.WriteLine($"({x2}, {y2})");

    }
}


methodDouble(x1,y1,x2,y2);
