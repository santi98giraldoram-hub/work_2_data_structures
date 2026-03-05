public class Kite : Rhombus
{
    private double _b;

    public double B { get => _b; set => ValidateB(value); }

    public Kite(double d1, double d2, double b) : base(d1, d2)
    {
        B = b;

        Name = "Kite";
    }

    public override double GetArea()
    {
        return base.GetArea();
    }

    public override double GetPerimeter()
    {
        return (2 * (A + B));
    }

    private void ValidateB(double b)
    {

        if (B < 0)
        {
            throw new ArgumentException("the base must be grater than 0");
        }

        _b = b;
    }
}


