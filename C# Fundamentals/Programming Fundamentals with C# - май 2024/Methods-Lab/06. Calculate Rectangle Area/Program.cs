double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double area =areaOfTriangle(width,height);
Console.WriteLine(area);
static double areaOfTriangle(double width, double height)
{ 
    return  width * height;

}

 
