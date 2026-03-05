using Figures_Backend;
using System.Xml.Linq;

public class Square : GeometricFigure
{
    protected double _a;

    public double A
    {
        get => _a;
        set
        {
            ValidateA(value);
            _a = value;
        }
    }

    public Square(double a)
    {
        Name = "Square";
        A = a;
    }

    protected void ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Side must be greater than zero");
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
}