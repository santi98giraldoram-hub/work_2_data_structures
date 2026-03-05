public class Parallelogram : Rectangle
{
    private double _h;

    public double H
    {
        get => _h;
        set => ValidateH(value);
    }

    public Parallelogram(double b, double h) : base(b, b) 
    { 

        H = h;
        Name = "Parallelogram";
    }

    public override double GetArea()
    {
        return B * H;           
    }

    public override double GetPerimeter()
    {
        return 2 * (B + H);     
    }

    private void ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height must be greater than 0.");
        }
        _h = h;
    }
}