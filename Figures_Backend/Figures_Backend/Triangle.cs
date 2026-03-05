public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C { get => _c; set => ValidateC(value); }
    public double H { get => _h; set => ValidateH(value); }

    public Triangle(double a, double b, double c, double h) : base(a, b)  
    {
        C = c;
        H = h;
        Name = "Triangle";
    }

    public override double GetArea()
    {
        return (B * H) / 2;  
    }

    public override double GetPerimeter()
    {
        return A + B + C; 
    }

    private void ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException("The base must be greater than 0.");
        _c = c;
    }

    private void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException("The height must be greater than 0.");
        _h = h;
    }
}