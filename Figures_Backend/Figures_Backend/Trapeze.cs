public class Trapeze : Triangle
{
    private double _d;

    public double D
    {
        get => _d;
        set => ValidateD(value);
    }

    public Trapeze(double a, double b, double c, double d, double h) : base(a, b, c, h) 
    {
        D = d;
        Name = "Trapeze";
    }

    public override double GetArea()
    {
        return ((B + D) * H) / 2; 
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;  
    }

    private void ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException("The second base must be greater than 0.");
        _d = d;
    }
}