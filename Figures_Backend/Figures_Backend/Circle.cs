using System;
using System.Collections.Generic;
using System.Text;

namespace Figures_Backend { 

    internal class Circle : GeometricFigure
{
    private double _r;

    public double R
    {
        get => _r;

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Radius must be positive");
            }
            _r = value;
        }
    }

    public double circle(double r)
    {
        Name = "Circle";
        R = r;
    }

    public override double GetArea()
    {
        return (Math.PI * R * R);
    }

    public override double GetPerimeter()
    {
        return (2 * Math.PI * R);
    }


}
}

