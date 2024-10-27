using System.Runtime.CompilerServices;
using System.Text;

namespace Box;

public class Box
{
    private double length;

    public double Length
    {
        get { return length; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            length = value;
        }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            width = value;
        }
    }

    private double height;

    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            height = value;
        }
    }


    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double LateralSurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }

    public double Volume()
    {
        return Length*Width*Height;

    }

    public override string ToString()
    {
        StringBuilder result=new StringBuilder();
        result.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
        result.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
        result.AppendLine($"Volume - {this.Volume():f2}");
        return result.ToString().Trim();
    }
}
