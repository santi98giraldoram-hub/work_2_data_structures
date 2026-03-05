public class Rectangle : Square
{

    private double _b;

    public double B { get => _b; set => ValidateB(value);}


    public Rectangle(double a, double b) : base(a)
    {
            B = b;
        Name = "Rectangle";
    }

    public override double GetArea()
    {
        return (A*B);
    }

    public override double GetPerimeter()
    {
        return (2*(A*B));
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

